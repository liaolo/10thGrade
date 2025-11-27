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
           Targil7_67_b();
        }

        public static void Targil17_66_a() // יוצר מלבן
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

        public static void Targil7_66_b() // יוצר משולש
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Targil7_66_c() // יוצר ריבוע של 1-5
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        public static void Targil7_66_d() // משולש הפוך
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void Targil7_67_a()
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void Targil7_67_b()
        {
            for (int j = 0; j<5; j++)
            {
                for (int i = 5; i>j; i--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void Targil7_67_c()
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 5; i > j; i--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
