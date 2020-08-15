using Hashtable;
using System;
using Xunit;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddItemToHashTable()
        {
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            Assert.NotNull(table);
        }

        [Fact]
        public void CanGetValueFromHashTable()
        {
            // arrange
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var result = table.Get("Dog");

            Assert.Equal(10, result);
        }

        [Fact]
        public void FindsContainedValue()
        {
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var contains = table.Contains("Cupcake");

            Assert.True(contains);
        }

        [Fact]
        public void CanReturnNullIfKeyDoesntExist()
        {
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var contains = table.Contains("Mango");

            Assert.False(contains);
        }

        [Fact]
        public void CanHandleACollision()
        {
            // Arrange
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            table.Add("Josie", 5);

            //  Act
            var result = table.Get("Josie");

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void CanRetrieveFromABucketWithACollision()
        {
            // Arrange
            HashTbl<int> table = new HashTbl<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Josie", 5);

            //  Act
            var result = table.Get("Josie");

            // Assert
            Assert.Equal(9, result);
        }
    }
}
