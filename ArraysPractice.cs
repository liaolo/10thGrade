using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10thGrade
{
    internal class ArraysPractice
    {
        public static void UnitTest()
        {

        }

        public static int[] T11(int P)
        {
            int[] arr = new int[P];
            for (int i=0; i < P; i++)
            {
                Console.WriteLine("Which payilote are you going to");
                int payilote = int.Parse(Console.ReadLine());
                if (payilote == 0)
                {
                    arr[0]++;
                }
                else if (payilote == 1)
                {
                    arr[1]++;
                }
                else if (payilote == 2)
                {
                    arr[2]++;
                }
                else
                {
                    Console.WriteLine("Invalid payilote");
                }
                return arr;
            }
            return arr;
        }

        public static int[] T11_b(int[] P)
        {
            int[] Rooms = new int[P.Length];
            for (int i=0; i < P.Length; i++)
            {
                if(P[i] < 40)
                {
                    Rooms[i]++;
                }
                else
                {
                    Rooms[i] = 2;
                }
            }
            return Rooms;
        }

        public static void T11_C()
        {
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine("How many students are in the class?");
                int N = int.Parse(Console.ReadLine());
            }
            int[] lid = new int [3];
            lid=T11_b(lid);

        }
    }
}
        