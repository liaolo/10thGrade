using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class NesttedLoops
    {
        public static void UnitTest()
        {
            Targil1_d();
        }

        public static void Targil1_a() // יוצר מלבן
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void Targil1_b() // יוצר משולש
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Targil1_c() // יוצר ריבוע של 1-5
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        public static void Targil1_d() // משולש הפוך
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void Targil2() //
        {

        }
        
    }
}
