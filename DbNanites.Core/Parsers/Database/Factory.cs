using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Parsers.Database
{
    internal static class Factory
    {
        /// <summary>
        /// Provides an IDbParser based on the DB connection type.
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static IDbParser Get(IDbConnection connection)
        {
            Type typeConnection = connection.GetType();
            switch (typeConnection.FullName)
            {
                case "System.Data.SqlClient.SqlConnection": // MS SQL
                case "Npgsql.NpgsqlConnection": // PostgreSQL
                case "MySql.Data.MySqlClient.MySqlConnection": // MySQL
                case "System.Data.SQLite.SQLiteConnection": // SQLite
                    return new InformationSchemeSupported();

                case "IBM.Data.DB2.iSeries.iDB2Connection":
                default:
                    throw new Exception(String.Format("The provided database connection type '{0}' seems to be an unsupported connection", typeConnection.FullName));
            }
        }
    }
}
