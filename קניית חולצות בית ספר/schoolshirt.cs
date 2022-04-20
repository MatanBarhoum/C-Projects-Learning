using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double shirt = 20;
            const double logo = 2;
            int num;
            double price;

            Console.Write("How many shirts do you want to buy? ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("You bought {0} school shirts with logo, you'll need to pay {1} NIS", num, price = (num * shirt) + (num * logo)));
            Console.ReadLine();

        }
    }
}
