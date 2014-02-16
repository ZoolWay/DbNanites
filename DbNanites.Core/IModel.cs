using DbNanites.Core.Data;
using DbNanites.Core.Scheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    internal interface IModel
    {
        string Description { get; }

        SchemeDefinition Scheme { get; set; }

        ImportSet Data { get; set; }
    }
}
