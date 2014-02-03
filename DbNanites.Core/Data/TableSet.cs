using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Data
{
	public class TableSet
    {
        public string TableName { get; set; }

        public IEnumerable<Record> Recors { get; set; }
    }
}
