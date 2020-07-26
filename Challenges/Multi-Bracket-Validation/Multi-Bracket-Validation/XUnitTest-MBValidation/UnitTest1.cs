using System;
using Xunit;
using Multi_Bracket_Validation;

namespace XUnitTest_MBValidation
{
    public class UnitTest1
    {
        
        [Fact]
        public void CanValidateMultipleBracketsHappyPath()
        {
            // Arrange
            string testString = "()[[Extra Characters]]";

            // Act
            bool isValid = MultiBracketValidation(testString);

            testMethod();

            // Assert

        }
    }
}