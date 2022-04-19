using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            
            Console.Write("First name: ");
            firstname = Console.ReadLine();
            Console.Write("last name: ");
            lastname = Console.ReadLine();
            string Demo = string.Format("{0} {1}", firstname, lastname);
            Console.WriteLine(Demo);
            Console.ReadLine();
        }
    }
}
