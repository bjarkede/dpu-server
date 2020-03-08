using System;
using System.Collections.Generic;
using System.Text;

namespace dpu_server
{
    class Point2D
    {
        double x, y, distance;
        int classification;

        double norm2() { return (x * x) + (y * y); }
        double norm() { return Math.Sqrt(norm2()); }

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
            Point2D temp = new Point2D();
            temp.x = p1.x + p2.x;
            temp.y = p1.y + p2.y;
            return temp;
        }

        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            Point2D temp = new Point2D();
            temp.x = p1.x - p2.x;
            temp.y = p1.y - p2.y;
            return temp;
        }

        public static Point2D operator /(Point2D p, double num)
        {
            Point2D temp = new Point2D();
            temp.x = p.x/num;
            temp.y = p.y/num;
            return temp;
        }

        public static Point2D operator *(Point2D p, double num)
        {
            Point2D temp = new Point2D();
            temp.x = p.x * num;
            temp.y = p.y * num;
            return temp;
        }
    }

    class Circle2D
    {
        Point2D p;
        double radius;
    }
}
