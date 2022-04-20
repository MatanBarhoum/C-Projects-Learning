using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double falafel = 10.90;
            const int drink = 5;
            double total;

            Console.WriteLine("Welcome to Matan's CampusIL falafel store!\n");

            Console.WriteLine(String.Format("You just bought falafel and a drink, you'll have to pay {0} NIS", total = falafel + drink));
            Console.ReadLine();
        }
    }
}
