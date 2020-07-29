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
            PseudoQueue testPseudoQueue = new PseudoQueue();

            // Act - enqueue
            Node top = testPseudoQueue.Enqueue("Banana");

            //string expected = top.Value;

            // Assert
            Assert.Equal("Banana", top.Value);
        }

        [Fact]
        public void CanDequeueFromPseudoQueue()
        {
            // Arrange - create a stack
            PseudoQueue testPseudoQueue = new PseudoQueue();

            testPseudoQueue.Enqueue("Banana");
            testPseudoQueue.Enqueue("Potato");
            testPseudoQueue.Enqueue("Mango");
            testPseudoQueue.Enqueue("Lemon");

            // Act - enqueue

            //Node front = testPseudoQueue.Dequeueu();

            //string expected = top.Value;

            // Assert
            Assert.Equal("Lemon", front.Value);
        }
    }
}
