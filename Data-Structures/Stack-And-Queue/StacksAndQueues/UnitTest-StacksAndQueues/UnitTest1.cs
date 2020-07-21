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

            stack.Pop("Potato");

            // Assert
            Assert.Equal("Banana", stack.Top.Value);
        }
    }
}
