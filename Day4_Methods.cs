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
            string name;
            double age;
            Console.Write("Full name: ");
            name = Console.ReadLine();
            Console.Write("Your age: ");
            age = Convert.ToDouble(Console.ReadLine());
            SayHi(name, age);
            Console.ReadLine();

        }

        static void SayHi(string name, double age)
        {
            Console.WriteLine("Hello " + name + "," + " Your age is " + age);
        }

    }
}
