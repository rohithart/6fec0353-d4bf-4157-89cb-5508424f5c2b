using StringApp.Interfaces;

namespace StringApp.Services
{
    public class LisService : ILisService
    {
        public List<int> FindLongestIncreasingSubsequence(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return new List<int>();
            }

            int n = numbers.Count;
            int maxLen = 1;
            int maxStart = 0;

            int curLen = 1;
            int curStart = 0;

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    curLen++;
                }
                else
                {
                    curLen = 1;
                    curStart = i;
                }

                if (curLen > maxLen)
                {
                    maxLen = curLen;
                    maxStart = curStart;
                }
            }

            var result = new List<int>();
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                result.Add(numbers[i]);
            }

            return result;
        }
    }
}
