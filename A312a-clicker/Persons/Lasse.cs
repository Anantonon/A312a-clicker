﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public class Lasse : Person
    {
        public Lasse (string Name, Label person_price, Label person_count, Label person_words_s)
            : base(Name, person_price,  person_count,  person_words_s)
        {
            Words_second = 100;
        }

        public override double Price()
        {
            return 10000 + 20 * (2 * Math.Pow(Number, 2));
        }

        public override double Upgrade1()
        {
            return 3;
        }

        public override double Upgrade2()
        {
            return 2;
        }

        public override double Upgrade3()
        {
            return 1.5;
        }
    }
}
