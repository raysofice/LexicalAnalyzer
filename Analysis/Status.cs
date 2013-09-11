using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class Status
    {
        public int State { get; set; }
        public Dictionary<Char, HashSet<int>> Next { get; set; }
        public int IsEnd { get; set; }

        public Status() { }

        public Status(int state, int end)
        {
            this.State = state;
            Next = new Dictionary<char,HashSet<int>>();
            this.IsEnd = end;
        }

        
    }
}
