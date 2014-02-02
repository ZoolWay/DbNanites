using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbNanites.Core
{
    class YamlParser
    {

        public YamlParser()
        {
        }

        public YamlDefinition Parse(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                return Parse(fs);
            }
        }

        public YamlDefinition Parse(Stream yamlInputStream)
        {
            throw new NotImplementedException();
        }

    }
}
