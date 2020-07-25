using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;
using Xunit;

namespace UnitTest_StacksAndQueues
{
    public class QueueTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("Josie Cat");
            que.Enqueue("Belle Kitty");

            // Assert
            Assert.Equal("Josie Cat", que.Front.Value);
        }

        [Fact]
        public void CanDequeueExpectedValue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("Banana");
            que.Enqueue("Potato");
            que.Enqueue("Mango");
            que.Enqueue("Lemon");

            que.Dequeue();

            // Assert
            Assert.Equal("Potato", que.Front.Value);
        }

        [Fact]
        public void CanPeekIntoAQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("Banana");
            que.Enqueue("Potato");
            que.Enqueue("Mango");
            que.Enqueue("Lemon");

            string expected = que.Peek();

            // Assert
            Assert.Equal("Banana", expected);
        }

        [Fact]
        public void CanEmptyAQueueAfterMultipleDequeues()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("Banana");
            que.Enqueue("Potato");
            que.Enqueue("Mango");

            que.Dequeue();
            que.Dequeue();
            que.Dequeue();

            // Assert
            Assert.True(que.IsEmpty());
        }
    }
}
