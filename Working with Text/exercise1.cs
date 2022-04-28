using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class exercise3
    {

        static void Main()
        {
            var numbers = new List<int>();
            var result = 0;
            Console.WriteLine("Enter number with hypen (1-2-3..) : ");
            var input = Console.ReadLine();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
                Console.WriteLine(number);
            }

            for (var i = 0; numbers.Count > i+1; i++)
            {
                if (numbers[i] + 1 == numbers[i+1] )
                {
                    result = 1;
                    
                }
                else
                {
                    result = 2;
                }
            }

            if (result == 1)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
}

