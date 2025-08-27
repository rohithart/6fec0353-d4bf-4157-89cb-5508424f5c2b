using StringApp.Helpers;
using StringApp.Interfaces;

namespace StringApp.Tests.Helpers
{
    public class WhitespaceInputParserTests
    {
        private readonly IInputParser parser;

        public WhitespaceInputParserTests()
        {
            this.parser = new WhitespaceInputParser();
        }

        [Fact]
        public void Parse_ShouldReturnEmptyList_WhenInputIsNull()
        {
            // Act
            var result = this.parser.Parse(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Parse_ShouldReturnEmptyList_WhenInputIsEmptyString()
        {
            // Act
            var result = this.parser.Parse(string.Empty);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Parse_ShouldReturnSingleInteger_WhenInputHasOneNumber()
        {
            // Act
            var result = this.parser.Parse("42");

            // Assert
            Assert.Single(result);
            Assert.Equal(42, result[0]);
        }

        [Fact]
        public void Parse_ShouldReturnMultipleIntegers_WhenInputHasNumbersSeparatedBySpaces()
        {
            // Act
            var result = this.parser.Parse("1 2 3 4 5");

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void Parse_ShouldIgnoreExtraSpaces_WhenInputHasMultipleSpacesBetweenNumbers()
        {
            // Act
            var result = this.parser.Parse("10   20    30");

            // Assert
            Assert.Equal(new List<int> { 10, 20, 30 }, result);
        }

        [Fact]
        public void Parse_ShouldReturn_WhenInputContainsNegativeValue()
        {
            // Act
            var result = this.parser.Parse("-10 20 30");

            // Assert
            Assert.Equal(new List<int> { -10, 20, 30 }, result);
        }

        [Fact]
        public void Parse_ShouldThrowFormatException_WhenInputContainsNonNumericValue()
        {
            // Act & Assert
            Assert.Throws<FormatException>(() => this.parser.Parse("1 a 3"));
        }

        [Fact]
        public void Parse_ShouldThrowFormatException_WhenInputContainsDecimalValue()
        {
            // Act & Assert
            Assert.Throws<FormatException>(() => this.parser.Parse("1.5 3"));
        }
    }
}
