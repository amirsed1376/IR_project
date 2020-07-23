from indexing import CoronaIndexElasticSearch
import json
from pprint import pprint
from fast_pagerank import pagerank
from scipy import sparse
import numpy as np
import networkx as nx
import matplotlib.pyplot as plt



def make_matrix():
    elastic = CoronaIndexElasticSearch("localhost:9200")
    body = {"_source": ["metadata.title", "bib_entries"],
            "query":
                {"match_all": {}, },
            "size": 10000
            }

    elements = elastic.client.search(index=elastic.index_name, body=json.dumps(body), scroll="1m", )
    items = elements["hits"]["hits"]
    titles = []
    references = []
    ref_indexes_list =[]
    for doc in items:
        refs = []
        bib_entries = doc["_source"]["bib_entries"]
        for key in bib_entries.keys():
            refs.append(bib_entries[key]["title"])
        references.append(refs)
        titles.append(doc["_source"]["metadata"]["title"])
    print(len(titles))
    edges = []
    for index , ref_list in enumerate(references):
        ref_indexes = []
        for ref in ref_list:
            try:
                index2=titles.index(ref)
                ref_indexes.append(index2)
                edges.append((index,index2))
            except:
                pass
        ref_indexes_list.append(ref_indexes)
        # print(ref_indexes)

    weights=[]
    nodes=[]
    for i in range(len(titles)):
        weights.append(1)
        nodes.append(i)
    A = np.array(edges)

    # G = sparse.csr_matrix((weights, (A[:, 0], A[:, 1])), shape=(4, 4))
    # G = sparse.csr_matrix((weights, (A[:,0], A[:,1])),shape=(len(titles),len(titles)))
    G = nx.DiGraph()
    G.add_nodes_from(nodes)
    G.add_edges_from(edges)
    print(G.nodes())
    print(G.edges())
    # nx.draw(G, with_labels=True)
    # plt.show()


if __name__ == '__main__':
    make_matrix()
