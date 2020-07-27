using System;
using Xunit;
using System.Collections.Generic;
using static MultiBracketValidation.MultiBracketValidation;


namespace XUnitTest_MBV
{
    public class UnitTest1
    {
        [Fact]
        public void CanValidateMultipleBracketsHappyPath()
        {
            // Arrange
            string testString = "{}(){}";

            // Act
            bool isValid = MBracketValidation(testString);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void CanValidateMultipleBracketsAndChars()
        {
            // Arrange
            string testString = "()[[Extra Characters]]";

            // Act
            bool isValid = MBracketValidation(testString);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void CanReturnFalseForUnbalancedBrackets()
        {
            // Arrange
            string testString = "[({}]";

            // Act
            bool isValid = MBracketValidation(testString);

            // Assert
            Assert.False(isValid);
        }
    }
}
