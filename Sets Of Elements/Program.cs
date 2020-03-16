using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();
            HashSet<int> colectionOne = new HashSet<int>();
            HashSet<int> secondColection = new HashSet<int>();

            for (int i = 0; i < line[0]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                colectionOne.Add(number);
            }

            for (int i = 0; i < line[1]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                secondColection.Add(number);
            }
            Console.WriteLine(string.Join(" ", colectionOne.Intersect(secondColection))); ;
        }
    }
}
