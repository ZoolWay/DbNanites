using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public interface IAnalyzeResult
    {
        bool Success { get; set; }
        IEnumerable<string> ErrorList { get; }
        IEnumerable<IMigrationTask> Migrations { get; }
    }
}
