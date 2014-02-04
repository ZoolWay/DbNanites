using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbNanites.Core
{
	public class YamlParser : IInputParser
    {

        public YamlParser()
        {
        }

		public IInputDefinition Parse(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                return Parse(fs);
            }
        }

		public IInputDefinition Parse(Stream yamlInputStream)
        {
            throw new NotImplementedException();
        }

    }
}
