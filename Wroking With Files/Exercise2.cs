using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\FileRead.txt";
            var textlength = File.ReadAllText(path);
            var textlines = File.ReadAllLines(path);
            string[] textwords = File.ReadAllText(path).Split(' ');
            var biggestWord = "";
            int ctr = 0;
            
            foreach (var word in textwords)
            {
                if (word.Length > ctr)
                {
                    biggestWord = word;
                    ctr = word.Length;
                    Console.WriteLine(biggestWord);
                    Console.WriteLine(ctr);
                }
            }

            Console.WriteLine(biggestWord);
            Console.ReadLine();
        }
    }
}
