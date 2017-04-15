using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public class Anton : Person
    {
        public Anton (string Name, Label person_price, Label person_count, Label person_words_s) 
            : base(Name, person_price,  person_count,  person_words_s)
        {
            Words_second = 2;
            Upgrade1Tooltip = "Ali - 3xWords/s\n\nAnton får adgang til Ali, og kan derved mindske sin autisme";
        }

        public override double Price()
        {
            return 10 + 1.6 * (2 * Math.Pow(Number, 2));
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
