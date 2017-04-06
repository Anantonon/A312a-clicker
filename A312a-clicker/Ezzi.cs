using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public class Ezzi : Person
    {
        public Ezzi (string Name, Label person_price, Label person_count, Label person_words_s)
            : base(Name, person_price,  person_count,  person_words_s)
        {
            Words_second = 1000000;
        }

        public override double Price()
        {
            return 5000000000 + 1.6 * (2 * Math.Pow(Number, 2));
        }
    }
}
