using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vuvedete dve chisla:");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool checkNum = Math.Abs(num1 - num2) < eps ? true : false;

         
            Console.WriteLine(checkNum);
      
        }
    }
}
