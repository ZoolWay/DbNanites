using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
	public class SchemeDefinition
    {
        public string Name { get; set; }

        public IEnumerable<TableDefinition> Tables { get; set; }
    }
}
