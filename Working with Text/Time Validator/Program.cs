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
            Console.Write("Enter a time (19:45 etc..): ");
            var time = Console.ReadLine();
            DateTimeValidator(time);
            Console.ReadLine();
        }

        public static void DateTimeValidator(string str)
        {
            // 19:53 become 1953 % 100 = 53 = minutes, and 1953 / 100 = hours
            var newString = str.Replace(":", "");
            var stringToInt = Convert.ToInt32(newString);
            if (stringToInt % 100 <= 59 && stringToInt / 100 <= 23)
            {
                Console.WriteLine("Valid");
            }
            else { Console.WriteLine("Not Valid"); }
        } 

    }
}
