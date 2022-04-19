

using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class Calculator
    {
        public static void PortOrLand()
        {
            if (Program.width > Program.height)
            {
                Console.WriteLine("This image is Landscape");
                Console.ReadLine();
            }

            else if (Program.height > Program.width)
            {
                Console.WriteLine("This image is Portrait");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Sorry, not a landscape nor a portrait.");
                Console.ReadLine();
            }
        }
    }
}
