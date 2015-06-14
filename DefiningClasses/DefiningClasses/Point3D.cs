using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework2
{
    public struct Point3D
    {

        private static readonly Point3D O;

        public Point3D(double x, double y, double z):this()
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }


        static Point3D()
        {
           O = new Point3D(0, 0, 0);
        }

        public static Point3D PointO
        {
            get { return O; }
        }
        
    
        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        public override string ToString()
        {
            return String.Format("{{{0}, {1}, {2}}}", this.PointX, this.PointY, this.PointZ);
        }
    }
}
