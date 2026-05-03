using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10thGrade
{
    public class Point
    {
        public static void UnitTests()
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine(p1);
            p1.SetX(5.5);
            Console.WriteLine(p1.GetX());
            p1.SetY(6);
            Console.WriteLine(p1.GetY());
            Console.WriteLine(p1);
            Point p2 = new Point();
            Console.WriteLine(p2);
        }

        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() : this(0, 0) { }

        public Point(Point P): this(P.x, P.y) { }
        
        public void SetX(double x)
        {
             this.x=x;
        }

        public double GetX()
        {
            return this.x;
        }

        public void SetY(double y)
        {
             this.y = y;
        }

        public double GetY()
        {
            return this.y;
        }

        public double Distance(Point P) 
        {
            double dx = this.x - P.x;
            double dy = this.y - P.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public Point Midpoint(Point P)
        {
            double midX = (this.x + P.x) / 2;
            double midY = (this.y + P.y) / 2;
            return new Point(midX, midY);
        }

        public double gradient(Point P)
        {
            int gradient = 0;
            int dx = (int)(P.x - this.x);
            int dy = (int)(P.y - this.y);

            gradient = dy / dx;
            return gradient;
        }

        public static Point FarthestfromOrigin(Point[] points)
        {
            Point farthest = points[0];
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i].Distance(new Point(0, 0)) > farthest.Distance(new Point(0, 0)))
                {
                    farthest = points[i];
                }
            }
            return farthest;
        }

        public override string ToString()
        {
            return $"Point({this.x},{ this.y})";
        }
    }
}
