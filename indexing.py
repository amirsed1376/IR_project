from elasticsearch import Elasticsearch
import os
import json
import requests
import pandas as pd
from needed import SqlManager, get_address_list   ,convert_time


class CoronaIndexElasticSearch():
    def __init__(self, host, sql_file="information.sqlite", index_name="corona_index", ):
        self.client = Elasticsearch(hosts=[host])
        self.index_name = index_name
        self.url = "http://" + host + "/"
        self.create_index(index_name)
        self.sql_manager = SqlManager(sql_file)

    def meta_data_pre_process(self, df):
        df["publish_time"] = df["publish_time"].apply(lambda x: convert_time(x))
        print(df["publish_time"])
        # df["publish_time"]=strptime(df["publish_time"].s,'%b').tm_mon
        return df

    def save_to_elasticsearch(self, address_list):
        for index, address in enumerate(address_list):
            data = dict(json.load(open(address, "r")))
            sha = str(address).split("/")[-1].split(".")[0].strip()
            sql = "select publish_time from information where sha = '{}'".format(sha)
            try:
                result = self.sql_manager.crs.execute(sql).fetchall()[0][0]
            except:
                result = None
            try:
                data["publish_time"] = result
                self.client.index(index=self.index_name, body=data)
            except Exception as e:
                print(e)

    def delete_index_from_elasticsearch(self):
        self.client.indices.delete(index=self.index_name)

    def create_index(self, index_name):

        if self.client.indices.exists(index=index_name):
            print("{} index is existed".format(index_name))
            return
        else:
            response = self.client.indices.create(index=index_name)
            self.update_index_settings(json.dumps({"index.blocks.read_only_allow_delete": "false"}))
            self.update_index_settings(json.dumps({"index.mapping.total_fields.limit": 100000}))
            self.update_index_settings(json.dumps({"analysis": {
                "analyzer": {
                    "default": {
                        "type": "standard",
                        "analyzer": "rebuilt_standard",
                        "tokenizer": "standard"
                    },
                    "rebuilt_standard": {
                        "filter": [
                            "lowercase",
                            "ngram",
                        ],
                        "tokenizer": "standard"
                    }
                }
            }
            }))

        print(response)
        print("{} index created".format(index_name))

    def update_index_settings(self, settings: json):
        response = requests.put(self.url + self.index_name + "/_settings/",
                                headers={"Content-Type": "application/json"},
                                data=settings)
        if json.loads(response.text).get("error", None) is not None:
            requests.post(self.url + self.index_name + "/_close")
            requests.put(self.url + self.index_name + "/_settings/",
                         headers={"Content-Type": "application/json"},
                         data=settings)
            requests.post(self.url + self.index_name + "/_open")

    def meta_data_to_sql(self, address):
        df = pd.read_csv(address)
        columns = [col.replace(" ", "_") for col in df.columns]
        df.columns = columns
        meta_df = self.meta_data_pre_process(df=df)
        meta_df.to_sql(name="information", con=self.sql_manager.conn, if_exists="replace")


if __name__ == '__main__':
    elastic_Search = CoronaIndexElasticSearch("localhost:9200")
    addresses = get_address_list("cord-19_2020-03-13/2020-03-13/jsons")
    # elastic_Search.save_to_elasticsearch(address_list=addresses)
    elastic_Search.meta_data_to_sql(address="cord-19_2020-03-13/2020-03-13/all_sources_metadata_2020-03-13.csv")
    # elastic_Search.delete_index_from_elasticsearch()
