using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class ReturnIf
    {
        public static void ValidationCheck()
        {
            if (Program.NumberEntered > 0 && Program.NumberEntered <= 10)
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Invalid");
                Console.ReadLine();
            }
        }
    }
}
