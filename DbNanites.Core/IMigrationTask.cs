using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public interface IMigrationTask
    {
        string Description { get; }
        bool CanLooseData { get; }
        string AffectedTable { get; }
    }
}
