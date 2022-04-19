using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSpeedLimit
{
    public static class Program
    {
        public static int speed_limit;
        public static int car_speed;
        public static string userinput;
        public static void Main(string[] args)
        {
            while (PowerSource.istrue)
            {
                Console.WriteLine("Speed Limit Calculator - Alpha v1.0\n");
                Console.Write("enter speed limit: ");
                speed_limit = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter car speed: ");
                car_speed = Convert.ToInt32(Console.ReadLine());

                Calculator.Speed_Calculator(speed_limit, car_speed);

                Console.Write("\nDo you want to check again? y/n\n".ToLower());
                userinput = Console.ReadLine();

                PowerSource.Power();
            }
        }
    }
}
