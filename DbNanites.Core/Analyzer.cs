using DbNanites.Core.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    /// <summary>
    /// Analyzes the reference model against an actual database.
    /// </summary>
    public class Analyzer
    {

        #region Fields --------------------------------------------------------

        /// <summary>
        /// Logger instance.
        /// </summary>
        private static readonly log4net.ILog log = global::log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        public static Analyzer Factory()
        {
            return new Analyzer();
        }

        public Analyzer()
        {
        }

        public IAnalyzeResult GetChanges(IModelParseResult parsedModel, IDbConnection targetDatabase)
        {
            // check arguments
            if (parsedModel == null) throw new ArgumentNullException("parsedModel");
            if (targetDatabase == null) throw new ArgumentNullException("targetDatabase");
            if (!(parsedModel is IModel)) throw new Exception("Supplied parsed model does not satify internal requirements!");

            AnalyzeResult result = new AnalyzeResult();

            try
            {
                // analyze target database
                log.DebugFormat("Analyzing the target database '{0}' found in connection string '{1}', connection type is '{2}'", targetDatabase.Database, targetDatabase.ConnectionString, targetDatabase.GetType().FullName);
                Parsers.Database.IDbParser dbParser = Parsers.Database.Factory.Get(targetDatabase);
                SchemeDefinition dbDefinition = dbParser.RetrieveSchemeDefinition(targetDatabase);

                // compare
                IModel referenceModel = parsedModel as IModel;
                log.DebugFormat("Reference model: '{0}' ({1} tables)", referenceModel.Description, referenceModel.Scheme.Tables.Count);
                foreach (var modelTable in referenceModel.Scheme.Tables)
                {
                    log.DebugFormat("Checking reference table '{0}'", modelTable.Name);
                    var dbTable = dbDefinition.Tables.FirstOrDefault(t => t.Name == modelTable.Name);
                    if (dbTable != null)
                    {
                        // TODO compare with db table
                    }
                    else
                    {
                        // TODO add migrationt ask for table creation
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Analysis failed with exception", ex);
                result.AddErrorMessage(ex.Message);
                result.Success = false;
            }

            return result;
        }
    }
}
