using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price;
            char ils = '₪';
            Console.Write("Product price: ILS ");
            price = Convert.ToInt32(Console.ReadLine());
            double finalprice = (price * 0.17) + price;
            Console.WriteLine(String.Format("The price after 17% tax is {0}", finalprice));
            Console.ReadLine();

        }
    }
}
