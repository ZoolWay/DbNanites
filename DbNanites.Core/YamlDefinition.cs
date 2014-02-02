using DbNanites.Core.Data;
using DbNanites.Core.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    class YamlDefinition
    {
        public SchemeDefinition Scheme { get; set; }

        public ImportSet Data { get; set; }
    }
}
