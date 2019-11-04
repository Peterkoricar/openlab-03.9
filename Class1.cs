using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlab_03._9
{
    class Number
    {
        public bool IsPrimeNumber(int num)
        {
            if (num == 1)
            {
                return false;
            }
            for (int a = 2; a < num; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
