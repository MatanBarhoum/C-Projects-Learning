using System;
using System.Collections.Generic;
using System.Text;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfWeek(0));
            Console.ReadLine();
        }

        static string DayOfWeek(int DayNum)
        {
            string DayOfTheWeek;

            switch (DayNum)
            {
                case 0:
                    DayOfTheWeek = "Sunday";
                    break;
                case 1:
                    DayOfTheWeek = "Monday";
                    break;
                case 2:
                    DayOfTheWeek = "Tuesday";
                    break;
                case 3:
                    DayOfTheWeek = "Wednesday";
                    break;
                case 4:
                    DayOfTheWeek = "Thursday";
                    break;
                case 5:
                    DayOfTheWeek = "Friday";
                    break;
                case 6:
                    DayOfTheWeek = "Saturday";
                    break;
                default:
                    DayOfTheWeek = "Invalid Day";
                    break;

            }
            return DayOfTheWeek;
        }
    }
}
