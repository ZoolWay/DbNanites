using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
    class TableDefinition
    {
        public IEnumerable<ColumnDefinition> Columns { get; set; }

        public string Name { get; set; }

        public IndexDefinition PrimaryKey { get; set; }

        public IEnumerable<IndexDefinition> Indexes { get; set; }
    }
}
