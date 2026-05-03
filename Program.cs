using Yod;

namespace _10thGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NesttedLoops.UnitTest();
            //StringPractice.UnitTest();
            //Caesar.UnitTest();
            //ArraysPractice.UnitTest();
            //ArraysPractice2.UnitTest();
            //ClassPractice.UnitTests();
            //Point.UnitTests();
            //Date.UnitTest();
            //Parabula.UnitTests();


        
            int[,] a = new int[3, 4];
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    Console.Write(a[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
