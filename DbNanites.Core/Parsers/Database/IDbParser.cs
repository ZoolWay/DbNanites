using DbNanites.Core.Scheme;
using System.Data;

namespace DbNanites.Core.Parsers.Database
{
    internal interface IDbParser
    {
        SchemeDefinition RetrieveSchemeDefinition(IDbConnection connection);
    }
}
