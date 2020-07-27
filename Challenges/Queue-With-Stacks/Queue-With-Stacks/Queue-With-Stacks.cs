using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks
{
    public class PseudoQueue
    {
        Stack enqueueStack = new Stack();
        Stack dequeueStack = new Stack();
        Node extracted = new Node("");
        Node dequeueTop = new Node("");

        /// <summary>
        /// This method takes a value and inserts it into the enqueueStack, 
        /// which acts as a pseudo queueu
        /// </summary>
        /// <param name="value">A unique string value to insert into the stack</param>
        public Node Enqueue(string value)
        {
            enqueueStack.Push(value);

            return enqueueStack.Top;
        }

        /// <summary>
        /// Extracts a value from the PseudoQueue using a FIFO approach:
        /// Pops the top value off of the enqueueStack, 
        /// and pushes it into the dequeuStack until the enqueueStack is empty
        /// and the dequeueStack has all of the values in reverse order.
        /// Pops the top value of the dequeue stack and saves it in a string variable.
        /// Pop the rest of the values in the dequeueStack and push them back into enqueue stack
        /// </summary>
        /// <returns></returns>
        public Node Dequeueu()
        {
            // pop the top stack value and push to the 
            // dequeue stack
            while (enqueueStack.Peek() != null)
            {
                extracted.Value = enqueueStack.Pop();
                dequeueStack.Push(extracted.Value);
            }

            // pop the top value of dequeue stack
            // save the value
            dequeueTop.Value = dequeueStack.Pop();

            // flip the stack back to enqueue stack
            while (dequeueStack.Peek() != null)
            {
                extracted.Value = dequeueStack.Pop();
                enqueueStack.Push(extracted.Value);
            }

            return dequeueTop;
        }
    }
}
