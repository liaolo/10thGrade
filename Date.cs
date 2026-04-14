using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _9thGrade
{
    public class Date
    {
        public static void UnitTest()
        {
            Date d1 = new Date(15, 8, 2023);
            Console.WriteLine(d1);
            d1.SetDay(16);
            Console.WriteLine(d1.GetDay());
            d1.SetMonth(9);
            Console.WriteLine(d1.GetMonth());
            d1.SetYear(2024);
            Console.WriteLine(d1.GetYear());
            Console.WriteLine(d1);
            Date d2 = new Date();
            Console.WriteLine(d2);
            d1.CompareTo(d2);
            Console.WriteLine(d1.CompareTo(d2));
        }
        
        private int Day;
        private int Month;
        private int Year;

        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }

        public Date() : this(DateTime.Now.Day, DateTime.Now.Month,DateTime.Now.Year) { }

        public Date(Date D) : this(D.Day, D.Month, D.Year) { }

        public int SetDay(int Day)
        {
            this.Day = Day;
            return this.Day;
        }

        public int GetDay()
        {
            return this.Day;
        }

        public int SetMonth(int Month)
        {
            this.Month = Month;
            return this.Month;
        }

        public int GetMonth()
        {
            return this.Month;
        }

        public int SetYear(int Year)
        {
            this.Year = Year;
            return this.Year;
        }

        public int GetYear()
        {
            return this.Year;
        }

        public int CompareTo(Date Other)
        {
           if (this.Year > Other.Year)
           {
                return this.Year - Other.Year;
           }
           if (this.Year < Other.Year)
           {
                return this.Year-Other.Year;
           }
           else
           {
                return this.Year - Other.Year;
           }
        }

        public static bool leapYear(int year)
        {
            bool B = false;
            if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
            {
                B = true;
            }
            return B;
        }

        public override string ToString()
        {
              return $"{Day}.{Month}.{Year}";
        }
    }
}
