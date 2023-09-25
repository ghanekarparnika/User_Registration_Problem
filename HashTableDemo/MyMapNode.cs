using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    public class MyMapNode<K, V>
    {
        //declaring variables
        private readonly int size;
        private readonly LinkedList<keyValue<K, V>>[] items;


        //defining contructor
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<K, V>>[size];

        }

        //structure of key value using get set properties
        public struct keyValue<k, v>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

        //defining add method to add elements
        public void Add(K key , V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);
            keyValue<K, V> item = new keyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        //
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (keyValue<K,V> item in linkedlist)
            {
                if(item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);

        }
        public int GetArrayPosition(K key)
        {
            //for finding position use key.Hashcode() % size of array
            int position =key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<keyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<keyValue<K, V>> linkedlist = items[position];
            if(linkedlist == null)
            {
               linkedlist = new LinkedList<keyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }

        //to get the frequency
        public void GetFrequency(V Values)
        {
            int frequency = 0;
            foreach(LinkedList<keyValue<K,V>>list in items)
            {
                if(list==null)
                {
                    continue;

                }
                foreach (keyValue<K, V> check in list)
                {
                    if (check.Equals(null))
                    {
                        continue;

                    }
                    if(check.Value.Equals(Values))
                    {
                        frequency++;
                    }
                }

            }
            Console.WriteLine("Frequency of is"+Values,frequency);
        }
      
    }
}
