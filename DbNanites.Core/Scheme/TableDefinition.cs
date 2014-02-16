using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
    internal class TableDefinition
    {
        public List<ColumnDefinition> Columns { get; private set; }

        public string Name { get; set; }

        public IndexDefinition PrimaryKey { get; set; }

        public List<IndexDefinition> Indexes { get; private set; }

        public TableDefinition()
        {
            this.Columns = new List<ColumnDefinition>();
            this.Indexes = new List<IndexDefinition>();
        }

    }
}
