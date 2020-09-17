using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using LinkedListTests;

namespace LinkedListLibrary
{
    class LLTraversals
    {

        // Find A Value : Iterative

        /// <summary>
        /// Takes a value and a linked list as parameters, 
        /// traverses the list and compares each node to the value.
        /// If a node's value equals the value, returns the node, else returns null.
        /// </summary>
        /// <param name="linkedList">The linked list to traverse</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node FindAValueInLL(LinkedList linkedList, int inputValue)
        {
            Node current = linkedList.Head;

            while(current != null)
            {
                if (current.Value == inputValue)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Find A Value: Recursive

        public Node FindAValueInLLRecursive(LinkedList linkedList, int inputValue)
        {
            Node current = linkedList.Head;
            return FindAValue(current, inputValue);
            
        }

        private Node FindAValue(Node current, int value)
        {
         
            if (current.Next != null)
            {
                FindAValue(current.Next, value);
            }

            if (current.Value == value)
            {
                return current;
            }
            else
            {
                current = current.Next;
            }

            return FindAValue(current, value);

        }

        public static Node TraverseLL(LinkedList list, int inputValue)
        {
            Node result = TraverseLL(list.Head, inputValue);
            return result;
        }

        private static Node TraverseLL(Node current, int inputValue)
        {
            if (current.Value == inputValue)
            {
                return current;
            }

            current = current.Next;

            if (current.Next != null)
            {
                return TraverseLL(current.Next, inputValue);
            }

            //if (current == null)
            //{
            //    return null;
            //}

            return null;
        }
    }
}
