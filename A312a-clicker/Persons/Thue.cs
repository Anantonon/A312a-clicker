﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public class Thue : Person
    {
        public Thue(string Name, Label person_price, Label person_count, Label person_words_s)
            : base(Name, person_price,  person_count,  person_words_s)
        {
            Words_second = 999999999;
        }

        public override double Price()
        {
            return 100000000000000000 + 800000000 * (2 * Math.Pow(Number, 2));
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
