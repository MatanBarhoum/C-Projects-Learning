using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PascalConvertor("I have pop"));
            Console.ReadLine();
        }

        public static string PascalConvertor(string str)
        {
            var newString = "";
            foreach (var word in str.Split(' '))
            {
                var PascalConvert = char.ToUpper(word[0]) + word.Substring(1);
                newString += PascalConvert;
            }
            return newString;
        } 

    }
}
