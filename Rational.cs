using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    public class Rational
    {
        public static void UnitTest()
        {
            Rational a = new Rational(1, 2);
            Rational b = new Rational(3, 4);

            Console.WriteLine(a); 
            Console.WriteLine(b); 

            Console.WriteLine(a.IsEqual(b)); 

            Rational m = a.Multiply(b); 
            Console.WriteLine(m);

            Rational d = a.Divide(b);   
            Console.WriteLine(d);

            Rational sum = a.Add(b);    
            Console.WriteLine(sum);

            Rational sub = a.Sub(b);    
            Console.WriteLine(sub);

            Rational expected = new Rational(3, 8);
            Console.WriteLine(m.IsEqual(expected)); 
        }

        private int x;
        private int y;

        public Rational()
        {
            this.x = 0;
            this.y = 1;
        }

        public Rational(int x, int y)
        {
            if (y != 0)
            {
                this.x = x;
                this.y = y;
            }
        }

        public int GetNumerator()
        {
            return this.x;
        }
        public int GetDenom()
        {
            return this.y;
        }

        public bool IsEqual (Rational num)
        {
            if(this.x*num.y == num.x * this.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Rational Multiply(Rational num)
        {
            Rational Mp = new Rational();
            Mp.x = this.x * num.x;
            Mp.y = this.y * num.y;
            return Mp;
        }

        public Rational Divide(Rational num)
        {
            Rational div = new Rational();
            div.x = this.x * num.y;
            div.y = this.y * num.x;
            return div;
        }

        public Rational Add(Rational num)
        {
            Rational add = new Rational();
            add.x = (this.x * num.y) + (this.y * num.x);
            add.y = this.y * num.y;
            return add;
        }

        public Rational Sub(Rational num)
        {
            Rational sub = new Rational();
            sub.x = (this.x * num.y) - (this.y * num.x);
            sub.y = this.y * num.y;
            return sub;
        }

        public override string ToString()
        {
            return $"<{this.x}> / <{this.y}>";
        }

    }
}
