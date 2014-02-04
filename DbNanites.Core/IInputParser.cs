using System;
using System.IO;

namespace DbNanites.Core
{
	public interface IInputParser
	{
		IInputDefinition Parse (string filename);

		IInputDefinition Parse(Stream yamlInputStream);
	}
}

