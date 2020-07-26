using System;
using Queue_With_Stacks;
using Xunit;

namespace XUnitTest_Queue_With_Stacks
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueToPseudoQueue()
        {
            // Arrange - create a stack
            Stack testStack = new Stack();

            // Act - enqueue
            testStack.Enqueue("Banana");

            string expected = testStack.Peek();

            // Assert
            Assert.Equal("Banana", expected);
        }
    }
}
