using System;

namespace Lesson7
{
    public static class LinqHelper
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word.Reverse();
            Console.WriteLine(word.Reverse());
        }
        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
    }
}
