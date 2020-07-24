from indexing import CoronaIndexElasticSearch
from needed import get_address_list
from page_rank import add_page_ranks
import sys


def indexing(elastic,jsons_directories,meta_data_csv):
    addresses = get_address_list(jsons_directories)
    elastic.meta_data_to_sql(address=meta_data_csv)
    elastic.save_to_elasticsearch(address_list=addresses)


def remove_elastic_search(elastic):
    elastic.delete_index_from_elasticsearch()


if __name__ == '__main__':
    if len(sys.argv) > 1:
        elastic_url = sys.argv[2]
        elastic_search = CoronaIndexElasticSearch(elastic_url)
        if sys.argv[1] == "1":
            remove_elastic_search(elastic=elastic_search)
        elif sys.argv[1]=="2":
            indexing(elastic=elastic_search,jsons_directories=sys.argv[3],meta_data_csv=sys.argv[4])
        elif sys.argv[1]=="3":
            add_page_ranks(alpha=sys.argv[3], elastic_url=elastic_url)
        print(sys.argv)
        sys.exit(0)

    elastic_url = input("input elastic url [for example http://localhost:9200/ ]:")
    print(
        "1 : for delete elastic search\n"
        "2 : for indexing\n"
        "3 : for page ranking")
    while True:
        elastic_search = CoronaIndexElasticSearch(elastic_url)

        command = input("input command: ")

        if command.strip() == "1":
            remove_elastic_search(elastic=elastic_search)

        if command.strip() == "2":
            jsons_directories=input("jsons_directories:")
            meta_data_csv = input("input meta data scv address")
            indexing(elastic=elastic_search,jsons_directories=jsons_directories,meta_data_csv=meta_data_csv)

        if command.strip() == "3":
            alpha = input("alpha = ")
            add_page_ranks(alpha=alpha, elastic_url=elastic_url)
