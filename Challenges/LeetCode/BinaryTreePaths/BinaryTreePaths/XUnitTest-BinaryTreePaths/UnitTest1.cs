using System;
using Xunit;
using System.Collections.Generic;
using Trees;
using static BinaryTreePaths.Program;

namespace XUnitTest_BinaryTreePaths
{
    public class UnitTest1
    {
        //[Fact]
        //public void CanReturnAllBinaryTreePaths()
        //{

        //}

        [Fact]
        public void CanReturnNullFromEmptyTree()
        {
            // Arrange

            Tree<char> tree = new Tree<char>();

            // Act 

            List<string> result = AllBinaryTreePaths(tree);
            List<string> empty = new List<string>();

            // Assert
            Assert.Equal(result, empty);
        }
    }
}
