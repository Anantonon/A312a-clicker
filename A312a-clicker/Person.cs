﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public abstract class Person
    {
        public UInt64 Number = 0;
        public abstract double Price();
    }
}
