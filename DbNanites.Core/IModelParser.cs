using System;
using System.IO;

namespace DbNanites.Core
{
    /// <summary>
    /// Defines the basic interface to parse a model from a source like a YAML file.
    /// </summary>
	public interface IModelParser
	{
        IModelParseResult Parse(string filename);

        IModelParseResult Parse(Stream yamlInputStream);
	}
}

