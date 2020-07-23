from indexing import CoronaIndexElasticSearch
from needed import get_address_list
from page_rank import add_page_ranks


def indexing(elastic):
    jsons_directories=input("jsons_directories:")
    meta_data_csv = input("input meta data csv address")
    addresses = get_address_list(jsons_directories)
    elastic.meta_data_to_sql(address=meta_data_csv)
    elastic.save_to_elasticsearch(address_list=addresses)


def remove_elastic_search(elastic):
    elastic.delete_index_from_elasticsearch()


if __name__ == '__main__':
    elastic_url = input("input elastic url [for example localhost:9200]:")
    print(
        "1 : for delete elastic search\n "
        "2 : for indexing\n"
        "3: for ")
    while True:
        elastic_search = CoronaIndexElasticSearch(elastic_url)

        command = input("input command: ")

        if command.strip() == "1":
            remove_elastic_search(elastic=elastic_search)

        if command.strip() == "2":
            indexing(elastic=elastic_search)

        if command.strip() == "3":
            alpha = input("alpha = ")
            add_page_ranks(alpha=alpha, elastic_url=elastic_url)
