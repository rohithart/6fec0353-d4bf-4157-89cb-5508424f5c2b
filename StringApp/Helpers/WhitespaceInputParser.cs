using StringApp.Interfaces;

namespace StringApp.Helpers
{
    public class WhitespaceInputParser : IInputParser
    {
        public List<int> Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new List<int>();
            }

            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
        }
    }
}
