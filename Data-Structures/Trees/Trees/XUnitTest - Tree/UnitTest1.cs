using System;
using Xunit;
using Trees;
using System.Xml;
using System.Collections.Generic;

namespace XUnitTest___Tree
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            // Arrange & Act
            Tree<string> tree = new Tree<string>();

            // Assert
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRoot()
        {
            // Arrange & Act
            Tree<string> stump = new Tree<string>("Josie Cat");

            // Assert
            Assert.NotNull(stump.Root);
            Assert.Equal("Josie Cat", stump.Root.Value);
            Assert.IsType<Node<String>>(stump.Root);
        }

        [Fact]
        public void CanAddLeftAndRightToRoot()
        {
            Tree<char> tree = new Tree<char>('a');

            Node<char> lefttChild = new Node<char>('b');
            Node<char> rightChild = new Node<char>('c');

            tree.Root.LeftChild = lefttChild;
            tree.Root.RightChild = rightChild;

            Assert.NotNull(tree.Root.LeftChild);
            Assert.NotNull(tree.Root.RightChild);
            Assert.Equal('b', tree.Root.LeftChild.Value);
            Assert.Equal('c', tree.Root.RightChild.Value);
        }

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
