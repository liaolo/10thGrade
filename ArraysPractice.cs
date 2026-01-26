using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class ArraysPractice
    {
        public static void UnitTest()
        {
            //T10_6();
            //T10_7();
            //T10_8();
            //T10_12();
            //T10_18();

           

        }
        public static void T10_6()
        {
            double[] grades = new double[10];
            double avg, sum = 0, dist;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter your grade:");
                grades[i] = double.Parse(Console.ReadLine());
                sum = sum + grades[i];
            }
            avg = (sum / grades.Length);
            for (int i = 0; i < grades.Length; i++)
            {
                dist = Math.Abs(grades[i] - avg);
                Console.WriteLine("The distance between grade " + grades[i] + " and the average " + avg + " is: " + dist);
            }

        }

        public static void T10_7()
        {
            int[] arr = new int[10];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = i * i;
            }
            Console.WriteLine(arr[9]);
        }

        public static void T10_8()
        {
            //מטרת משפט הפור היא לבדוק
            //אם הערך השמור בכל תא גדול מהמשתנה
            // ולהציג באיזה תא זה קרה i
            int[] t = new int[20];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > i)
                {
                    Console.WriteLine(i);
                    if ((t[i] / 2 == i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static void T10_12()
        {
            int num, half;
            num = int.Parse(Console.ReadLine());
            int[] s = new int[num];
            half = num / 2;
            for (int i = 1; i <= half; i++)
            {
                s[i] = 0;
                Console.WriteLine(s[i]);
            }
            for (int i = num - 1; i >= half; i--)
            {
                s[i] = 1;
                Console.WriteLine(s[i]);
            }
        }

        public static void T10_13()
        {
            //לבדוק איזה ערכים של arr 
            //מתחלקים ב5 ללא שארית
            /*
             for (int i = 0; i < arr.Length; i++)
                 if (arr[i] % 5 == 0)
                     Console.WriteLine(arr[i]);
            */

            //להציג את הערכים של arr 
            //במקומות שמתחלקים ב5
            /*
             for (int i = 0; i < arr.Length; i++)
                 if (i % 5 == 0)
                     Console.WriteLine(arr[i]);
            */

            //סעיף ג
            //for (int i = 0; i < arr.Length; i=+5)
                    //Console.WriteLine(arr[i]);
        }

        public static void T10_17()
        {
            //סעיף א
            //קטע הקוד בודק אם הערך של arr במקום
            //postion שווה לערך אחד לפני

            //קטע הקוד בודק אם הערך של arr
            //במקום postion שווה לערך אחד אחרי
            /*
            if (arr[position] == arr[position - 1])
                Console.WriteLine("previous one is equal");
            if (arr[position] == arr[position + 1])
                Console.WriteLine("next one is equal");
            */

            // סעיף ב
            // מטרת קטע הקוד הוא לספור כמה פעמים הערך של arr 
            // במקום postion ועוד i שווים למקום postion
            /*
             for (int i = 0; i < 10; i++)
                if (arr[position] == arr[position + i])
                counter = counter + 1;
                Console.WriteLine(counter); 
            */

            //סעיף ג
            /*
            for (int i = 0; i < 20; i++)
                if (arr[position] < arr[position + i])
                    Console.WriteLine(arr[position + i]);
            */

            //סעיף ד
            /*
            for (int i = 0; i < 20; i++)
                if (arr[position]+1 = arr[position+i]
                    Console.WriteLine(arr[position + i]);
            */
        }

        public static void T10_18()
        {
            char[] c = new char[20];
            int Count = -1;
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Enter char");
                c[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == c[c.Length - 2] && c[c.Length - 1] == c[i+1]) 
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }


        public static string[] T10_23(string[] arr)
        {
            for (int min = 20; min < 75; min += 20)
            {
                string[] arb = new string[arr.Length];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arb[i] = arr[i+1];
                }
                arb[arb.Length - 1] = arr[0];
                arr = arb;
            }
            return arr;
        }

        //public static string[] T10_23b(string[] arrb, string[] arrg)
        //{

        //}

        public static int[] T10_24(int[] arr)
        {
            int[] arb = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arb[i] = arr[arr.Length - 1 - i];
            }
            return arb;
        }
    }
}
