using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            SortedSet<string> compounds = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(" ");
                foreach (var item in input)
                {
                    compounds.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", compounds));
        }
    }
}
