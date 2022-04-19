using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithMosh
{
    public static class GamePower
    {
        public static bool istrue = true;

        public static void GameSwitcher()
        {
            if (Program.userdesicion == "y")
            {
                istrue = true;
            }

            else if (Program.userdesicion == "n")
            {
                istrue = false;
            }

            else
            {
                Console.WriteLine("Invalid input, restarting game...");
                System.Threading.Thread.Sleep(1200);
            }
        }
    }
}
