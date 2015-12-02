using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object objectVariable = hello + " " + world;
            string helloWorld = (string)objectVariable;

            Console.WriteLine(helloWorld);
        }
    }
}
