using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorigunTextParseLib.Utils
{
    class DictionaryOfLiterals
    {
        public String[] Patterns { get; set; }
        public DictionaryOfLiterals[] Items { get; set; }
        public String Name { get; set; }
        public int PriorityLiteral { get; set; }
    }
}
