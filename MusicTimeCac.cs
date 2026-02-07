using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    public class MusicTimeCac
    {

        public string ArtistName;
        public string[] SongName;
        public double[] Duration;
        public double SumDuration;

        public MusicTimeCac(string n, string[] Sn , double[] d)
        {
            ArtistName = n;
            SongName = Sn;
            Duration = d;
        }
        public double CalcDuration()
        {
            SumDuration = 0;
            for(int i=0; i<SongName.Length; i++)
            {
                SumDuration += Duration[i];
            }
            return SumDuration;
        }
        public string CalcL()
        {
            double maxL = 0;
            string MaxN = "";
            for (int i = 0; i < SongName.Length; i++)
            {
                if(Duration[i]>maxL)
                {
                    maxL = Duration[i];
                    MaxN = SongName[i];
                }
            }
            return "Longest song from " + ArtistName + " you have listend to is: " + MaxN + "!" ;
        }

        public string FinalString()
        {
            CalcDuration();
            string s = "";
            s = "You listend to " + SumDuration + " minutes of " + ArtistName + " music";
            int CountTen = 0;
            for (int i=0; i<Duration.Length; i++)
            {
                if (Duration[i]>10)
                {
                    CountTen++;
                }
            }
            if (CountTen > 0)
            {
                Console.WriteLine("You have listend to " + CountTen + " songs longer than 10 mins"!);
                if (CountTen > 5)
                {
                    Console.WriteLine("You really like long songs!");
                }
            }
            return s;
        }
    }
}


