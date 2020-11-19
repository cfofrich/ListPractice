using System;
using System.Collections.Generic;


namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who liked your post? >> ");

            List<string> userInput = new List<string>();
            var input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                userInput.Add(input);
                input = Console.ReadLine();

            }


            if (userInput.Count == 1)
            {
                Console.WriteLine(userInput[0] + " liked your post.");
            }

            else if (userInput.Count == 2)
            {
                Console.WriteLine(userInput[0] + " and " + userInput[1] + " liked your post.");
            }
            
            else if (userInput.Count > 2)
            {
                Console.WriteLine(userInput[0] + ", " + userInput[1] + " " + $"and {userInput.Count - 2} others liked your post");
            }

            else
            {
                Console.WriteLine("No one liked your post");
            }


        }
    }
}
