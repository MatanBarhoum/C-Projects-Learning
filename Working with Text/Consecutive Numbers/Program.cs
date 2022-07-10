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
            Program program = new Program();
            Console.Write("Enter a number sequence with a hypen (5-6-7 etc): ");
            string str = Console.ReadLine();
            if (program.Con(str) == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
            Console.ReadLine();
        }

        public bool Con(string str)
        {
            string newString = str.Replace("-", "");
            for (int i = 0; i < newString.Length - 1; i++)
            {
                if (Convert.ToInt32(newString[i]) + 1 != Convert.ToInt32(newString[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
