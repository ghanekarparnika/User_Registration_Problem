using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    public class MyHashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        private readonly int size;
        private readonly LinkedList<MyMapNode<K, V>>[] items;
        public MyHashTable(int size)
        {
            this.size = size;
            this.items = new LinkedList<MyMapNode<K, V>>[size];
        }
        // Hash function to determine the index based on the key's hash code
    private int GetArrayIndex(K key)
        {
            int hashCode = key.GetHashCode();
            int index = hashCode % size;
            return Math.Abs(index); // Ensure a non-negative index
        }
        // Add a key-value pair to the hash table
        public void Add(K key, V value)
        {
            int index = GetArrayIndex(key);
            if (items[index] == null)
            {
                items[index] = new LinkedList<MyMapNode<K, V>>();
            }

            // Check if the key already exists in the list
            MyMapNode<K, V> existingNode = items[index].FirstOrDefault(node => node.Key.Equals(key));

            if (existingNode == null)
            {
                items[index].AddLast(new MyMapNode<K, V> { Key = key, Value = value });
            }
            else
            {
                existingNode.Value = value; // Update the value if the key already exists
            }

        }
        // Get the value associated with a key
        public V Get(K key)
        {
            int index = GetArrayIndex(key);
            if (items[index] != null)
            {
                MyMapNode<K, V> node = items[index].FirstOrDefault(n => n.Key.Equals(key));
                if (node != null)
                {
                    return node.Value;
                }
            }
            return default(V); // Key not found
        }

        // Implement GetEnumerator to enable foreach iteration
        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            return items
                .Where(list => list != null)
                .SelectMany(list => list.Select(node => new KeyValuePair<K, V>(node.Key, node.Value)))
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Remove a key-value pair from the hash table
        public void Remove(K key)
        {
            int index = GetArrayIndex(key);
            if (items[index] != null)
            {
                LinkedListNode<MyMapNode<K, V>> currentNode = items[index].First;

                while (currentNode != null)
                {
                    if (currentNode.Value.Key.Equals(key))
                    {
                        items[index].Remove(currentNode);
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

    }
}