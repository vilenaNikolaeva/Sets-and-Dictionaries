using System;
using System.Collections.Generic;

namespace Unique_Ussers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
