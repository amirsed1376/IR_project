
import sqlite3
import os
from time import strptime


class SqlManager:
    def __init__(self, file):
        self.conn = sqlite3.connect(file)
        self.crs = self.conn.cursor()


def create_folder(address):
    if not os.path.exists(address):
        os.makedirs(address)


def get_address_list(address):
    result_list = list()
    for root, dirs, files in os.walk(os.path.abspath(address)):
        for file in files:
            result_list.append(os.path.join(root, file))
    return result_list


def convert_time(time):
    time = str(time).strip()
    if " " in time:
        try:
            splits = time.split(" ")
            return "{}-{}-{}".format(splits[0].strtip(), strptime(splits[1].strtip(), '%b').tm_mon, splits[2])
        except:
            return None
    elif "-" in time:
        return time
    else:
        try:
            int(time)
            return "{}-01-01".format(time)
        except:
            return None
