using DSAPractice;
using System;
using Xunit;


namespace DSAPractice_XUnit
{
    public class UnitTest1
    {
        [Fact]

        public void CanCountTreeNodesDepth()
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
            int result = DepthFirst.CountTreeNodesDepth(tree);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]

        public void CanCountTreeNodesBreadth()
        {
            // Arrange
            Tree<string> tree = new Tree<string>();

            Node<string> root = new Node<string>("a");
            Node<string> b = new Node<string>("b");
            Node<string> c = new Node<string>("c");
            Node<string> d = new Node<string>("d");
            Node<string> e = new Node<string>("e");
            Node<string> f = new Node<string>("f");
            Node<string> g = new Node<string>("g");

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act
            int result = BreadthFirst.CountTreeNodesBreath(tree);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void CanCountTreeLeavesDepth()
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
            int result = DepthFirst.CountTreeLeavesDepth(root);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]

        public void CanCountTreeLeavesBreadth()
        {
            // Arrange
            Tree<string> tree = new Tree<string>();

            Node<string> root = new Node<string>("a");
            Node<string> b = new Node<string>("b");
            Node<string> c = new Node<string>("c");
            Node<string> d = new Node<string>("d");
            Node<string> e = new Node<string>("e");
            Node<string> f = new Node<string>("f");
            Node<string> g = new Node<string>("g");

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act
            int result = BreadthFirst.CountTreeLeavesBreadth(root);

            // Assert
            Assert.Equal(4, result);
        }


        [Fact]

        public void CanCountRightBranchesBreadth()
        {
            // Arrange
            Tree<string> tree = new Tree<string>();

            Node<string> root = new Node<string>("a");
            Node<string> b = new Node<string>("b");
            Node<string> c = new Node<string>("c");
            Node<string> d = new Node<string>("d");
            Node<string> e = new Node<string>("e");
            Node<string> f = new Node<string>("f");
            Node<string> g = new Node<string>("g");

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act
            int result = BreadthFirst.CountRightBranchesBreadth(root);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void CanGetTreeHeight()
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
            int result = DepthFirst.GetTreeHeight(root);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void CanCountNodesDepth()
        {
            // Arrange
            Tree<string> tree = new Tree<string>();

            Node<string> root = new Node<string>("a");
            Node<string> b = new Node<string>("b");
            Node<string> c = new Node<string>("c");
            Node<string> d = new Node<string>("d");
            Node<string> e = new Node<string>("e");
            Node<string> f = new Node<string>("f");
            Node<string> g = new Node<string>("g");
            Node<string> h = new Node<string>("h");
            Node<string> i = new Node<string>("i");

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            d.LeftChild = h;
            d.RightChild = i;

            // Act
            int result = BreadthFirst.NodeDepths(root);

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void CanGetSmallestBranch()
        {
            // Arrange
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(10);
            Node<int> b = new Node<int>(15);
            Node<int> c = new Node<int>(20);
            Node<int> d = new Node<int>(25);
            Node<int> e = new Node<int>(30);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            // Act
            int result = DepthFirst.SmallestBranch(root);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void CanFindIfTreeIsContainedInAnotherTree()
        {
            // Arrange

            Tree<int> tree1 = new Tree<int>();

            Node<int> root1 = new Node<int>(15);
            Node<int> h = new Node<int>(25);
            Node<int> i = new Node<int>(30);

            tree1.Root = root1;

            root1.LeftChild = h;
            root1.RightChild = i;

            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(10);
            Node<int> b = new Node<int>(15);
            Node<int> c = new Node<int>(20);
            Node<int> d = new Node<int>(25);
            Node<int> e = new Node<int>(30);
            Node<int> f = new Node<int>(35);
            Node<int> g = new Node<int>(40);

            tree2.Root = root2;

            root2.LeftChild = b;
            root2.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act
            bool result = DepthFirst.IsTree1ContainedInTree2(root1, root2);

            // Assert
            Assert.True(result);
        }
    }
}
