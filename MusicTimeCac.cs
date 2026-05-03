using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10thGrade
{
    public class MusicTimeCac
    {

        public string ArtistName;
        public string[] SongName;
        public double[] Duration;
        public double SumDuration;

        public MusicTimeCac(string ArtistName, string[] SongName , double[] Duration)
        {
            this.ArtistName = ArtistName;
            this.SongName = SongName;
            this.Duration = Duration;
        }

        public void GetDuration(int Duration)
        {
            for(int i=0; i<this.Duration.Length; i++)
            { 
                if (Duration > 0)
                {
                    this.Duration[i] = Duration;
                }
            }
        }

        public double[] SetDuration()
        {
            return this.Duration;
        }

        public void GetSongName(string SongName)
        {
            for (int i = 0; i < this.SongName.Length; i++)
            {
                if (SongName != "")
                {
                    this.SongName[i] = SongName;
                }
            }
        }

        public string[] SetSongName()
        {
            return this.SongName;
        }

        public void GetArtistName(string ArtistName)
        {
            if (ArtistName != "")
            {
                this.ArtistName = ArtistName;
            }
        }

        public string SetArtistName()
        {
            return this.ArtistName;
        }

        public double CalcDuration()
        {
            this.SumDuration = 0;
            for(int i=0; i<this.SongName.Length; i++)
            {
                this.SumDuration += Duration[i];
            }
            return this.SumDuration;
        }
        public string CalcL()
        {
            double maxL = 0;
            string MaxN = "";
            for (int i = 0; i < SongName.Length; i++)
            {
                if(this.Duration[i]>maxL)
                {
                    maxL = Duration[i];
                    MaxN = SongName[i];
                }
            }
            return "Longest song from " + this.ArtistName + " you have listend to is: " + MaxN + "!" ;
        }
        
        public override string ToString()
        {
            this.CalcDuration();
            string s = "";
            s = "You listend to " + this.SumDuration + " minutes of " + this.ArtistName + " music";
            int CountTen = 0;
            for (int i = 0; i < this.Duration.Length; i++)
            {
                if (this.Duration[i] > 10)
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


