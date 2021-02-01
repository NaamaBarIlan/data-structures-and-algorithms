using System;
using Xunit;
using Traversals;
using System.Xml;
using System.Collections.Generic;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void CanReturnPreOrderTraversal()
        {
            // Arrange

            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<char> order = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f', 'g'
            };

            // Act

            List<char> preOrder = tree.PreOrder(tree.Root);

            // Assert
            Assert.Equal(order, preOrder);
        }
    }
}
