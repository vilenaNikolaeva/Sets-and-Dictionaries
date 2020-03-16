using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            var command = string.Empty;

            while (command != "Statistics")
            {
                command = Console.ReadLine();
                if (command == "Statistics")
                {
                    break;
                }
                var vloger = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = vloger[0];
                var currentCommand = vloger[1];

                if (currentCommand == "joined")
                {
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers.Add(name, new Dictionary<string, HashSet<string>>());
                        vloggers[name].Add("followers", new HashSet<string>());
                        vloggers[name].Add("following", new HashSet<string>());
                    }

                }
                else if (currentCommand == "followed")
                {
                    var follower = vloger[2];
                    if (follower != name && vloggers.ContainsKey(name)
                        && vloggers.ContainsKey(follower))
                    {
                        vloggers[name]["following"].Add(follower);
                        vloggers[follower]["followers"].Add(name);
                    }
                }
            }
            var count = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            foreach (var name in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {name.Key} : {name.Value["followers"].Count} followers, {name.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in name.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
