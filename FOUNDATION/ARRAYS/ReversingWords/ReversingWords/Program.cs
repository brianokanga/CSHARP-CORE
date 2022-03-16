using System;

namespace ReversingWords
{
    class Program
    {
        static void Main(string[] args)
        {

            const string s1 = "blue red green";
            const string s2 = "c# rust python";

            string rev1 = ReverseWords(s1);
            Console.WriteLine(rev1);

            string rev2 = ReverseWords(s2);
            Console.WriteLine(rev2);
        }

        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(" ");
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
