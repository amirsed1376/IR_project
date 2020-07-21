from elasticsearch import Elasticsearch
import os
import json
import requests


def get_address_list(address):
    result_list = list()
    for root, dirs, files in os.walk(os.path.abspath(address)):
        for file in files:
            result_list.append(os.path.join(root, file))
    return result_list


class CoronaIndexElasticSearch():
    def __init__(self, host):
        self.client = Elasticsearch(hosts=[host])
        self.index_name = "corona_index"
        self.url="http://"+host+"/"
        self.create_index("corona_index")

    def save_to_elasticsearch(self, address_list):
        for index, address in enumerate(address_list):
            data = dict(json.load(open(address, "r")))
            self.client.index(index=self.index_name, body=data)

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
        print(self.url)
        response = requests.put(self.url + self.index_name + "/_settings/",
                                headers={"Content-Type": "application/json"},
                                data=settings)
        if json.loads(response.text).get("error", None) is not None:
            res1 = requests.post(self.url + self.index_name + "/_close")
            print(res1.text)
            response = requests.put(self.url + self.index_name + "/_settings/",
                                    headers={"Content-Type": "application/json"},
                                    data=settings)
            print(response.text)
            res2 = requests.post(self.url + self.index_name + "/_open")
            print(res2.text)


if __name__ == '__main__':
    elastic_Search = CoronaIndexElasticSearch("localhost:9200")
    print(elastic_Search.url)
    addresses = get_address_list("cord-19_2020-03-13/2020-03-13/jsons")
    # elastic_Search.save_to_elasticsearch(address_list=addresses)
    # elastic_Search.delete_index_from_elasticsearch()
