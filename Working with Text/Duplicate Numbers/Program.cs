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
            if (duplicate("5-8-7-6-4-7-"))
            {
                Console.WriteLine("Duplicate");
            } else
            {
                Console.WriteLine("Not Duplicate");
            }
            Console.ReadLine();
        }

        public static bool duplicate(string str)
        {
            var newString = str.Replace("-", "");

            for (int i = 0; i <= newString.Length - 1; i++)
            {
                for (int j = 0; j <= newString.Length - 1; j++)
                {
                    if (newString[i] == newString[j] && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
