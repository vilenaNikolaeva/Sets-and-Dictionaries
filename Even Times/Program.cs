using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<int> collection = new List<int>();
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (collection.Contains(number))
                {
                    set.Add(number);
                }
                collection.Add(number);
            }
            Console.WriteLine(string.Join("", set));
        }
    }
}
