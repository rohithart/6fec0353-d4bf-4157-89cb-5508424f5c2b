using StringApp.Interfaces;

namespace StringApp.Core
{
    public class LongestIncreasingSubsequence
    {
        private readonly IInputParser parser;
        private readonly ILisService lisService;
        private readonly IOutputWriter outputWriter;

        public LongestIncreasingSubsequence(IInputParser parser, ILisService lisService, IOutputWriter outputWriter)
        {
            this.parser = parser;
            this.lisService = lisService;
            this.outputWriter = outputWriter;
        }

        public void Run(string input)
        {
            var numbers = this.parser.Parse(input);
            var lis = this.lisService.FindLongestIncreasingSubsequence(numbers);
            this.outputWriter.Write(lis);
        }
    }
}
