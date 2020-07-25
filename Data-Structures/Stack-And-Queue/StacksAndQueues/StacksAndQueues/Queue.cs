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

        /// <summary>
        /// This method takes any string value as an argument 
        /// and adds a new node with that value to the back of the queue.
        /// </summary>
        /// <param name="value">The unique string value that is being added</param>
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

        /// <summary>
        /// This method removes the node from the front of the queue
        /// and returns the node's value. 
        /// It raises an exception when called on an empty queue
        /// </summary>
        /// <returns>The unique value of the node that is being removed</returns>
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

        /// <summary>
        /// This method returns a boolean indicating whether or not the queue is empty.
        /// </summary>
        /// <returns>A boolean indicating if the queue is empty</returns>
        public bool IsEmpty()
        {
            return Front == null;
        }

        /// <summary>
        /// This method returns the value of the node located in the front of the queue, 
        /// without removing it from the queue
        /// </summary>
        /// <returns>The unique value of the node at the front of the queue</returns>
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
