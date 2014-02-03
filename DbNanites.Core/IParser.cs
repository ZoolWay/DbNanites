using System;
using System.IO;

namespace DbNanites.Core
{
	public interface IParser
	{
		IDefinition Parse (string filename);

		IDefinition Parse(Stream yamlInputStream);
	}
}

