using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class exercise3
    {

        static void Main()
        {
            while (true)
            {
                var numbers = new List<int>();
                Console.Write("enter numbers with comma: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Invalid List. re-try.\n");
                    continue;
                }

                foreach (var i in input.Split(','))
                {
                    numbers.Add(Convert.ToInt32(i));
                }

                if (numbers.Count < 5)
                {
                    Console.Write("Invalid List. re-try.\n");
                    continue;
                }

                numbers.Sort();
                var newNumbers = numbers.Count - 3;
                numbers.RemoveRange(3, newNumbers);
                foreach (var i in numbers)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }
    }
}

