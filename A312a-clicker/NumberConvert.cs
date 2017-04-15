using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public static class NumberConvert
    {

        public static string ConvertIt(UInt64 Input)
        {
            /*
            Million     = 1000000;
            Billion     = 1000000000;
            Trillion    = 1000000000000;
            Quadrillion = 1000000000000000;
            Quintillion = 1000000000000000000;
            Sextillion  = 1000000000000000000000;
            Septillion  = 1000000000000000000000000;
            Octillion   = 1000000000000000000000000000;
            */
            int InputSize = 0;
            /* Must add a name for every number added */
            double[] Numbers = { 1.0, 1000000.0, 1000000000.0, 1000000000000.0, 1000000000000000.0, 1000000000000000000.0, 1000000000000000000000.0, 1000000000000000000000000.0, 1000000000000000000000000000.0 };
            string[] NumberNames = { "", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion" };
            int NumbersSize = Numbers.Count();

            for(int i = 1; i < NumbersSize; ++i)
            {
                if (Input < Numbers[i])
                {
                    InputSize = i - 1;
                    break;
                }
            }
            return (Input/Numbers[InputSize]).ToString("F") + " " + NumberNames[InputSize];
        }




    }
}
