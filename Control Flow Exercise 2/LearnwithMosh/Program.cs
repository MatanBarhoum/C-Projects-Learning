using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class Program
    {
        public static int num1;
        public static int num2;
        public static string userdesicion;
        public static void Main(string[] args)
        {
            while (GamePower.istrue)
            {
                Console.WriteLine("Give me 2 numbers and I will tell you which bigger!");
                Console.Write("Enter a number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                ReturnIf.WhichHigher(num1, num2);
                Console.Write("Do you want to continue? y/n ");
                userdesicion = Console.ReadLine();
                GamePower.GameSwitcher();
            }
        }
    }
}
