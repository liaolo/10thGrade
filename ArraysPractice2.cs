using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class ArraysPractice2
    {

        public static void UnitTest()
        {

        }
        public static void T10_19()
        {
            int Pos, Kobia;
            int[] Index = new int[25];
            Console.WriteLine("Enter bord");
            for (int i = 0; i < Index.Length; i++)
            {
                Index[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter your pos 10 - 15");
            Pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of the Kobia");
            Kobia = int.Parse(Console.ReadLine());
            if (Kobia >= Index[Pos + Kobia - 1])
            {
                Pos += Kobia;
            }
            else
            {
                Pos = Pos - Kobia;
            }
            Console.WriteLine(Pos);
        }

        public static int[] T10_22(int[] arr)
            // 11111בקוד בא ערכי האיבר יהיו אם המערך לדוגמה 12345 אז הוא יהפוך ל
        {
            int temp = arr[arr.Length - 1];
            for (int i = arr.Length-2; i > 0; i--)
            {
                arr[i + 1] = arr[i]; 
            }
            arr[0] = temp;
            return arr;
        }

        public static void T10_23()
        {
            int num;
            num = int.Parse(Console.ReadLine());
            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter your name");
                arr[i] = Console.ReadLine();
            }

            for (int min = 20; min < 75; min += 20)
            {
                string temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = temp;
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Targil10_23B()
        {
            Console.WriteLine("Enter number of girls");
            int Gnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of boys");
            int Bnum = int.Parse(Console.ReadLine());
            int num = 4 + Gnum + Bnum;
            string[] arr = new string[num];
            string[] arr2 = new string[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the name of traveler number" + i);
                arr[i] = Console.ReadLine();
            }
            for (int k = 0; k < num; k++)
            {
                arr2[k] = arr[k];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = Gnum + 1; j < num - 3; j++)
                {
                    if (j != num - 4)
                    {
                        arr2[j] = arr[j + 1];
                    }
                    else
                    {
                        arr2[j] = arr[Gnum + 1];
                    }
                }
                for (int k = 0; k < num; k++)
                {
                    arr[k] = arr2[k];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int[] T10_24(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }
            return arr;
        }


    }
}


    
