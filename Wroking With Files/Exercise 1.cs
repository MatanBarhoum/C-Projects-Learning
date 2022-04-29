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
            Console.WriteLine(String.Format("File legnth: {0}\nFile lines: {1}\nFile contains {2} words", textlength.Count(), textlines.Count(), textwords.Count()));
            Console.ReadLine();
        }
    }
}
