using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = '©';  
            int triangleSize = 4;
            int outerSpacesCount = triangleSize-1;
            int innerSpacesCount = 1;

            Console.WriteLine("{0}{1}{0}",new string(' ',triangleSize),new string(character,1));

           for(int i = 1; i<triangleSize; i++)
           {
               if(i<triangleSize-1)
               {
               
               Console.WriteLine("{0}{1}{2}{1}{0}",new string(' ',outerSpacesCount), new string(character, 1), new string(' ', innerSpacesCount));
               innerSpacesCount += 2;
               outerSpacesCount--;
               }
               else
               {
                   for(int j =0; j<triangleSize;j++)
                   {
                       Console.Write(" {0}", character);
                   }
                   Console.WriteLine();
               }
               
           }
        }
    }
}
