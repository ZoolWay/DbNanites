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

        /// <summary>
        /// Filter method can be used with Run() to get only migrations to run which cannot loose data.
        /// </summary>
        public Func<IMigrationTask, bool> OnlyNonCritical = (migrationTask) => { return (!migrationTask.CanLooseData); };

        /// <summary>
        /// Filter method can be used with Run() to run all migrations. Although in that case the filter
        /// parameter could just be omitted.
        /// </summary>
        public Func<IMigrationTask, bool> All = (migrationTask) => { return true; };

        public void Run(IAnalyzeResult analyzeResult, Func<IMigrationTask, bool> filterDelegate = null)
        {
            throw new NotImplementedException();
        }
    }
}
