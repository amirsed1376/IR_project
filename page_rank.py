from indexing import CoronaIndexElasticSearch
import json
from pprint import pprint
from scipy import sparse
import numpy as np
import networkx as nx
import matplotlib.pyplot as plt
from scipy.sparse import csc_matrix


def page_rank(G, s=.85, maxerr=.0001):
    n = G.shape[0]
    A = csc_matrix(G, dtype=np.float)
    rsums = np.array(A.sum(1))[:, 0]
    ri, ci = A.nonzero()
    A.data /= rsums[ri]

    sink = rsums == 0

    ro, r = np.zeros(n), np.ones(n)
    while np.sum(np.abs(r - ro)) > maxerr:
        ro = r.copy()
        for i in range(0, n):
            Ai = np.array(A[:, i].todense())[:, 0]
            Di = sink / float(n)
            Ei = np.ones(n) / float(n)

            r[i] = ro.dot(Ai * s + Di * s + Ei * (1 - s))

    return r / float(sum(r))


def add_page_ranks(alpha=0.85, elastic_url="localhost:9200"):
    elastic = CoronaIndexElasticSearch(elastic_url)
    body = {"_source": ["metadata.title", "bib_entries"],
            "query":
                {"match_all": {}, },
            "size": 10000
            # "size": 100
            }

    elements = elastic.client.search(index=elastic.index_name, body=json.dumps(body), scroll="1m", )
    items = elements["hits"]["hits"]
    titles = []
    references = []
    ref_indexes_list = []
    for doc in items:
        refs = []
        bib_entries = doc["_source"]["bib_entries"]
        for key in bib_entries.keys():
            refs.append(bib_entries[key]["title"])
        references.append(refs)
        titles.append(doc["_source"]["metadata"]["title"])
    edges = []
    for index, ref_list in enumerate(references):
        ref_indexes = []
        for ref in ref_list:
            try:
                index2 = titles.index(ref)
                ref_indexes.append(index2)
                edges.append((index, index2))
            except:
                pass
        ref_indexes_list.append(ref_indexes)
        # print(ref_indexes)

    weights = []
    nodes = []
    for i in range(len(titles)):
        weights.append(1)
        nodes.append(i)

    d = len(nodes)
    matrix = [[0 for x in range(d)] for y in range(d)]
    for edge in edges:
        matrix[edge[0]][edge[1]] = 1
    G = np.array(matrix)
    ranks = page_rank(G, s=.86)

    for index, doc in enumerate(items):
        elastic.add_field_doc(doc_id=doc["_id"],
                              script=json.dumps({"script": "ctx._source.page_rank = {}".format(ranks[index])}))


if __name__ == '__main__':
    add_page_ranks(alpha=0.5)
