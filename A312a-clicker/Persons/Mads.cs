using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public class Mads : Person
    {
        public Mads (string Name, Label person_price, Label person_count, Label person_words_s)
            : base(Name, person_price,  person_count,  person_words_s)
        {
            Words_second = 800000;
        }

        public override double Price()
        {
            return 10000000 + 50000 * (2 * Math.Pow(Number, 2));
        }
    }
}
