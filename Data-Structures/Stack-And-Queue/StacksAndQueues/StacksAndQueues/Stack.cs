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

        public string Pop(string value)
        {
            // check isEmpty
            if()
            {
                return null;
            }
            // create a temp node
            Node node = new Node(value);
            Node temp = new Node(value);
            temp = Top;
            Top = Top.Next;
            Top.Next = null;
            return temp.value;

        }
    }
}
