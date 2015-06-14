using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework2
{
   public static class Distance
    {
       public static double  PointToPointDistance(Point3D point1, Point3D point2)
       {
           return Math.Sqrt(Math.Pow((point1.PointX - point2.PointX), 2) + Math.Pow((point1.PointY - point2.PointY), 2) + 
                  Math.Pow((point1.PointZ - point2.PointZ), 2));
       }
        
    }
}
