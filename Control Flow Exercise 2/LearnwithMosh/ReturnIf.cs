using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class ReturnIf
    {
        public static void WhichHigher(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(String.Format("{0} is higher", num1));
                
            }

            else
            {
                Console.WriteLine(string.Format("{0} is higher", num2));
                
            }
        }
    }
}
