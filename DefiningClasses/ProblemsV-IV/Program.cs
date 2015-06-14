using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemsV_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> gList = new GenericList<int>();
            gList.Add(1);
            gList.Add(2);
            gList.Add(4);
            gList.Add(6);
            gList.Add(4);
            gList.Add(5);
            gList.Add(6);

            Console.WriteLine("Print the list");
            Console.WriteLine(gList);
            Console.WriteLine("Minimum element: {0}",gList.Max());
            Console.WriteLine("Maximum element: {0}",gList.Min());

            gList.RemoveAt(3);
            gList.InsertAt(5, 12);
            Console.WriteLine("Index of [4]: {0}",gList.IndexOf(4));

          
            Console.WriteLine("Print the list after removing at [3] and adding 12 at[5]");
            Console.WriteLine(gList);
         
        }
     
    }
}
