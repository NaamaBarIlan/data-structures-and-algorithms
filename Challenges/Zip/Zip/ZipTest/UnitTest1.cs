using System;
using Xunit;
using Zip;
using LinkedListLibrary;

namespace ZipTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanZipTwoLinkedListsIntoOne()
        {
            // Arrange
            LinkedList list1 = new LinkedList();

            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(2);

            LinkedList list2 = new LinkedList();

            list2.Insert(5);
            list2.Insert(9);
            list2.Insert(4);

            // Act
            LinkedList zippedList = ZipLists(list1, list2);

            LinkedList result = "1-> 5-> 3-> 9-> 2-> 4-> NULL";

            // Assert
            Assert.Equal(result, zippedList);

        }

    }
}
