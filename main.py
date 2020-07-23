from indexing import CoronaIndexElasticSearch
from needed import get_address_list


def indexing(elastic):
    addresses = get_address_list("cord-19_2020-03-13/2020-03-13/jsons")
    elastic.meta_data_to_sql(address="cord-19_2020-03-13/2020-03-13/all_sources_metadata_2020-03-13.csv")
    elastic.save_to_elasticsearch(address_list=addresses)


def remove_elastic_search(elastic):
    elastic.delete_index_from_elasticsearch()


if __name__ == '__main__':
    print("1: for indexing\n"
          "2 : for delete elastic search\n ")
    while True:
        elastic_search = CoronaIndexElasticSearch("localhost:9200")

        command = input("input command: ")
        if command.strip() == "1":
            indexing(elastic=elastic_search)
        if command.strip() == "2":
            remove_elastic_search(elastic=elastic_search)
