using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Monthsofyear { Jan=1, Feb=2, Mar=3, April=4,May=5};
        static void Main(string[] args)
        {
            Console.WriteLine("First month: \t" + Monthsofyear.Jan);
            Console.WriteLine("Second month: \t" + Monthsofyear.Feb);
            Console.WriteLine("third month: \t" + Monthsofyear.Mar);
            Console.WriteLine("fourth month: \t" + Monthsofyear.April);
            Console.ReadKey();



        }




    }
}
