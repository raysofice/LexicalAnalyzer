using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class Token
    {
        public int Id { get; set; }        
        public WordType Type { get; private set; }
        public string Content { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }
        
        public Token() { }
        public Token(int d,WordType type, string content,int row, int column)
        {
            this.Id = d;
            this.Type = type;
            this.Row = row;
            this.Column = column;
            this.Content = content;
        }
    }
}
