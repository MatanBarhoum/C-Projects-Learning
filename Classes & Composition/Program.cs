using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp36
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Matan matan = new Matan(human, "Matan");

            matan.Introduce();
            matan.Speak("How are you today?");
            matan.Swim(20, 20);
            matan.Decision("Go to mall", "Go to swimming pool");
            matan.FavFood("Pineapple Pizza");
            Console.ReadLine();
        }
    }
}
