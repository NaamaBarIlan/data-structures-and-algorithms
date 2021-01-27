using LinkedListTests;
using System.Collections.Generic;
using System;
using Xunit;

namespace XUnitTest_Traversals
{
    public class UnitTest1
    {
        [Fact]
        public void CanCountLLNodes()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            //Act
            CountLLNodes(list);


            //Assert
        }
    }
}
