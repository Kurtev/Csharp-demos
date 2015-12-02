using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char asteriks = '*';
            char straightLine = '|';
            char leanLine = '/';


            Console.WriteLine("{0}{1}{0}",new string(asteriks, n*2),new string(' ',n));

            for(int i = 0; i<n-2;i++)
            {
                if (i == n / 2-1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string(asteriks, 1), new string(leanLine, n * 2 - 2), new string(straightLine, n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string(asteriks, 1), new string(leanLine, n * 2 - 2), new string(' ', n));
                }
            }
            Console.WriteLine("{0}{1}{0}", new string(asteriks, n * 2), new string(' ', n));
        }
    }
}
