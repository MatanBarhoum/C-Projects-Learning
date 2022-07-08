using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    public class Matan
    {
        private readonly Human _human;
        public string Name { get; set; }   
        public int Age { get; set; }

        public Matan(Human human, string name, int age)
        {
            _human = human;
            this.Name = name;
            this.Age = age;
        }

        public Matan(Human human, string name)
        {
            _human = human;
            this.Name = name;
        }

        public void Introduce()
        {
            _human.Introduction(Name, Age);
        }

        public void Speak(string message)
        {
            _human.Talk(message); 
        }

        public void Swim(int x, int y)
        {
            _human.Swim(x, y);
        }

        public void Decision(string idea1, string idea2)
        {
            _human.Decision(idea1, idea2);
        }

        public void FavFood(string food)
        {
            _human.FavFood(food);
        }
    }
}
