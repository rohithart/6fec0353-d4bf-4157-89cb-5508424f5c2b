using StringApp.Services;

namespace StringApp.Tests
{
    public class LisServiceTests
    {
        private readonly LisService lisService = new LisService();

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 7 }, new int[] { 7 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 9, 7, 5, 3, 1 }, new int[] { 9 })]
        [InlineData(new int[] { 6, 1, 5, 9, 2 }, new int[] { 1, 5, 9 })]
        [InlineData(new int[] { 6, 2, 4, 6, 1, 5, 9, 2 }, new int[] { 2, 4, 6 })]
        [InlineData(new int[] { 6, 2, 4, 3, 1, 5, 9 }, new int[] { 1, 5, 9 })]
        public void FindLongestIncreasingSubsequence_ShouldReturnExpected(int[] input, int[] expected)
        {
            // Act
            var result = this.lisService.FindLongestIncreasingSubsequence(new List<int>(input));

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
