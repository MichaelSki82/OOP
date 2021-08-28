using System;

namespace Lesson7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The best from the best";
            char c = 't';
            int i = s.CountElement(c);

            Console.WriteLine(i);

            Console.Read();
        }
    }

    public static class String
    {
        public static int CountElement(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                    counter++;
            }
            return counter;
        }
    }
}