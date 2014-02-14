using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    /// <summary>
    /// The public information about the result of a model parser.
    /// </summary>
    public interface IModelParseResult
    {
        /// <summary>
        /// True if parsing was successful.
        /// </summary>
        bool Success { get; }
        IEnumerable<string> ErrorList { get; }
        IEnumerable<string> TableNames { get; }
    }
}
