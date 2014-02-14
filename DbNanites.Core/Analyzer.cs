using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public class Analyzer
    {
        public static Analyzer Factory()
        {
            return new Analyzer();
        }

        public Analyzer()
        {
        }

        public IAnalyzeResult GetChanges(IModelParseResult parsedModel, IDbConnection targetDatabase)
        {
            throw new NotImplementedException();
        }
    }
}
