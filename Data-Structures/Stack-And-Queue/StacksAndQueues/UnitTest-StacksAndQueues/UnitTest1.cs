using System;
using System.Text;
using Xunit;
using StacksAndQueues;

namespace UnitTest_StacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("Candy cane");

            // Assert
            Assert.Equal("Candy cane", stack.Top.Value);
            //Assert.NotNull(stack.Top.Value);
        }
    }
}
