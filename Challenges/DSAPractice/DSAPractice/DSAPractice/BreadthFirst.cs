using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPractice
{
    public class BreadthFirst
    {
        public static int CountTreeNodesBreath(Tree<string> tree)
        {
            int counter = 0;

            Queue<Node<String>> que = new Queue<Node<String>>();

            que.Enqueue(tree.Root);

            while (que.Count != 0)
            {
                Node<String> front = que.Dequeue();

                counter++;

                if (front.LeftChild != null)
                {
                    que.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    que.Enqueue(front.RightChild);
                }
            }

            return counter;
        }
    }
}
