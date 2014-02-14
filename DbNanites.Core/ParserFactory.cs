using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core
{
    public static class ParserFactory
    {
		/// <summary>
		/// Creates a model parser based on the provided file.
		/// Currently supported files: Yaml
		/// </summary>
		/// <param name="filename">File which is used for parser detection.</param>
		/// <returns>>A model parser which fits to the provided file.
		/// If the file isn't supported this method returns null.</returns>
		public static IModelParser Provide(string filename)
        {
            throw new NotImplementedException();
        }

		/// <summary>
		/// Creates a yaml file parser.
		/// </summary>
		/// <returns>The yaml.</returns>
        public static IModelParser ProvideYaml()
        {
            throw new NotImplementedException();
        }
    }
}
