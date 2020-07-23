from indexing import CoronaIndexElasticSearch
import requests
from pprint import pprint


def search_by_title(word, url="http://localhost:9200/corona_index/"):
    response = requests.get(url + "_doc/_search?q=metadata.title:{}".format(word))
    pprint(response.json())


def search_by_text(word, url="localhost:9200"):
    pass


if __name__ == '__main__':
    content = input("search = ")
    search_by_title(content)
