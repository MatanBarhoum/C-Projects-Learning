using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSpeedLimit
{
    public static class PowerSource
    {
        public static bool istrue = true;
        public static void Power()
        {
            if (Program.userinput == "y") 
            {
                istrue = true;
                Console.Clear();
            }

            else if (Program.userinput == "n")
            {
                istrue = false;
            }

            else
            {
                Console.WriteLine("Invalid input.. closing program...");
                System.Threading.Thread.Sleep(1200);
                istrue = false;
            }
        }
    }
}
