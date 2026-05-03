using _10thGrade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Yod
{
    public class ClassPractice
    {
       
        public static void UnitTests()
        {
            //CssGrades student1;
            //student1 = new CssGrades("Josh", 82, 98, 87, 17, 100);

            //int g = student1.Calc371();
            //Console.WriteLine(g);
            //Console.WriteLine(student1.Calc271());
            //Console.WriteLine(student1.Calc3());
            //Console.WriteLine(student1.Has5());
            //Console.WriteLine(student1.Calc5());
            //Console.WriteLine(student1);
            //student1.bagrut271 = 100;
            //Console.WriteLine(student1);



            MusicTimeCac m1;
            string[] songs = { "Yellow", "Fix You", "Coloratura", "Viva La Vida" };
            double[] durations = { 4.29, 4.55, 10.29, 4.02 };
            m1 = new MusicTimeCac("coldplay", songs, durations);

            Console.WriteLine("Artist: " + m1.ArtistName);
            Console.WriteLine(m1.CalcL());
            Console.WriteLine(m1);
        }
        
    }
}