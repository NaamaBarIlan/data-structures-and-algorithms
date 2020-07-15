using System;
using Xunit;
using LinkedListLibrary;
using System.Collections.Generic;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstanctiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            //insert means add to the front

            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);
        }

        [Fact]
        public void CanFindValueInList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            int searchForValue = 15;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void CannotFindValueInList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";
            // Assert

            Assert.Equal(expected, value);

        }

        [Fact]
        public void CanAppendToLinkedList()
        {
            //append means add to the end

            //Arrange
            LinkedList list = new LinkedList();

            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.AppendNumber(4);

            // Assert
            Assert.Equal(4, list.Current.Value);
        }

        [Fact]
        public void CanAddNodeToEndOfLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            // Act

            list.Append(23);

            // Assert
            string expected = "16 -> 15 -> 8 -> 4 -> 23 -> NULL";
            string answer = list.ToString();
            Assert.Equal(expected, answer);
        }

        [Fact]
        public void CanAddMultipleNodesToAnEnd()
        {
            // Arrange & Act
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(58);
            list.Append(10);
            list.Insert(12);
            list.Insert(254);
            list.Append(11);
            list.Append(88);

            string expected = "254 -> 12 -> 58 -> 4 -> 10 -> 11 -> 88 -> NULL";

            // Assert
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeMiddleOfLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(23);
            list.Insert(16);
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);


            // Act
            list.InsertBefore(15, 42);

            // Arrange
            string expected = "4 -> 8 -> 42 -> 15 -> 16 -> 23 -> NULL";
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeFirstNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            // Act
            list.InsertBefore(6, 7);
            string expected = "7 -> 6 -> 5 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanInsertNodeAfterANode()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            list.InsertAfter(15, 100);
            string expected = "16 -> 15 -> 100 -> 8 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanInsertNodeAfterLast()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            list.InsertAfter(4, 100);

            string expected = "16 -> 15 -> 8 -> 4 -> 100 -> NULL";

            // Assert
            Assert.Equal(expected, list.ToString());
        }


        [Fact]
        public void CanReturnKthFromEndHappyPath()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act
            int value = list.FindKthFromEnd(1);

            // Assert
            Assert.Equal(20, value);

        }

        [Fact]
        public void CanReturnExceptionForEqualLength()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act 
            // capture the exception inside of a delegate, and confirm the message is what was thrown. 
            var ex = Assert.Throws<Exception>(() => list.FindKthFromEnd(5));
            
            // Assert
            Assert.Equal("K is invalid", ex.Message);
        }

    }
}
