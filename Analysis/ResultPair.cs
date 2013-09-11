using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class ResultPair
    {
        public int length { get; set; }
        public WordType type { get; set; }

        public ResultPair() { }
        public ResultPair(int l, WordType t)
        {
            this.length = l;
            this.type=t;
        }
    }
}
