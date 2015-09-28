using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_A4_win_forms
{
    class Numbers
    {

        public static int Power(int baseValue, int exponentValue)
        {
            if (exponentValue == 0)
            {
                return 1;
            }
            else if (exponentValue < 0)
            {
                return 0;
            }
            else
            {
                return baseValue * Power(baseValue, exponentValue - 1);
            }

        }


        public static bool Prime(int value)
        {

            if ((value & 1) == 0)
            {
                if (value == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            for (int count = 2; (count * count) <= value; count += 1)
            {
                if ((value % count) == 0)
                {
                    return false;
                }
            }
            return value != 1;
        }
    }
}
