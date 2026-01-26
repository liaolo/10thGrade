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

        //public static string[] T10_23b(string[] arrb, string[] arrg)
        //{

        //}

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


    
