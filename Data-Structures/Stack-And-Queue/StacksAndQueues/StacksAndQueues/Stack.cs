using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(string value)
        {
            // Create a new node
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public bool isEmpty()
        {
            return Top == null;
        }

        public string Pop()
        {
            //check isEmpty
            if (isEmpty())
            {
                throw new Exception("Stack is empty");
            }

            //create a temp node
            Node temp = Top;

            Top = Top.Next;

            temp.Next = null;
            return temp.Value;
        }

        public string Peek()
        {
            //check isEmpty
            if (isEmpty())
            {
                throw new Exception("Stack is empty");
            }

            return Top.Value;
        }
    }
}
