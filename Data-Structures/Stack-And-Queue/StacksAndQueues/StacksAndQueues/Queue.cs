using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }

        public Node Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        public void Enqueue(string value)
        {
            // Create a new Node
            Node node = new Node(value);

            if(Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }

        }

        public string Dequeue()
        {
            //check isEmpty
            if(IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            // create a temp node
            Node temp = Front;

            Front = Front.Next;

            temp.Next = null;

            return temp.Value;

        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            return Front.Value;
        }
    }
}
