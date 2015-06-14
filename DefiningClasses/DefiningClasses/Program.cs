using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
           Path path = new Path(
               new Point3D(3,4,5),
               new Point3D(3,4,10.5),
               new Point3D(3,4,1),
               new Point3D(3,4,4),
               new Point3D(3,4,1)
               );
  
           foreach (Point3D point in path.PathList)
           {
               Console.WriteLine(point);
           }

           PathStorage.SavePath(path,"test");

           Path LoadedPath = PathStorage.LoadPath("test");

            Console.WriteLine("\nLoad Path from file");
           foreach (Point3D point in LoadedPath.PathList)
           {
               Console.WriteLine(point);
           }

          

            double distance = Distance.PointToPointDistance(LoadedPath.PathList[0],LoadedPath.PathList[1]);
            Console.WriteLine("Distance between the first two points: {0} ",distance);
        }
    }
}
