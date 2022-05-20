using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to factorial: ");
            var result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is {0}", Factorial(result));
            Console.ReadLine();
        }
        static double Factorial(int number)
        {
           if (number == 0)
           {
               return 0;
          }
            return number + Factorial(number - 1);
            
        }
        }
    }

