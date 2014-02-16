using DbNanites.Core.Scheme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Parsers.Database
{
    /// <summary>
    /// Provides database scheme for all RDBMS providing the ANSI SQL standard INFORMATION_SCHEME.
    /// </summary>
    internal class InformationSchemeSupported : IDbParser
    {
        public InformationSchemeSupported()
        {
        }

        public Scheme.SchemeDefinition RetrieveSchemeDefinition(IDbConnection connection)
        {
            SchemeDefinition scheme = new SchemeDefinition();

            RetrieveTables(connection, scheme);

            return scheme;
        }

        private void RetrieveTables(IDbConnection connection, SchemeDefinition scheme)
        {
            using (IDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT TABLE_CATALOG, TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA";
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    TableDefinition table = new TableDefinition();
                    table.Name = reader["TABLE_NAME"] as string;

                    RetrieveColumns(connection, table);

                    scheme.Tables.Add(table);
                }
            }
        }

        private void RetrieveColumns(IDbConnection connection, TableDefinition table)
        {
            using (IDbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT COLUMN_NAME, COLUMN_DEFAULT, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, DATETIME_PRECISION, COLLATION_NAME";
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    ColumnDefinition column = new ColumnDefinition();
                    column.Name = reader["COLUMN_NAME"] as string;

                    table.Columns.Add(column);
                }
            }
        }
    }
}
