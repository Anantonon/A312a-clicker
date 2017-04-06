using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public class Thue : Person
    {
        public override double Price()
        {
            return 999999999999 + 1.6 * (2 * Math.Pow(Number, 2));
        }
    }
}
