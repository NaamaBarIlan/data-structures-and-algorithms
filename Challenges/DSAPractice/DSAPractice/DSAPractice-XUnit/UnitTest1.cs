using DSAPractice;
using System;
using Xunit;


namespace DSAPractice_XUnit
{
    public class UnitTest1
    {
        [Fact]

        public void CountTreeNodesDepth()
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
            int result = DepthFirst.CountTreeNodesDepth(tree.Root);

            // Assert
            Assert.Equal(7, result);
        }
    }
}
