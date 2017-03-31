using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public class Anton
    {
        public Anton() {}

        public int Number = 0;
        public double Price()
        {
            return 1.6 * (2 * Number);
        }
    }
}
