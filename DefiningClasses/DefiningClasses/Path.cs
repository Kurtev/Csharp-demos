using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework2
{
   public class Path
   {
       private List<Point3D> PathOfPoints = new List<Point3D>();
       
       public Path(params Point3D[] Points)
       {
           foreach (Point3D point in Points)
           {
               PathOfPoints.Add(point);
           }
       }

       public List<Point3D> PathList
       {
           get { return this.PathOfPoints; }
       }

       public void AddPoint(Point3D point)
       {
           PathOfPoints.Add(point);
       }

       public void ReomovePoint(Point3D point)
       {
           PathOfPoints.Remove(point);
       }


       
   }
}
