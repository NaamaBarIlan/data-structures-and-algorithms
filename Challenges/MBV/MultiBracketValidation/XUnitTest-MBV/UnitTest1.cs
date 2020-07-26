using System;
using Xunit;
using System.Collections.Generic;
using MultiBracketValidation;


namespace XUnitTest_MBV
{
    public class UnitTest1
    {
        [Fact]
        public void CanValidateMultipleBracketsHappyPath()
        {
            // Arrange
            string testString = "()[[Extra Characters]]";

            // Act
            bool isValid = MBracketValidation(testString);

            // Assert
            Assert.True(isValid);
        }
    }
}
