using System;
using Xunit;


namespace UnitTest_RepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnARepeatedWord()
        {
            // Arrange

            string testInput = "Once upon a time, there was a brave princess who...";

            // Act
            FindRepeatedWord(testInput);

            // Assert

        }

    }
}
