using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string usingPrefix = @"The ""use"" of quotations causes difficulties.";
            string usingEscapeChar = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(usingPrefix);
            Console.WriteLine(usingEscapeChar);
        }
    }
}
