using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double startprice = 10.20;
            const double kmprice = 1.30;
            const double suitcaseprice = 2;
            const double extrappl = 5;

            int people;
            int suitcases;
            double km;
            double finalprice;

            Console.WriteLine("Taxi Calculator v1.0 Alpha\n");
            Console.Write("How many people? ");
            people = int.Parse(Console.ReadLine());
            Console.Write("how many suitcases? ");
            suitcases = int.Parse(Console.ReadLine());
            Console.Write("how many kilometers? ");
            km = double.Parse(Console.ReadLine());

            if (people > 2) // if more than 2 person, an extra people fee should be calculated. else it shouldn't.
            {
                
                finalprice = (kmprice * km) + ((people -2) * extrappl) + (suitcases * suitcaseprice) + startprice;
            }

            else
            {
                finalprice = (kmprice * km) + (suitcases * suitcaseprice) + startprice;
            }

            Console.WriteLine(string.Format("Your trip is {0}km, you are {1} persons, you took {2} suitcases\nThe total trip price is: {3} ILS\nEnjoy your trip! :)", km, people, suitcases, finalprice));
            Console.ReadLine();
            
        }
    }
}
