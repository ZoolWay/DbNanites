using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Data
{
	public class ImportSet
    {
        public IEnumerable<TableSet> Tables { get; set; }
    }
}
