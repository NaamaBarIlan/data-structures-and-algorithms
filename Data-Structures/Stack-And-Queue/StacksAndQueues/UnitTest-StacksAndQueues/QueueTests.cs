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
        public void CanEnqueueMultipleValuesIntoQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act & Assert
            que.Enqueue("Potato");
            que.Enqueue("Banana");

            string Front1 = que.Rear.Value;

            que.Enqueue("Mango");

            string Front2 = que.Rear.Value;

            que.Enqueue("Lemon");

            Assert.Equal("Banana", Front1);
            Assert.Equal("Mango", Front2);
            Assert.Equal("Lemon", que.Rear.Value);

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

        [Fact]
        public void CanInstantiateAnEmptyQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            bool expected = que.IsEmpty();

            // Assert
            Assert.True(expected);
        }

        [Fact]
        public void CanThrowAnEmptyException()
        {
            // Arrange
            Queue que = new Queue();

            // Act - Important! How to test an exception. 
            Exception emptyException = Assert.Throws<Exception>(() => que.Dequeue());
            string expected = "Queue is empty";

            // Assert
            Assert.Equal(expected, emptyException.Message);
        }
    }
}
