/*
 Завдання 4. 
 Дано речення. Знайти найдовше та найкоротше слово. Знайти перше по алфавіту та останнє за алфавітом
(без врахування регістру букв!).
(Split, String.Compare)
 */


using System;

namespace _04_long_short_first_last_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "That handsome man standing with his back to the track has a hat in his hand.";
            Console.WriteLine(str);
            string[] words;
            words = str.Split(" ,.?!:;-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string shrtWord = words[0];
            string lngWord = words[0];
            string frstWord = words[0];
            string lstWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length <= shrtWord.Length)
                    shrtWord = words[i];
                if (words[i].Length >= lngWord.Length)
                    lngWord = words[i];
                if (words[i].CompareTo(frstWord) == -1)
                    frstWord = words[i];
                if (words[i].CompareTo(lstWord) == 1)
                    lstWord = words[i];
            }
            Console.WriteLine($"\n\tBy Length\nShort word:\t{shrtWord}\nLong word:\t{lngWord}");
            Console.WriteLine($"\n\tBy Alphabeth\nFirst word:\t{frstWord}\nLast word:\t{lstWord}\n");
        }
    }
}
