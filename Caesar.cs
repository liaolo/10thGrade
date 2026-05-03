namespace _10thGrade
{
    internal class Caesar
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Encryption("bcd", 2));
            //Console.WriteLine(Dencryption("bcd", 2));
            //Console.WriteLine(Encryption2("Hello"));
            //Console.WriteLine(Encryption2("eHllo "));
        }

        public static char Plus(char L)
        {
            if (L >= 'A' && L <= 'Z' || L >= 'a' && L <= 'z')
            {
                if (L == 'Z')
                {
                    L = 'A';
                }
                else if (L == 'z')
                {
                    L = 'a';
                }
                else
                    L = (char)(L + 1);
            }
            return L;
        }


        public static string Encryption(string s, int key)
        {
            string str = "";
            key = key % 26;
            for (int j = 0; j < s.Length; j++)
            {
                char a = s[j];
                for (int i = 0; i < key; i++)
                {
                    a = Caesar.Plus(a);
                }
                str += a;
            }
            return str;
        }

        public static char dePlus(char L)
        {
            if (L >= 'A' && L <= 'Z' || L >= 'a' && L <= 'z')
            {
                if (L == 'Z')
                {
                    L = 'a';
                }
                else if (L == 'a')
                {
                    L = 'z';
                }
                else
                    L = (char)(L - 1);
            }
            return L;
        }

        public static string Dencryption(string s, int key)
        {
            string str = "";
            key = key % 26;
            for (int j = 0; j < s.Length; j++)
            {
                char a = s[j];
                for (int i = 0; i < key; i++)
                {
                    a = Caesar.dePlus(a);
                }
                str += a;
            }
            return str;
        }

        public static string Encryption2(string s)
        {
            string str = "";

            for (int i = 0; i < s.Length - 1; i += 2)
            {
                str += s[i + 1].ToString() + s[i].ToString();
            }
            if (s.Length % 2 != 0)
            {
                str += s[s.Length-1];
            }
            return str;
        }

        public static string Dencryption2(string s)
        {
            string str = "";

            for (int i = 0; i < s.Length - 1; i += 2)
            {
                str += s[i].ToString() + s[i+1].ToString();
            }
            if (s.Length % 2 != 0)
            {
                str += s[s.Length - 1];
            }
            return str;
        }

    }
}