using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbNanites.Core
{
	internal class YamlParser : IModelParser
    {

        public YamlParser()
        {
        }

        public IModelParseResult Parse(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                return Parse(fs);
            }
        }

        public IModelParseResult Parse(Stream yamlInputStream)
        {
            throw new NotImplementedException();
        }

    }
}
