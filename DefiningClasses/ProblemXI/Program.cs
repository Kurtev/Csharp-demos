using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _11.VersionAttribute
{
    [Version("Version 3.2")]

    class Sample
    {
        static void Main()
        {
          
            var type = typeof(Sample);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}