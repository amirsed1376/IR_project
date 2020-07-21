from elasticsearch import Elasticsearch
import os
import json


def get_address_list(address):
    result_list = list()
    for root, dirs, files in os.walk(os.path.abspath(address)):
        for file in files:
            result_list.append(os.path.join(root, file))
    return result_list


class CoronaIndexElasticSearch():
    def __init__(self, host):
        self.client = Elasticsearch(hosts=[host])
        self.create_index("corona_index")
        self.index_name = "corona_index"

    def save_to_elasticsearch(self, address_list):
        for address in address_list:
            data = json.load(open(address, "r"))
            self.client.index(index=self.index_name, doc_type='doc', body=data)

    def delete_index_from_elasticsearch(self):
        pass

    def create_index(self, index_name):
        if self.client.indices.exists(index=index_name):
            print("{} index is existed".format(index_name))
            return
        else:
            self.client.indices.create(index=index_name)
            print("{} index created".format(index_name))


if __name__ == '__main__':
    elastic_Search = CoronaIndexElasticSearch("localhost:9200")
    address_list = get_address_list("cord-19_2020-03-13/2020-03-13/jsons")
    elastic_Search.save_to_elasticsearch(address_list=address_list)
