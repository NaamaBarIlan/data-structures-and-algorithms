using System;
using Xunit;
using static array_shift.Program;

namespace array_shift_unit_test
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertAndShiftArray()
        {
            // Arrange
            int[] testInput = { 2, 4, 6, 8 };
            int testValue = 5;
            int[] expectedArray = { 2, 4, 5, 6, 8 };

            // Act
            int[] testOutputArray = InsertShiftArray(testInput, testValue);

            // Assert
            Assert.Equal(expectedArray, testOutputArray);
        }

        [Fact]
        public void CanInsertValueToEmptyArray()
        {
            // Arrange
            int[] testInput = {};
            int testValue = 1;
            int[] expectedArray = { 1 };

            // Act
            int[] testOutputArray = InsertShiftArray(testInput, testValue);

            // Assert
            Assert.Equal(expectedArray, testOutputArray);
        }

    }
}
