using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class ArraysPractice3
    {
        public static void UnitTest()
        {

        }

        public static void T1()
        {
            int NumOfStudents,num;
            Console.WriteLine("Enter number of students");
            NumOfStudents = int.Parse(Console.ReadLine());
            int[] Grade1 = new int[NumOfStudents];
            int[] Grade2 = new int[NumOfStudents];
            int[] FinalGrade = new int[NumOfStudents];
            for(int i=0; i<NumOfStudents; i++)
            {
                Console.WriteLine("Enter your first grade");
                num = int.Parse(Console.ReadLine());
                Grade1[i] = num;
                Console.WriteLine("Enter your second grade");
                num = int.Parse(Console.ReadLine());
                Grade2[i] = num;
                FinalGrade[i] = Math.Max(Grade1[i], Grade2[i]);
            }
            for (int i = 0; i < NumOfStudents; i++)
            {
                Console.WriteLine("Your first grade is " + Grade1[i]);
                Console.WriteLine("Your second grade is " + Grade2[i]);
                Console.WriteLine("Your final grade is " + FinalGrade[i]);
                Console.WriteLine("Next student");
            }
        }
    }
}
