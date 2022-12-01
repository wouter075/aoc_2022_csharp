using System;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllText(@"../../../day1.txt").Split("\n\n");
            var calories = lines.Select(line => line.Split("\n").Select(int.Parse).ToList()).Select(l => l.Sum()).ToList().OrderByDescending(x => x);
            
            Console.WriteLine($"Part 1: {calories.Max()}");
            Console.WriteLine($"Part 2: {calories.Take(3).Sum()}");
        }
    }
}