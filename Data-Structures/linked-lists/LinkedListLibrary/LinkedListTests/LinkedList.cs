using LinkedListLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListTests
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            //Current = Head;
        }

        /// <summary>
        /// Inserts a new node with an O(1) operation to the front of the linked list oper
        /// </summary>
        public void Insert(int value)
        {
            Current = Head;
            // create the new node that needs to be added 
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value">searchable value</param>
        /// <returns>response </returns>
        public bool Includes(int value)
        {
            Current = Head;
            //While loop 
            //traverse the linked list and do the comparison
            while (Current != null)
            {
                if (Current.Value == value)
                {
                    return true; 
                }

                // move to the next node
                Current = Current.Next;
            }

            return false;

        }

        /// <summary>
        /// Overriding current behavior of ToString method to output all values in the linked list as a string
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;

            //StringBuilder class
            //Why would you use stringBuilder over concatination??
            //bc it's more efficient in terms of memory management 

            StringBuilder sb = new StringBuilder();

            // start constructing sb
            while(Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}
