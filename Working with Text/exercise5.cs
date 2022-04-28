using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            total = sentence.Count(x => vowels.Contains(x));

            Console.WriteLine("Your total number of vowels is: {0}", total);

            Console.ReadLine();
        }
    }
}
