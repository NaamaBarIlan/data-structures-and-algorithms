using System;

namespace DSAPractice
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {
           
        }

        public Tree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

    }
}