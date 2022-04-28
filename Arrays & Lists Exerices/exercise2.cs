using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class exercise3
    {

        static void Main()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            var last_name = Console.ReadLine();
            string[] ArrayName = new string[2] { name, last_name };
            Array.Reverse(ArrayName);
            foreach (var i in ArrayName)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        
    }
} 

