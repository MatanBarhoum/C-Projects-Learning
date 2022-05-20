using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"home", "programming", "victory", "C#", "football", "sport", "book", "learn", "dream", "fun" };

            string letter = Console.ReadLine();
            int count = 0;

            foreach (var word in words)
            {
                if (word.Contains(letter))
                {
                    count++;
                    Console.WriteLine(word);
                }   
            }
            if (count == 0)
            {
                Console.WriteLine("No Match");
            }
            Console.ReadLine();
        }
    }
}
