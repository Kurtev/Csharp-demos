using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();

            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            if(yearType == "t")
            {
                double normalWeekends = (52 - h) * ((double)2 / 3);
                double holydayPlays = p * 0.5;
                Console.WriteLine(Math.Truncate(normalWeekends + holydayPlays + 3 + h));
            }
            else
            {
                double normalWeekends = (52 - h) * ((double)2 / 3);
                double holydayPlays = p * 0.5;
                Console.WriteLine(Math.Truncate(normalWeekends + holydayPlays + h));
            }
        }
    }
}
