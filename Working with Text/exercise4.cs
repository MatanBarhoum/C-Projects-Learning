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
            Console.Write("Enter a word: ");
            var text = Console.ReadLine().ToLower();
            Console.WriteLine(text);

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            text = textInfo.ToTitleCase(text).Replace(" ", string.Empty);

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
