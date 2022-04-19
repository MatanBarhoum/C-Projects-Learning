using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class Program
    {
        public static int width;
        public static int height;
        public static void Main(string[] args)
        {
            Console.WriteLine("Portrait or Landscape Calculator");

            Console.Write("Width of the image: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height of the image: ");
            height = Convert.ToInt32(Console.ReadLine());

            Calculator.PortOrLand();

        }
    }
}
