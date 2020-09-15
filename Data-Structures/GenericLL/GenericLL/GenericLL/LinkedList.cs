using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLL
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Current { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        /// <summary>
        /// This method inserts a new node with an O(1) operation to the front of the linked list.
        /// </summary>
        /// <param name="value">The value of the new node to be inserted into the linked list</param>
        public void Insert(T value)
        {
            Current = Head;

            // Instantiate the new node to be added 
            Node<T> node = new Node<T>(value);
            node.Next = Head;
            Head = node;
        }

        public bool Includes(T value)
        {
            Current = Head;

            while (Current != null)
            {
                if (Current.Value.Equals(value))
                {
                    return true;
                }

                Current = Current.Next;
            }

            return false;
        }

        
    }
}
