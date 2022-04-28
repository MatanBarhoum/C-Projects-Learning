using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class exercise3
    {

        static void Main()
        {
            var friendslist = new List<string> { };
            string friendName;
            do 
            {
                Console.Write("Enter a friend name: ");
                friendName = Console.ReadLine();
                if (string.IsNullOrEmpty(friendName)) { break; }
                friendslist.Add(friendName);
            }
            while (!string.IsNullOrEmpty(friendName));

            if (friendslist.Count == 0) { Console.WriteLine("None liked your post."); }
            if (friendslist.Count == 1) { Console.WriteLine(String.Format("{0} liked your post.", friendslist[0])); }
            if (friendslist.Count == 2) { Console.WriteLine(String.Format("{0} and {1} liked your post", friendslist[0], friendslist[1])); }
            if (friendslist.Count >= 3) { Console.WriteLine(String.Format("{0}, {1} and {2} others liked your post", friendslist[0], friendslist[1], friendslist.Count - 2)); }
            Console.ReadLine();
        }
        
    }
} 

