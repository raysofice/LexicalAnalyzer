﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public enum WordType
    {
        KeyWord=1,
        Identifier,        
        Constant,
        Operator,
        Delimiter,
        Error
    }
}
