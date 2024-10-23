using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) 
            {
                return false;
            }

            Point p = (Point)obj;

            return X == p.X && Y == p.Y && Z == p.Z;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
    }
}

