using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;
using Xunit;

namespace UnitTest_StacksAndQueues
{
    public class QueueTests
    {

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
    }
}
