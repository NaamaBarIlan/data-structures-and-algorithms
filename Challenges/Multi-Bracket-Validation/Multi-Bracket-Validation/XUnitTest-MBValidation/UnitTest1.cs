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
            MultiBracketValidation Multi_Bracket_Validation = new MultiBracketValidation;
            string testString = "()[[Extra Characters]]";

            // Act
            bool isValid = MBracketValidation(testString);

            testMethod();

            // Assert

        }
    }
}