using System;
using System.Collections;
using System.Xml;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        Stack enqueueStack = new Stack();
        Stack dequeueStack = new Stack();

        public void Enqueue(Node value)
        {
            enqueueStack.Push(value);
        }

        public Node Dequeueu()
        {
            // pop the top stack value and push to the 
            // dequeue stack
            while(enqueueStack.Peek() != null)
            {
                Node extracted = enqueueStack.Pop();
                dequeueStack.Push(extracted);
            }

            // pop the top value of dequeue stack
            // save the value
            Node dequeueTop = dequeueStack.Pop();
            
            // flip the stack back to enqueue stack
            while (dequeueStack.Peek() != null)
            {
                Node extracted = dequeueStack.Pop();
                enqueueStack.Push(extracted);
            }

            return dequeueTop;
        }
    }
}
