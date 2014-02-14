using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public class MigrationRunner
    {
        public static MigrationRunner Factory()
        {
            return new MigrationRunner();
        }

        public MigrationRunner()
        {

        }

        public void Run(IAnalyzeResult analyzeResult, Func<IMigrationTask, bool> filterDelegate = null)
        {
            throw new NotImplementedException();
        }
    }
}
