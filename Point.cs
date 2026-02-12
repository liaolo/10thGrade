using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    public class Point
    {

        public static void UnitTests()
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine(p1);
            p1.Getx(5.5);
            Console.WriteLine(p1.SetX());
            p1.Gety(6);
            Console.WriteLine(p1.Sety());
            Console.WriteLine(p1);
        }

        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Getx(double x)
        {
             this.x=x;
        }

        public double SetX()
        {
            return this.x;
        }

        public void Gety(double y)
        {
             this.y = y;
        }

        public double Sety()
        {
            return this.y;
        }

        public override string ToString()
        {
            return $"Point({this.x},{ this.y})";
        }
    }
}
