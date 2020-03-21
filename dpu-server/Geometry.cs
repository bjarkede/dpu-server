using System;
using System.Collections.Generic;
using System.Text;

namespace dpu_server
{
    class Point2D
    {
        public double x, y, distance;
        public int classification;

        public Point2D(double x_, double _y) { x = x_; y = _y; }

        public double norm2() { return (x * x) + (y * y); }
        public double norm() { return Math.Sqrt(norm2()); }

        public static bool operator <(Point2D p1, Point2D p2)
        {
            return p1.x < p2.x || (p1.x == p2.x && p1.y < p2.y);
        }
        public static bool operator >(Point2D p1, Point2D p2)
        {
            return p1.x > p2.x || (p1.x == p2.x && p1.y > p2.y);
        }
        public static Point2D operator +(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point2D operator /(Point2D p, double num)
        {
            return new Point2D(p.x/num, p.y/num);
        }

        public static Point2D operator *(Point2D p, double num)
        {
            return new Point2D(p.x * num, p.y * num);
        }
    }

    class Circle2D
    {
        public Point2D p;
        public double radius;
        public Circle2D(Point2D p_, double r)
        {
            p = p_;
            radius = r;
        }
    }
}
