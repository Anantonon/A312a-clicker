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
        }

        public override double Price()
        {
            return 2 + 1.6 * (2 * Math.Pow(Number, 2));
        }

        public override void Upgrade()
        {
            if (Upgrade1_true)
            {
                Upgrade_Factor *= 5;
                Upgrade1_true = false;
            }
            Refresh();
        }
    }
}
