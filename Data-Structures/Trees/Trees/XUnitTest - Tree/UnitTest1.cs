using System;
using Xunit;
using Trees;
//using static Trees.IntTree;
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

        [Fact]
        public void CanReturnInOrderTraversal()
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
                'd', 'b', 'e', 'a', 'f', 'c', 'g'
            };

            // Act

            List<char> preOrder = tree.InOrder(tree.Root);

            // Assert
            Assert.Equal(order, preOrder);
        }

        [Fact]
        public void CanReturnPostnOrderTraversal()
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
                'd', 'e', 'b', 'f', 'g', 'c', 'a' 
            };

            // Act

            List<char> preOrder = tree.PostOrder(tree.Root);

            // Assert
            Assert.Equal(order, preOrder);
        }

        [Fact]
        public void CanFindMaximumValue()
        {
            // Arrange

            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(10);
            Node<int> b = new Node<int>(15);
            Node<int> c = new Node<int>(20);
            Node<int> d = new Node<int>(25);
            Node<int> e = new Node<int>(30);
            Node<int> f = new Node<int>(35);
            Node<int> g = new Node<int>(40);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act

            int result = tree.FindMaximumValue(tree);

            // Assert
            Assert.Equal(40, result);

        }
    }
}
