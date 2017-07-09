using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp_PKU.Week5
{
    public class ListTest

    {

        public static void Test()

        {

            List<string> fruits = new List<string>();

            fruits.Add("Apple");

            fruits.Add("Bananas");

            fruits.Add("Carrot");

            Console.WriteLine("Count: {0}", fruits.Count);
 
            PrintValues1(fruits);
            fruits.Reverse();
            PrintValues2(fruits);
            fruits.Sort((x, y) => x.Length - y.Length); //sorting
            PrintValues3(fruits);

        }

        static void PrintValues1(IList<string> myList)

        {

            for (int i = 0; i < myList.Count; i++)

                Console.Write("{0}\n", myList[i]);

        }

        static void PrintValues2(IList<string> myList)

        {

            foreach (string item in myList)

                Console.Write("{0}\n", item);

        }

        static void PrintValues3(IEnumerable<string> myList)

        {

            IEnumerator<string> myEnumerator = myList.GetEnumerator();

            while (myEnumerator.MoveNext())

                Console.Write("{0}\n", myEnumerator.Current);

            Console.WriteLine();

        }

    }

    public class SamplesHashtable

    {

        public static void Test()

        {

            Hashtable myHT = new Hashtable();

            myHT.Add("Ton V. Bergyk", "023-010-66756");

            myHT.Add("Tom Sony", "086-010-27654");

            myHT.Add("Mr. John", "071-222-33445");

            myHT["Mr. John"] = "071-222-33445"; //加入或修改

            PrintKeysAndValues(myHT);

            PrintByKeys(myHT);

        }

        public static void PrintKeysAndValues(Hashtable myList)

        {

            IDictionaryEnumerator myEnumerator = myList.GetEnumerator();

            while (myEnumerator.MoveNext())

                Console.WriteLine("\t{0}:\t{1}",

                myEnumerator.Key, myEnumerator.Value);

            Console.WriteLine();

        }

        public static void PrintByKeys(Hashtable myList)

        {

            IEnumerator ie = myList.Keys.GetEnumerator();

            while (ie.MoveNext())

            {

                object key = ie.Current;

                object value = myList[key];

                Console.WriteLine("\t{0}:\t{1}", key, value);

            }

            Console.WriteLine();

            foreach (string key in myList.Keys)

            {

                Console.WriteLine("\t{0}:\t{1}", key, myList[key]);

            }

        }

    }
}
