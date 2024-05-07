using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCode
{
    internal class Point:IComparable,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point(int x, int y) : this(x, y, 0) { }
        public Point(int x) : this(x, 0, 0) { }
        public Point() : this(0) { }
        //Copy Constructor 
        public Point(Point P) {

            this.X = P.X;          
            this.Y = P.Y;
            this.Z = P.Z;
        }
        public int CompareTo(object? obj)
        {
            Point P = (Point)obj;
            if (X > P.X && Y > P.Y) { return 1; }
            if (X < P.X && Y < P.Y) { return -1; }
            else { return 0; }
        }
        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        public object Clone()
        {
            return new Point(this);
        }
    }
}
