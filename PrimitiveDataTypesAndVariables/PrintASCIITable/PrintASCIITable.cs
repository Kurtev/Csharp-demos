using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            char charVariable;
            for(int i=0;i<256;i++)
            {
                charVariable = (char)i;
                Console.Write("{0}: {1} ",i , charVariable);
            }
        }
    }
}
