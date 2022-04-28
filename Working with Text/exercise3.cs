using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter time (00:00) : ");
            var input = Console.ReadLine();
            string format = "HH:mm";
            DateTime datevalue;
            if (DateTime.TryParse(input, out datevalue)) 
            {
                Console.WriteLine("Valid Time :)");
                System.Threading.Thread.Sleep(2500);
                Environment.Exit(0);
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                System.Threading.Thread.Sleep(2500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid");
                System.Threading.Thread.Sleep(2500);
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
