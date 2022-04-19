using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSpeedLimit
{
    public static class Calculator
    {
        public enum Levels
        {
            until5 = 1,
            until10 = 2
        }
        public static void Speed_Calculator(int speed_limit, int car_speed)
        {
            if (car_speed > speed_limit)
            {
                var speed = car_speed - speed_limit;

                if (speed >= 5 && speed < 10)
                {
                    
                    Console.WriteLine(string.Format("The car was {0}/kmh over the limit.\n{1} demerit points incurred.", speed, (int)Levels.until5));
                }

                else if (speed >= 10 && speed <= 12)
                {
                    
                    Console.WriteLine(string.Format("The car was {0}/kmh over the limit.\n{1} demerit points incurred.", speed, (int)Levels.until10));
                }

                else if (speed > 12)
                {
                    Console.WriteLine("License Suspended");
                }

                else
                {
                    Console.WriteLine("OK");
                }
            }

        else
            {
                Console.WriteLine("OK");
            }

        }

    }
}
