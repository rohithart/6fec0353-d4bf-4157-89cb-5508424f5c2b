using StringApp.Core;
using StringApp.Helpers;
using StringApp.Interfaces;
using StringApp.Services;

namespace StringApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Manual DI setup
            IInputParser parser = new WhitespaceInputParser();
            ILisService lisService = new LisService();
            IOutputWriter outputWriter = new ConsoleOutputWriter();

            var lis = new LongestIncreasingSubsequence(parser, lisService, outputWriter);

            Console.WriteLine("Enter a sequence of integers (space-separated):");
            string input = Console.ReadLine();

            lis.Run(input);
        }
    }
}
