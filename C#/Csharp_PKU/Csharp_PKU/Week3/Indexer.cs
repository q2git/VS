using System;
using System.Windows.Forms;

namespace Csharp_PKU.Week3
{
    class IndexerRecord

    {

        private string[] data = new string[6];

        private string[] keys = {

            "Author", "Publisher", "Title",

            "Subject", "ISBN", "Comments"

            };

        //注：程序中用了两种方法来索引：

        //一是整数作下标，二是字符串（关键词名）作下标

        public string this[int idx]

        {

            set

            {

                if (idx >= 0 && idx < data.Length)

                    data[idx] = value;

            }

            get

            {

                if (idx >= 0 && idx < data.Length)

                    return data[idx];

                return null;

            }

        }

        public string this[string key]

        {

            set

            {

                int idx = FindKey(key);

                this[idx] = value;

            }

            get

            {

                return this[FindKey(key)];

            }

        }

        private int FindKey(string key)

        {

            for (int i = 0; i < keys.Length; i++)

                if (keys[i] == key) return i;

            return -1;

        }

        public static void Test()

        {

            IndexerRecord record = new IndexerRecord();

            record[0] = "马克-吐温";

            record[1] = "Crox出版公司";

            record[2] = "汤姆-索亚历险记";

            MessageBox.Show(record["Title"]);

            MessageBox.Show(record["Author"]);

            MessageBox.Show(record["Publisher"]);

        }

    }

}
