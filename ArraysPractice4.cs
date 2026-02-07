using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thGrade
{
    internal class ArraysPractice4
    {
        public static void T1()
        {
            /*
            סעיף א

כדי לדעת איזה שחקן צבר את מספר הנקודות הגדול ביותר, סופרים לכל שחקן בנפרד את סך הנקודות שהוא קלע לאורך המשחק. לאחר סיום הקלט משווים בין הסכומים של כל השחקנים ובודקים למי מהם יש את הסכום הגבוה ביותר. השחקן עם הסכום הגבוה ביותר הוא התשובה.

סעיף ב

כדי לחשב כמה נקודות צברה הקבוצה במשך כל המשחק, מחברים את מספר הנקודות של כל הקליעות שהוזנו בקלט. בסיום הקלט הסכום שהתקבל הוא מספר הנקודות הכולל של הקבוצה.

סעיף ג

כדי למצוא מהו סוג הקליעה הנפוץ ביותר, סופרים כמה פעמים הופיעה קליעה של נקודה אחת, כמה פעמים הופיעה קליעה של שתי נקודות וכמה פעמים הופיעה קליעה של שלוש נקודות. לאחר מכן משווים בין שלושת הספירות וקובעים איזה סוג קליעה הופיע הכי הרבה פעמים.

סעיף ד

כדי לדעת איזה שחקן או שחקנים לא צברו אף נקודה במהלך המשחק, בודקים עבור כל שחקן אם סך הנקודות שלו הוא אפס. כל שחקן שעבורו סכום הנקודות הוא אפס הוא שחקן שלא קלע כלל במהלך המשחק.
            */
        }

        public static void T2()
        {
            int[] arr = new int[8];
            int[] counts = new int[2];
            int element;
            for (int i = 0; i < arr.Length; i++)
            {
                element = arr[i];
                counts[element % 2]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine(counts[i]);
            }
            // א: פלט: 3 5
            // ב: 10 , 70 , 56 , 58 , 34 , 12, 34 , 79 , 97 , 35
            // ג: מטרת התוכנית היא לספור כמה מספרים זוגיים ואי זוגיים יש במערך ואחר כך היא מציגה אותם
        }

        public static void T3()
        {
            int[] counters = new int[26];
            Console.WriteLine("Enter a series of characters ending with *: ");
            string input = Console.ReadLine();

            int i = 0;
            while (i < input.Length && input[i] != '*')
            {
                char ch = input[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    int index = ch - 'a'; //החישוב של סעיף א
                    counters[index]++;
                }

                i++;
            }

            Console.WriteLine("תוצאות:");
            for (i = 0; i < 26; i++)
            {
                char letter = (char)('a' + i);
                Console.WriteLine(letter + ": " + counters[i]);
            }


        }
        public static void T4()
        {
            int[] ageGroups = new int[4];
            int[] drugCounters = new int[150];

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            while (age != -1)
            {
                int drugNumber = int.Parse(Console.ReadLine());
                int amount = int.Parse(Console.ReadLine());

                drugCounters[drugNumber - 1] += amount;

                if (age <= 10)
                    ageGroups[0] += amount;
                else if (age <= 30)
                    ageGroups[1] += amount;
                else if (age <= 50)
                    ageGroups[2] += amount;
                else
                    ageGroups[3] += amount;

                age = int.Parse(Console.ReadLine());
            }

            int max = ageGroups[0];
            for (int i = 1; i < 4; i++)
                if (ageGroups[i] > max)
                    max = ageGroups[i];

            Console.WriteLine("Age groups with the highest consumption:");
            if (ageGroups[0] == max)
                Console.WriteLine("Ages 0–10");
            if (ageGroups[1] == max)
                Console.WriteLine("Ages 11–30");
            if (ageGroups[2] == max)
                Console.WriteLine("Ages 31–50");
            if (ageGroups[3] == max)
                Console.WriteLine("Ages 51 and up");

            Console.WriteLine("Medications not consumed at all: ");
            for (int i = 0; i < 150; i++)
                if (drugCounters[i] == 0)
                    Console.WriteLine(i + 1);
            //ג:תבנית מערך מונה,מערך סכום,מקסימום.
        }

        public static void T5()
        {
            int[] rooms = { 14, 11, 10, 8, -1, 6, -1, 2, 0, 13, 4, -1, 15, 1, 7, 5 };

            int startRoom = 5;
            int currentRoom = startRoom;

            while (rooms[currentRoom] != -1)
            {
                currentRoom = rooms[currentRoom];
            }

            Console.WriteLine(currentRoom);
        }
    }
}
