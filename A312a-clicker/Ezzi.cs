using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public class Ezzi : Person
    {
        public override double Price()
        {
            return 5000000000 + 1.6 * (2 * Math.Pow(Number, 2));
        }
    }
}
