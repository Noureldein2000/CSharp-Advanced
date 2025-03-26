using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Operator_Overloading
{
    public class CustomPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CustomPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static CustomPoint operator +(CustomPoint p1, CustomPoint p2)
        {
            return new CustomPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static CustomPoint operator -(CustomPoint p1, CustomPoint p2)
        {
            return new CustomPoint(p1.X - p2.X, p1.Y - p2.Y);
        }
        public static bool operator >(CustomPoint p1, CustomPoint p2)
        {
            return p1.X > p2.X || p1.Y > p2.Y;
        }
        public static bool operator <(CustomPoint p1, CustomPoint p2)
        {
            return p1.X < p2.X || p1.Y < p2.Y;
        }

        public static bool operator ==(CustomPoint p1, CustomPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(CustomPoint p1, CustomPoint p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator CustomPoint(int x)
        {
            return new CustomPoint(x, x);
        }

        public static implicit operator int(CustomPoint p)
        {
            return p.X;
        }

    }
}
