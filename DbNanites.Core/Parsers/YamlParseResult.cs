using DbNanites.Core.Data;
using DbNanites.Core.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
	internal class YamlParseResult : IModelParseResult, IModel
    {
        public string Description { get; set; }

        public SchemeDefinition Scheme { get; set; }

        public ImportSet Data { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> ErrorList { get; private set; }

        public IEnumerable<string> TableNames 
        {
            get
            {
                return this.Scheme.Tables.Select(t => t.Name);
            }
        }

    }
}
