
using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().ToCharArray();
            var dict = new SortedDictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (!dict.ContainsKey(line[i]))
                {
                    dict.Add(line[i], 0);
                }
                dict[line[i]] += 1;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
