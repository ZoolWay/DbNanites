using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbNanites.Core
{
	public class YamlParser : IParser
    {

        public YamlParser()
        {
        }

		public IDefinition Parse(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                return Parse(fs);
            }
        }

		public IDefinition Parse(Stream yamlInputStream)
        {
            throw new NotImplementedException();
        }

    }
}
