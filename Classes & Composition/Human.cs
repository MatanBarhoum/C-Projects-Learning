using System;

namespace ConsoleApp36
{
    public class Human
    {
        public void Introduction(string name, int age)
        {
            if (age == 0)
            {
                Console.WriteLine("Hello, My name is {0}", name);
            }
            else
            {
                Console.WriteLine("Hello, My name is {0} and my age is {1}", name, age);
            }
        }
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }

        public void Swim(int x, int y)
        {
            Console.WriteLine("I am swimming to {0}, {1} on the map!", x, y);
        }

        public void CountToThree()
        {
            Console.WriteLine("3 ... 2 ... 1 ...");
        }

        public void Decision(string idea1, string idea2)
        {
            Random random = new Random();
            var rnd = random.Next(1, 3);
            Console.WriteLine("What should I pick? {0} or {1}?", idea1, idea2);
            if (rnd == 2)
            {
                Console.WriteLine("I'll pick " + idea2);
            } else
            {
                Console.WriteLine("I'll pick " + idea1);
            }
        }

        public void TeachABC()
        {
            Console.WriteLine("A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z");
        }

        public void FavFood(string food)
        {
            Console.WriteLine("My Favourite food is " + food);
        }
    }
}
