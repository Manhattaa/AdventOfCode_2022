using AdventOfCode.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Common.Services
{
    public class InputFileService : IInputFileService
    {
        private const string BasePath = "2022/Inputs";

        public IEnumerable<string> GetInputs(string name, string? lineSplitter = null)
        {
            lineSplitter ??= Environment.NewLine;

            return GetInput(name)
                .Split(lineSplitter)
                .Where(i => !string.IsNullOrWhiteSpace(i));
        }

        private string GetInput(string name)
        {
            return File.ReadAllText($"{BasePath}/{name}");
        }
    }
}
