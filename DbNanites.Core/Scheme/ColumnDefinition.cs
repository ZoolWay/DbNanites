using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
    internal class ColumnDefinition
    {
        public string Name { get; set; }

        public Datatype Datatype { get; set; }

        public int Length { get; set; }

        public int Precision { get; set; }

        public bool Nullable { get; set; }

        public string Default { get; set; }
    }
}
