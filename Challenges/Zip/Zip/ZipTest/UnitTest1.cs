using System;
using Xunit;
using static Zip.Program;
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
            Node zippedListHead = ZipLists(list1, list2);

            LinkedList result = new LinkedList();

            result.Head = zippedListHead;

            string expected = "2 -> 4 -> 3 -> 9 -> 1 -> 5 -> NULL";

            // Assert
            Assert.Equal(expected, result.ToString());

        }

    }
}
