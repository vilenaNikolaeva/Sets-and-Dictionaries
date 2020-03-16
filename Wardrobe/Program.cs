using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine().Split(" -> ").ToArray();
                var color = line[0];
                var clothes = line[1].Split(",");

                for (int j = 0; j < clothes.Length; j++)
                {
                    var currentClothes = clothes[j];
                    if (!colors.ContainsKey(color))
                    {
                        colors[color] = new Dictionary<string, int>();
                    }
                    if (!colors[color].ContainsKey(currentClothes))
                    {
                        colors[color].Add(currentClothes, 0);
                    }
                    colors[color][currentClothes]++;
                }
            }
            var lookingForClothing = Console.ReadLine().Split(" ");
            var lookingForcolor = lookingForClothing[0];
            var cloth = lookingForClothing[1];

            foreach (var color in colors)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == lookingForcolor && item.Key == cloth)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
