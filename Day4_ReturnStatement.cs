using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_true = true;
            while (is_true) {
            Console.Write("Enter a number to Square: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + Calc(num) ) ;
            Console.Write("Do you want to calculate another number ? y/n ");
            string yes_no = Console.ReadLine().ToLower();
            if (yes_no == "y")
                {
                    is_true = true;
                }
                if (yes_no == "n")
                {
                    is_true = false;
                }
        }

    }

        static int Calc(int num)
        {
            int cube = num * num;
            return cube;
        }


    }
}
