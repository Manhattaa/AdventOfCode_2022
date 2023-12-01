using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Common.Interfaces
{
    public interface IInputFileService
    {
        IEnumerable<string> GetInputs(string name, string? lineSplitter = null);
    }
}
