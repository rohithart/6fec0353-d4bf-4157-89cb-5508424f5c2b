using StringApp.Helpers;

namespace StringApp.Tests.Helpers
{
    public class ConsoleOutputWriterTests
    {
        [Fact]
        public void Write_ShouldWriteMessageToConsole()
        {
            // Arrange
            var writer = new ConsoleOutputWriter();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            List<int> expectedNumbers = new List<int> { 1, 2, 3 };

            // Act
            writer.Write(expectedNumbers);

            // Assert
            string actualOutput = stringWriter.ToString().Trim();

            string expectedOutput = string.Join(" ", expectedNumbers);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Write_ShouldHandleEmptySequence()
        {
            // Arrange
            var writer = new ConsoleOutputWriter();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var emptySequence = new List<int>();

            // Act
            writer.Write(emptySequence);

            // Assert
            string actualOutput = stringWriter.ToString().Trim();
            Assert.Equal(string.Empty, actualOutput);
        }
    }
}
