using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter text:");
            string text = Console.ReadLine();
            int words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Number of words: {words}");
        }
    }
}
