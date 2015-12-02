using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n*2];
            int firstHalf = 0;
            int secondHalf = 0;
            for(int i=0; i<n*2; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i <n)
                {
                    
                    firstHalf += array[i];
                }
                else
                {
                    secondHalf += array[i];
                }
            }

            string result = firstHalf == secondHalf ? "Yes, sum= " + firstHalf.ToString() : "No, diff= "+ Math.Abs(firstHalf-secondHalf).ToString();
            Console.WriteLine(result);
        }
    }
}
