using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class Caesar
    {
        public static void UnitTest()
        {
            Console.WriteLine(Plus('M'));
        }

        public static char Plus(char L)
        {
            if (L >= 'A' && L <= 'Z' || L >= 'a' && L <= 'z')
            {
                if (L == 'Z')
                {
                    L = (char)(L - 25);
                }
                else if (L == 'z')
                {
                    L = (char)(L - 25);
                }
                else
                    L=(char)(L + 1);
            }
            return L;
        }

        public static string Encryption (string s, int key)
        {
            char a='a';
            for(int j=0; j<s.Length; j++)
            {
                for (int i = 0; i < ; i++)
                {
                    a = Plus(s[i]);
                }
            }
        }


    }
}
