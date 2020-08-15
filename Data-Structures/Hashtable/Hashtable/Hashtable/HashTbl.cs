using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class HashTbl<T>
    {
        public LinkedList<LinkedListNode<Node<T>>>[] Map { get; set; }
        public HashTbl(int size)
        {
            Map = new LinkedList<LinkedListNode<Node<T>>>[size];
        }

        /// <summary>
        /// Computes a hash integer from a given key value
        /// </summary>
        /// <param name="key">the given key to hash</param>
        /// <returns>index of the array placement</returns>
        private int GetHash(string key)
        {
            // Determine our alogirithm for our hash.
            // a string is a list of char
            // a char is a numeric value

            int total = 0;
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            int primeValue = total * 599;
            int index = primeValue % Map.Length;

            return index;

        }

        /// <summary>
        /// Adds a key/value pair of elements into a node
        /// in a linked list in one of the Table buckets
        /// </summary>
        /// <param name="key">The given key to hash and add to the table</param>
        /// <param name="value">The unique value to add to the table</param>
        public void Add(string key, T value)
        {
            int index = GetHash(key);
            Node<T> htNode = new Node<T>(value, key);
            LinkedListNode<Node<T>> node = new LinkedListNode<Node<T>>(htNode);

            if (Map[index] is null)
            {
                // instantiate a new linked list
                Map[index] = new LinkedList<LinkedListNode<Node<T>>>();

            }

            Map[index].AddLast(node);

        }

        /// <summary>
        /// Takes in a unique key and returns the value from the hashtable
        /// </summary>
        /// <param name="key">The unique key value hashed in the table</param>
        /// <returns>The matching value to the key from the hashtable+</returns>
        public T Get(string key)
        {
            int index = GetHash(key);
            if (!(Map[index] is null))
            {
                if (Map[index].Count == 1)
                {
                    var first = Map[index].First;
                    // {LinkedListNode} {HashtTableNode Value} {Property}
                    return first.Value.Value.Value;
                }
                else
                {
                    var current = Map[index].First;
                    while (current != null)
                    {
                        if (current.Value.Value.Key == key)
                        {
                            return current.Value.Value.Value;
                        }
                        current = current.Next;
                    }
                }
            }
            return default;
        }

        /// <summary>
        /// Takes in the key and returns a boolean, indicating if the key 
        /// exists in the hashtable
        /// </summary>
        /// <param name="key">The unique key value hashed in the table</param>
        /// <returns>True if the key exists in the table, false if it does not</returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);

            var location = Map[index];

            if (!(location is null))
            {
                var current = Map[index].First;

                while (current != null)
                {
                    if (current.Value.Value.Key == key)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
