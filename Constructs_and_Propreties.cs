using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Names
    {
        public Names()
        {
            Console.WriteLine("Welcome!!");
        }
        public string name { get; set; }
        public int age { get; set; }
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Your name: ");
            name = Console.ReadLine();
            Console.Write("Your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            var username = new Names();
            username.name = name;
            username.age = age;

            Console.WriteLine("Your name is {0} and your age is {1}", username.name, username.age);
            Console.ReadLine();
            

        }
    }
}
