using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValueArithmetics
{
    class NullValueArtihmetics
    {
        static void Main(string[] args)
        {
            int? intVariable = null;
            double? doubleVariable = null;

            Console.WriteLine(intVariable);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(intVariable+2);
            Console.WriteLine(doubleVariable + 2);
            Console.WriteLine(intVariable + null);
            Console.WriteLine(doubleVariable + null);
        }
    }
}
