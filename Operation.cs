﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Operation
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public Operation NextOperation { get; set; }
    }
}
