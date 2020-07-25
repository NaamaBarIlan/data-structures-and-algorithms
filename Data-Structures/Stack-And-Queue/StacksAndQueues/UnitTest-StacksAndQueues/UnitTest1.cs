using System;
using System.Text;
using Xunit;
using StacksAndQueues;

namespace UnitTest_StacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOnStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");

            // Assert
            Assert.Equal("Candy cane", stack.Top.Value);
            //Assert.NotNull(stack.Top.Value);
        }

        [Fact]
        public void CanPushMultipleValuesOnStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");
            stack.Push("Banana");
            stack.Push("Potato");

            // Assert
            Assert.Equal("Potato", stack.Top.Value);
        }

        [Fact]
        public void CanPopOffTheStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");
            stack.Push("Banana");
            stack.Push("Potato");

            stack.Pop();

            // Assert
            Assert.Equal("Banana", stack.Top.Value);
        }

        [Fact]
        public void CanThrowAnEmptyException()
        {
            // Arrange
            Stack stack = new Stack();

            // Act - Important! How to test an exception. 
            Exception emptyException = Assert.Throws<Exception>(() => stack.Pop());
            string expected = "Stack is empty";

            // Assert
            Assert.Equal(expected, emptyException.Message);
        }

        [Fact]
        public void CanEmptyAStackAfterMultiplePops()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");
            stack.Push("Banana");
            stack.Push("Potato");
            stack.Pop();
            stack.Pop();
            stack.Pop();

            bool expected = stack.IsEmpty();

            // Assert
            Assert.True(expected);
        }

        [Fact]
        public void CanPeekTheNextItemOnTheStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");
            stack.Push("Banana");
            stack.Push("Potato");

            string expected = stack.Peek();

            // Assert
            Assert.Equal("Potato", expected);
        }

        [Fact]
        public void CanInstantiateAnEmptyStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            bool expected = stack.IsEmpty();

            // Assert
            Assert.True(expected);
        }
    }
}
