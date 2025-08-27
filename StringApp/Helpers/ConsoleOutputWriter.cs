// Copyright (c) StringApp. All rights reserved.

using StringApp.Interfaces;

namespace StringApp.Helpers
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(List<int> sequence)
        {
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
