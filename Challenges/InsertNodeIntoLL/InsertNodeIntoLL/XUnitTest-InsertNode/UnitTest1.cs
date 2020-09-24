using System;
using Xunit;
using LinkedListLibrary;
using LinkedListTests;

namespace XUnitTest_InsertNode
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertANodeIntoLL()
        {
            // Arrange

            LinkedList list = new LinkedList();

            list.Append(10);
            list.Append(20);
            list.Append(30);
            list.Append(40);

            // Act

            InsertANodeIntoLL(list.head, 25, int 2);

            // Assert
        }
    }
}
