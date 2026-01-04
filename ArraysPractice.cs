using System;
using System.Collections.Generic;
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
           T10_6();
        }
        public static void T10_6()
        {
            double[] grades=new double[10];
            double avg, sum=0,dist;
            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter your grade:");
                grades[i]=double.Parse(Console.ReadLine());
                sum=sum+grades[i];
            }
            avg =(sum / grades.Length);
            for (int i = 0; i < grades.Length; i++)
            {
                dist = Math.Abs(grades[i] - avg);
                Console.WriteLine("The distance between grade " + grades[i] + " and the average " + avg + " is: " + dist);
            }

        }
    }

}
