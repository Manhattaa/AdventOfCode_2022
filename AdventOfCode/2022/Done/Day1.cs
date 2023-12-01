using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022.Done
{
    public class Day1 : BaseDay
    {
        public Day1(IInputFileService inputFileService) : base("Day1", inputFileService)
        {
        }

        public int GetMostCalories()
        {
            var elfCaloricTotals = GetElfCaloricTotals();

            return elfCaloricTotals.Max();
        }

        public IEnumerable<int> GetTop3MostCalories()
        {
            var elfCaloricTotals = GetElfCaloricTotals();

            var orderedElfCaloricTotals = elfCaloricTotals.OrderByDescending(t => t).ToList();

            return orderedElfCaloricTotals.Take(3);
        }

        public int GetTop3MostCaloriesTotal()
        {
            return GetTop3MostCalories().Sum();
        }

        private IEnumerable<int> GetElfCaloricTotals()
        {
            var inputsPerElf = GetInputs($"{LineSplitter}{LineSplitter}");

            return inputsPerElf.Select(GetTotalCalories);
        }

        private int GetTotalCalories(string input)
        {
            var calories = input
                .Split(LineSplitter)
                .Where(i => !string.IsNullOrWhiteSpace(i))
                .Select(int.Parse);

            return calories.Sum();
        }
    }
}