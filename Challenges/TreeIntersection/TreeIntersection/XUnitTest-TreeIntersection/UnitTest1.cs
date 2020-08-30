using System;
using Xunit;
using TreeIntersection;
using static TreeIntersection.ATreeIntersection;
using System.Collections.Generic;

namespace XUnitTest_TreeIntersection
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnValuesThatExistInBothTrees()
        {
            // Arrange
            Tree<int> treeOne = new Tree<int>();

            Node<int> root = new Node<int>(150);
            Node<int> b = new Node<int>(100);
            Node<int> c = new Node<int>(250);
            Node<int> d = new Node<int>(75);
            Node<int> e = new Node<int>(160);
            Node<int> f = new Node<int>(200);
            Node<int> g = new Node<int>(350);
            Node<int> h = new Node<int>(125);
            Node<int> i = new Node<int>(175);
            Node<int> j = new Node<int>(300);
            Node<int> k = new Node<int>(500);

            treeOne.Root = root;
            root.LeftChild = b;
            root.RightChild = c;
            b.LeftChild = d;
            b.RightChild = e;
            c.LeftChild = f;
            c.RightChild = g;
            e.LeftChild = h;
            e.RightChild = i;
            g.LeftChild = j;
            g.RightChild = k;

            Tree<int> treeTwo = new Tree<int>();

            Node<int> root2 = new Node<int>(42);
            Node<int> b2 = new Node<int>(100);
            Node<int> c2 = new Node<int>(600);
            Node<int> d2 = new Node<int>(15);
            Node<int> e2 = new Node<int>(160);
            Node<int> f2 = new Node<int>(200);
            Node<int> g2 = new Node<int>(350);
            Node<int> h2 = new Node<int>(125);
            Node<int> i2 = new Node<int>(175);
            Node<int> j2 = new Node<int>(4);
            Node<int> k2 = new Node<int>(500);

            treeTwo.Root = root2;
            root2.LeftChild = b2;
            root2.RightChild = c2;
            b2.LeftChild = d2;
            b2.RightChild = e2;
            c2.LeftChild = f2;
            c2.RightChild = g2;
            e2.LeftChild = h2;
            e2.RightChild = i2;
            g2.LeftChild = j2;
            g2.RightChild = k2;

            // Act
            List<int> result = TwoTreesIntersection(treeOne, treeTwo);
            List<int> output = new List<int> { 100, 160, 125, 175, 200, 350, 500 };

            // Assert
            Assert.Equal(result, output);

        }

        [Fact]
        public void CanReturnNullIfValuesDoNotRepeat()
        {
            // Arrange
            Tree<int> treeOne = new Tree<int>();

            Node<int> root = new Node<int>(150);
            Node<int> b = new Node<int>(100);
            Node<int> c = new Node<int>(250);
            Node<int> d = new Node<int>(75);
            Node<int> e = new Node<int>(160);
            Node<int> f = new Node<int>(200);
            Node<int> g = new Node<int>(350);
            

            treeOne.Root = root;
            root.LeftChild = b;
            root.RightChild = c;
            b.LeftChild = d;
            b.RightChild = e;
            c.LeftChild = f;
            c.RightChild = g;
          

            Tree<int> treeTwo = new Tree<int>();

            Node<int> root2 = new Node<int>(5);
            Node<int> b2 = new Node<int>(6);
            Node<int> c2 = new Node<int>(7);
            Node<int> d2 = new Node<int>(8);
            Node<int> e2 = new Node<int>(9);
            Node<int> f2 = new Node<int>(10);
            Node<int> g2 = new Node<int>(11);

            treeTwo.Root = root2;
            root2.LeftChild = b2;
            root2.RightChild = c2;
            b2.LeftChild = d2;
            b2.RightChild = e2;
            c2.LeftChild = f2;
            c2.RightChild = g2;


            // Act
            List<int> result = TwoTreesIntersection(treeOne, treeTwo);
            List<int> output = new List<int> {};

            // Assert
            Assert.Equal(result, output);
        }

    }
}
