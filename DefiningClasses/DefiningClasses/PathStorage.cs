using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TelerikHomework2
{
   public static class PathStorage
    {
       public static void SavePath(Path path, string pathLocation)
       {                                                     
           using (StreamWriter sw = new StreamWriter("..//..//" + pathLocation + ".txt"))
           {


               for (int i = 0; i < path.PathList.Count; i++)
               {
                   sw.WriteLine(path.PathList[i]);
               }
             
           }
       }
       public static Path LoadPath(string pathLocation) 
       {
           Path path = new Path();
           
           using (StreamReader sr = new StreamReader("..//..//" + pathLocation + ".txt"))
           {
               while (sr.EndOfStream == false)
               {
                   List<double> cordinates = new List<double>();
                   string nextPointTxt = sr.ReadLine();
                   nextPointTxt = nextPointTxt.Trim(new char[]{'{','}'});
                   string[] bits = nextPointTxt.Split(' ');
                   
                   for(int i=0;i<bits.Length;i++)
                   {
                       
                       
                      cordinates.Add(double.Parse(bits[i]));
                          
                       
                   }
                   path.AddPoint(new Point3D(cordinates[0], cordinates[1], cordinates[2]));
               }

               return path;
           }
       }
    }
}
