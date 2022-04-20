using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.Write("Size of triangle a: ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("The size of the triangle is {0}", size * 3));
            Console.ReadLine();
        }
    }
}
