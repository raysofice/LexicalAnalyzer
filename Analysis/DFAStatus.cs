using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class DFAStatus
    {
        public int State { get; set; }
        public Dictionary<Char,int> Next { get; set; }
        public int IsEnd { get; set; }

        public DFAStatus() { }

        public DFAStatus(int state, int end)
        {
            this.State = state;
            Next = new Dictionary<char,int>();
            this.IsEnd = end;
        }
    }
}
