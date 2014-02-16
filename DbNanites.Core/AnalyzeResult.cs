using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public class AnalyzeResult : IAnalyzeResult
    {
        private List<string> errorList;
        private List<IMigrationTask> migrations;

        public bool Success { get; set; }
        public IEnumerable<string> ErrorList { get { return this.errorList; } }
        public IEnumerable<IMigrationTask> Migrations { get { return this.migrations; } }

        public AnalyzeResult()
        {
            this.Success = false;
            this.errorList = new List<string>();
            this.migrations = new List<IMigrationTask>();
        }

        public void AddErrorMessage(string message)
        {
            this.errorList.Add(message);
        }

        public void AddMigration(IMigrationTask migration)
        {
            this.migrations.Add(migration);
        }
    }
}
