using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllText(@"../../../day2.txt").Split("\n");
            var part1 = 0;
            
            foreach (var line in lines)
            {
                var parts = line.Split(" ");
                if (parts[0] == "A" && parts[1] == "X")
                {
                    part1 += (3 + 1);
                }
                if (parts[0] == "B" && parts[1] == "Y")
                {
                    part1 += (3 + 2);
                }
                if (parts[0] == "C" && parts[1] == "Z")
                {
                    part1 += (3 + 3);
                }

                if (parts[0] == "A" && parts[1] == "Y")
                {
                    part1 += (6 + 2);
                }
                if (parts[0] == "B" && parts[1] == "Z")
                {
                    part1 += (6 + 3);
                }
                if (parts[0] == "C" && parts[1] == "X")
                {
                    part1 += (6 + 1);
                }

                if (parts[0] == "A" && parts[1] == "Z")
                {
                    part1 += (0 + 3);
                }
                if (parts[0] == "B" && parts[1] == "X")
                {
                    part1 += (0 + 1);
                }
                if (parts[0] == "C" && parts[1] == "Y")
                {
                    part1 += (0 + 2);
                }

                
            }

            Console.WriteLine($"Part 1: {part1}");
        }
    }
}