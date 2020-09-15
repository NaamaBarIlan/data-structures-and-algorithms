using System;
using Xunit;
using System.Collections.Generic;
using static GenericLL.LinkedList;


namespace XUnitTest_GenericLL
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstanctiateEmptyLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            Assert.Null(list.Head);
        }
    }
}
