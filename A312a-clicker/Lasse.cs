﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public class Lasse : Person
    {
        public override double Price()
        {
            return 1000 + 1.6 * (2 * Math.Pow(Number, 3));
        }
    }
}