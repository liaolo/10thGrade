using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10thGrade
{
    internal class NesttedLoops
    {
        public static void UnitTest()
        {
            //Targil7_68();//
            //Targil7_69();//
            //Targil_48();//
            //Targil7_67_c();//
            //Console.WriteLine(lydia(6));
        }

        public static void Targil7_66_a() // יוצר מלבן
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
            for (int j = 0; j < 5; j++)
            {
                for (int i = 5; i > j; i--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void Targil7_67_c()
        {
            for (int j = 0; j <= 8; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (j < 5)
                    {
                        if (i < 5 - j)
                            Console.Write('*');
                    }
                    if (j >= 5)
                    {
                        if (i <= j - 4)
                        {
                            Console.Write('*');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67_d()
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void Targil7_67_e()
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67_f()
        {
            for (int j = 5; j > 0; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67_g()
        {
            for (int j = 5; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67_h()
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 5; i >= j; i--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Targil7_68()
        {
            const int STUDENT_NUM = 40;
            const int GRADE_NUM = 20;
            double grade;
            double sum = 0;
            double average;
            for (int i = 1; i <= STUDENT_NUM; i++)
            {
                for (int j = 1; j <= GRADE_NUM; j++)
                {
                    Console.WriteLine("Enter next student grade: ");
                    grade = int.Parse(Console.ReadLine());
                    sum = sum + grade;
                }
                Console.WriteLine(sum / 20);
            }
        }

        public static void Targil7_69()
        {
            int num, series = 0, count, max = 0;
            Console.WriteLine("Enter number of series: ");
            series = int.Parse(Console.ReadLine());
            for (int i = 0; i < series; i++)
            {
                count = 0;
                num = 0;
                while (num != -1)
                {
                    Console.WriteLine("Enter a number (-1 to end series): ");
                    num = int.Parse(Console.ReadLine());
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                }
            }
            Console.WriteLine("The longest series has " + max + " number/s.");
        }

        public static void Targil7_70()
        {
            double sal = 17, min = 17, minLastSal = 17, num;
            Console.Write("How many workers? ");
            num = int.Parse(Console.ReadLine());
            for (int j = 0; j < num; j++)
            {
                double sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    Console.Write("Salary? ");
                    sal = int.Parse(Console.ReadLine());
                    sum += sal;
                }
                Console.WriteLine("==============  Next ===============");
                if (j == 0)
                    min = sum;
                else if (sum < min)
                {
                    min = sum;
                    minLastSal = sal;
                }
            }
            Console.WriteLine("minLastSal: " + minLastSal);
        }
        public static void Targil_47()
        {
            double price, sum = 0, max = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("What is the price for one pen");
                    price = double.Parse(Console.ReadLine());
                    sum = sum + price;
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
                Console.WriteLine("==============  Next ===============");
            }
            Console.WriteLine("The highest price for all 5 pens is " + max);
        }

        public static void Targil_48()
        {
            double grade, sum = 0, average, min = 0;
            for (int i = 1; i <= 3; i++)
            {
                average = 0;
                sum = 0;
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("Enter student grade: ");
                    grade = double.Parse(Console.ReadLine());
                    sum = sum + grade;
                    average = sum / 4;
                    if (min < average)
                    {
                        min = average;
                    }
                }
                Console.WriteLine("==============  Next ===============");
            }
            Console.WriteLine("The lowest grade for group is " + min);
        }

        public static bool lydia(int a)
        {
            bool b = true;
            int n = a;
            for (int i = 2; i < a; i++)
            {
                if (n % i == 0)
                {
                    b = false;
                }
            }
            return b;

        }

        public static void lydia2()
        {
            for (int j = 2; j <= 100; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    NesttedLoops.lydia(i);
                }
            }
        }

        public static void lydia3()
        {
            int workers;
            double sal = 0, salmin = 0;
            Console.WriteLine("How many works");
            workers = int.Parse(Console.ReadLine());
            for (int i = 0; i < workers; i++)
            {
                double sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("How much did you make each month");
                    sal = int.Parse(Console.ReadLine());
                    sum += sal;
                }
                Console.WriteLine("NEXT");
                if (i == 0)
                {
                    salmin = sum;
                }
                if (sum < salmin)
                {
                    salmin = sum;
                }
            }
            Console.WriteLine("The lowest salary is " + salmin);


        }

        public static void lydia4()
        {
            int num = 0, numsdarot, count = -1, max = 0;
            Console.WriteLine("Enter number of series: ");
            numsdarot = int.Parse(Console.ReadLine());
            for (int i = 0; i < numsdarot; i++)
            {
                count = 0;
                num = 0;
                while (num != -1)
                {
                    Console.WriteLine("Enter a number (-1 to end series): ");
                    num = int.Parse(Console.ReadLine());
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                }
            }

            Console.WriteLine("The longest series is " + max);
        }

    }
}
