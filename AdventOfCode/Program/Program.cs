using AdventOfCode._2023.Done;
using AdventOfCode._2022.Done;
using AdventOfCode.Common.Services;
using AdventOfCode.Common.Interfaces;

namespace AdventOfCode.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInputFileService inputFileService = new InputFileService();

            Console.WriteLine($"# Advent of Code 2022 - by Fady Hatta {Environment.NewLine}");
            Console.WriteLine($"## Answers {Environment.NewLine}");

            var day1 = new Day1(inputFileService);

            Console.WriteLine($"Day 1 1/2: {day1.GetMostCalories()}");
            Console.WriteLine($"Day 1 2/2: {day1.GetTop3MostCaloriesTotal()}");

        }
    }
}