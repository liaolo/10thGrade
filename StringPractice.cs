using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class StringPractice
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Targil1("Hello World from C#", 'c'));//
            //Console.WriteLine(Targil2("Hello World from C#", "Hello World from C"));//
            //Console.WriteLine(Targil3("Hello World from C#", "Hello World from C#"));//
            //Console.WriteLine(Targil6('g'));//
        }

        public static int Targil0(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool Targil1(string s, char c)
        {
            bool b = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    b = true;
                }
            }
            return b;
        }

        public static bool Targil2 (string s, string b)
        {
            bool a = false;
            if (s.Length == b.Length)
            {
                a = true;
            }
            return a;
        }

        public static bool Targil3(string s, string b)
        {
            bool a = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length == b.Length && s[i] == b[i])
                {
                   a=true;
                }  
            }
            return a;
        }

        public static char Targil6(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - 32);
            }
            return c;
        }
           
    }
}
