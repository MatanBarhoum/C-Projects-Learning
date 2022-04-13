using System;
using System.Collections.Generic;
using System.Text;

namespace LearningWithMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Your name: ");
            person.name = Console.ReadLine();
            Console.Write("Your age: ");
            person.age = Convert.ToByte(Console.ReadLine());
            person.Welcome();
            person.personage();
            Console.ReadLine();
        }
    }

    public class person
    {
        public static string name;
        public static byte age;
        
        public static void Welcome()
        {
            Console.WriteLine("Welcome " + name);
            
        }

        public static void personage()
        {
            Console.WriteLine("Your age is " + age);
        }

    }
}
