using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            //Console.WriteLine(Targil4("Alice", "Bob"));//
            //Console.WriteLine(Targil5("Hello"));//
            //Console.WriteLine(Targil6b('c', "I need coco"));//
            //Console.WriteLine(MyFuncs.Targil8("Liam",'a'));
            //Console.WriteLine(MyFuncs.Targil9("the","th"));
            //Console.WriteLine(MyFuncs.Targil10("char c","c"));
            //Console.WriteLine(MyFuncs.Targil11("str",2));
            //Console.WriteLine(MyFuncs.Targil12("Liam",1));
            //Console.WriteLine(MyFuncs.Targil13("Mazuz",3));
            //Console.WriteLine(MyFuncs.Targil14("Li","am"));
            //Console.WriteLine(MyFuncs.Targil15("ma","m"));
            //Console.WriteLine(test3("Application", "Apple")); // צפוי: 4 (Appl)
            //Console.WriteLine(test3("Apple", "Application")); // צפוי: 4
            //Console.WriteLine(test3("Banana", "Band"));       // צפוי: 2 (Ba)
            //string[] words = { "Application", "App", "Apple", "Banana" };
            //Console.WriteLine(test4(words, "Apple")); // צפוי: 5 (Apple מול Apple) או 4 אם אין "Apple" במערך
            int[] arr = { 2, 1, 0, 1, 0, 2, 1, 0, 1 };
            Console.WriteLine(test2(arr));




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

        public static bool Targil2(string s, string b)
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
                    a = true;
                }
            }
            return a;
        }


        public static string Targil4(string name, string nameb)
        {
            string body;
            Console.WriteLine("Enter your note");
            body = Console.ReadLine();
            return "Hello " + name + " " + body + " " + "Best Regards " + nameb;
        }

        public static string Targil5(String s)
        {
            string a = "";
            for (int j = s.Length - 1; j >= 0; j--)
            {
                a += s[j];
            }
            return a;
        }

        public static char Targil6(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - ('a' - 'A'));
            }
            return c;
        }

        public static int Targil6b(char c, string s)
        {
            int count = 0;
            for (int i = 0; i <= s.Length-1; i++)
            {
                if (s[i] == c )
                {
                    count++;
                }
               
            }
            Console.WriteLine ("The amount of times " + c + "has shown up in the sentnce is ");
            return count++;
        }

        public static int Targil8(string str, char c)
        {

            int num = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    num = i + 1;
                    return num;
                }
            }
            return num;
        }
        public static bool Targil9(string str, string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (str[i] != s[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Targil10(string str, string s)
        {
            int num = str.Length - s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if ((str[i + num] != s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static string Targil11(string str, int k)
        {
            if (k > str.Length - 1 || k < 0)
            {
                return "";
            }
            else
            {
                string s = "";
                for (int i = 0; i <= k; i++)
                {
                    s += str[i];
                }
                return s;

            }
        }
        public static string Targil12(string str, int k)
        {
            if (k > str.Length - 1 || k < 0)
            {
                return "";
            }
            else
            {
                string s = "";
                for (int i = k; i < str.Length; i++)
                {
                    s += str[i];
                }
                return s;
            }
        }
        public static bool Targil13(string str, string s)
        {
            bool b = false;
            for (int i = 0; i < str.Length - s.Length; i++)
            {
                b = true;
                for (int k = 0; k < s.Length; k++)
                {
                    if (str[i + k] != s[k])
                    {
                        b = false;
                        break;
                    }

                }
                if (b)
                {
                    return true;
                }
            }
            return false;
        }
        public static char ezer(char c)
        {
            int a = 'a' - 'A';
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - a);
            }
            return c;

        }
        public static string Targil14(string str, string s)
        {
            string a = "";
            for (int i = 0; i < str.Length; i++)
            { a += ezer(str[i]); }
            string b = "";
            for (int i = 0; i < s.Length; i++)
            { b += ezer(s[i]); }
            int num = Math.Min(a.Length, b.Length);
            for (int i = 0; i < num; i++)
            {
                if (a[i] < b[i])
                {
                    return s;
                }
                if ((a[i] > b[i]))
                {
                    return str;
                }
            }
            if (a.Length > b.Length)
            {
                return str;
            }
            if (a.Length < b.Length)
            {
                return s;
            }
            return str;
        }
        public static int Targil15(string str, string s)
        {
            if (str == s)
            {
                return 0;
            }
            if (Targil14(str, s) == str)
            {
                return 1;
            }
            return -1;

        }

        public static int  test3(string s, string s2) //Application Apple
        {
            int count = 0;
            if (s.Length < s2.Length)
            {
                string temp = s;
                s = s2;
                s2 = temp;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] == s[i])
                {
                    count++;
                }
            }
            return count;
        }

        public static int test4(string [] s, string target) //Appleication Apple
        {
            int[] arr = new int[s.Length];
            for(int i=0; i<s.Length-1; i++)
            {
                arr[i] = test3(s[i], target);
            }
            int max = 0;
            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int test2(int[] arr)
        {
            int count = 0;
            for(int i = 0; i<arr.Length-2; i++)
            {
                if (arr[i] < arr[i+1] && arr[i+2] < arr[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

    }
}
    
