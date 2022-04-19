using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class Program
    {
        public static int NumberEntered;
        public static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 - 10: ");
            NumberEntered = Convert.ToInt32(Console.ReadLine());
            ReturnIf.ValidationCheck();
        }
    }
}
