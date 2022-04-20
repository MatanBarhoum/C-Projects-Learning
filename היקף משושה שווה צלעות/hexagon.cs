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

            Console.Write("Size of hexagon a: ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("The turle has moved a distance of {0} ", size * 6));
            Console.ReadLine();
        }
    }
}
