using NUnit.Framework;
using System;
using System.Linq;
using DbNanites.Core;
using DbNanites.Core.Data;
using System.Collections.Generic;

namespace DbNanites.Test
{
	[TestFixture ()]
	public class TestYamlDefinition
	{
		IParser parser;
		IDefinition definition;

		[SetUp]
		public void Init()
		{
			parser = new YamlParser ();
			definition = parser.Parse ("TestDatabase.yml");
		}

		[TestCase ("ItemGroups")]
		public void TableName (string table)
		{
			TableSet ts = LoadTableSet (table);
			Assert.True (ts != null, String.Format ("Table {0} is missing in yaml file.", table));
		}

		[Test]
		[TestCaseSource("FieldsOfItemGroups")]
		[TestCaseSource("FieldsOfItems")]
		public void ContainsField(string table, string field)
		{
			TableSet ts = LoadTableSet (table);
			bool validFieldName = ts.Recors.Any (r => r.Keys.Any(k => k == field));
			Assert.True (validFieldName, String.Format("Table '{0}' must have a field '{1}'.", table, field));
		}

		[Test ()]
		public void SchemeDefinition()
		{
			List<TableSet> tableSets = definition.Data.Tables.ToList ();
			TableSet ts = tableSets.Find (t => t.TableName == "ItemGroups");

		}

		private TableSet LoadTableSet(string table)
		{
			List<TableSet> tableSets = definition.Data.Tables.ToList ();
			return tableSets.Find (t => t.TableName == table);
		}

		static object[] FieldsOfItemGroups =
		{
			new object[] { "ItemGroups", "Id"},
			new object[] { "ItemGroups", "Name"},
		};

		static object[] FieldsOfItems =
		{
			new object[] { "Items", "Id"},
			new object[] { "Items", "Name"},
			new object[] { "Items", "Group"}
		};
	}
}

