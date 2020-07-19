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
        /// This method inserts a new node with an O(1) operation to the front of the linked list.
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
        /// This method finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value">search-able value</param>
        /// <returns>Returns true if value is included in the linked list, else returns false.</returns>
        public bool Includes(int value)
        {
            Current = Head;
             
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
        /// This method is overriding the current behavior of ToString method to output all values
        /// in the linked list as a string
        /// </summary>
        /// <returns>A string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;

            //StringBuilder class
            //Why would you use stringBuilder over concatenation?
            //Because it's more efficient in terms of memory management 

            StringBuilder sb = new StringBuilder();

            // start constructing sb:
            while(Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }

        /// <summary>
        /// This method adds a new node with the given value to the end of the list.
        /// </summary>
        /// <param name="value">The int value to be added to the list</param>
        /// <returns>The list with the appended value</returns>
        public void AppendNumber(int value)
        {
            Node node = new Node(value);
            Current = Head;
            
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                while(Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = node;
                Current = Current.Next;
            }

        }

        /// <summary>
        /// This method adds a new node with the given value to the end of the list.
        /// </summary>
        /// <param name="value">The int value to be added to the list</param>
        /// <returns>The list with the appended value</returns>
        public void Append(int value)
        {
            // Create a node

            Node node = new Node(value);
            Current = Head;
            // Add it to the end
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = node;
                //Current = Current.Next;
            }

        }

        /// <summary>
        /// This method takes two int paramaters and inserts one of them before the other in a linked list. 
        /// </summary>
        /// <param name="value">The int newValue will be inserted before this int value in the linked list</param>
        /// <param name="newValue">The int value to be inserted into the list before value.</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if(Current.Value == value)
            {
                Insert(newValue);
                Current = Current.Next;
            }
            
            // while loop
            while (Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    // create the new value
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Current.Next;

                }

                Current = Current.Next;
            }

        }

        /// <summary>
        /// This method takes two int paramaters and inserts one of them after the other in a linked list. 
        /// </summary>
        /// <param name="value">The int newValue will be inserted after this int value in the linked list</param>
        /// <param name="newValue">The int value to be inserted into the list after value.</param>
        public void InsertAfter(int value, int newValue)
        {
            while(Current != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;

                    Current = Current.Next;
                }

                Current = Current.Next;
            }
            
        }

        /// <summary>
        /// This method take an int value which is a position from the end of a linked list
        /// and finds the value of the node in that position.
        /// </summary>
        /// <param name="key">An int value that is a position from the end of a linked list</param>
        /// <returns>The int value of the node at the key position in the linked list</returns>
        public int FindKthFromEnd(int key)
        {
            // create 2 references
            Node walker = Head;
            Node runner = Head;

            // runner to iterate k number of position within the linked list
            int k = key;
            while (key > 0)
            {
                if (runner.Next != null)
                {
                    k--;
                    runner = runner.Next;
                }
                else
                {
                    throw new Exception("K is invalid");
                }
            }

            while (runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next;
            }

            return walker.Value;
        }

    }
}
