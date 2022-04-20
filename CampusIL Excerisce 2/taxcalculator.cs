using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price;
            double totalprice;
            const double tax = 0.17;

            Console.Write("Enter the proudct price: ");
            price = double.Parse(Console.ReadLine());
            totalprice = (price * tax) + price;
            

            Console.WriteLine("The total price after " + tax + "% tax is {0}", Math.Round(totalprice, 2));
            Console.ReadLine();

        }
    }
}
