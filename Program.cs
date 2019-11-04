using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using openlab_03._9;

namespace openlab_03._9
{
    class Program
    {
        public static void Main (string [] args)
        {
            var PNum = new Number();
            for (int b = 1; b < 1000; b++)
            {
                Console.WriteLine($"{b};{PNum.IsPrimeNumber(b)}");
            }
        }
    }
}
