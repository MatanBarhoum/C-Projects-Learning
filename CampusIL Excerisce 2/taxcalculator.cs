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

            Console.Write("Enter the proudct price: ");
            price = double.Parse(Console.ReadLine());
            totalprice = (price * 0.17) + price;
            

            Console.WriteLine("The total price after 17% tax is {0}", Math.Round(totalprice, 2));
            Console.ReadLine();

        }
    }
}
