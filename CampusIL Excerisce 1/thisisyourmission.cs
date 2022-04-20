using System;
using System.Collections.Generic;
using System.Text;

namespace CampusIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname ;
            string lastname ;

            Console.Write("first name: ");
            firstname = Console.ReadLine();

            Console.Write("last name: ");
            lastname = Console.ReadLine();

            Console.Write(string.Format("Good morning {0} {1}, this is your mission, should you accept it.", firstname, lastname));
            Console.ReadLine();

        }
    }
}
