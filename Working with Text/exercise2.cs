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
            var newList = new List<int>();
            Console.Write("Enter a number (example 1-2-3..) : ");
            var input = Console.ReadLine();
            foreach (var i in input.Split('-'))
            {
                newList.Add(Convert.ToInt32(i));
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                Environment.Exit(0);
            }
            var hasDupes = newList.GroupBy(x => x).Any(grp => grp.Count() > 1);
            if (hasDupes == true)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("No Duplicates. ");
            }
            Console.ReadLine();
        }
    }
}
