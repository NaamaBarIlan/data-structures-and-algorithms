using System;
using System.Collections;
using Xunit;
using static RepeatedWord.Program;


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
            string result = FindRepeatedWord(testInput);

            // Assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void CanReturnARepeatedWordMixedCases()
        {
            // Arrange

            string testInput = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            // Act
            string result = FindRepeatedWord(testInput);

            // Assert
            Assert.Equal("it", result);
        }

        [Fact]
        public void CanReturnNullWhenNoWordIsRepeated()
        {
            // Arrange

            string testInput = "Nothing to see here!";

            // Act
            string result = FindRepeatedWord(testInput);

            // Assert
            Assert.Null(result);
        }

    }
}
