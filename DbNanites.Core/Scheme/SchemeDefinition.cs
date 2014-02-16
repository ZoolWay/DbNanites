using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
    internal class SchemeDefinition
    {
        public string Name { get; set; }

        public List<TableDefinition> Tables { get; private set; }

        public SchemeDefinition()
        {
            this.Tables = new List<TableDefinition>();
        }
    }
}
