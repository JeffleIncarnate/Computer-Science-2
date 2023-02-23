using System;
using System.Diagnostics;

namespace CompSci
{
    internal static class PartTwo
    {
        public static void ProblemA()
        {
            Console.Write("How old are you: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string template = "You can select movies from the following categories: ";
            List<string> things = new List<string>();

            if (age < 13)
            {
                Console.WriteLine("You can not watch movies");
                ProblemA();
            }

            if (age >= 13)
                things.Add("R13");

            if (age >= 16)
                things.Add("R16");

            if (age >= 18)
                things.Add("R18");

            Console.WriteLine($"{template} {String.Join(", ", things.ToArray())}");

            ProblemA();
        }

        public static void ProblemB()
        {
            string[] items = { "apple", "grape", "bacon", "steak", "worm", "dirt" };

            string[] food = { "apple", "grape", "bacon", "steak", };
            string[] notFood = { "worm", "dirt" };

            Random rnd = new Random();
            int num = rnd.Next(1, 6);

            Console.WriteLine($"Chosen Item: {items[num]}");

            if (food.Contains(items[num]))
                Console.WriteLine("Food");

            else if (notFood.Contains(items[num]))
                Console.WriteLine("Not food");

            else
                Console.WriteLine("bad");
        }

        public static void ProblemC()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);

            for (; ; )
            {
                Console.Write("Guess a number (1-10): ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == num)
                {
                    Console.WriteLine("You are right!");
                    break;
                }

                if (userGuess > num)
                    Console.WriteLine("Less");
                else
                    Console.WriteLine("More");

            }
        }

        public static void ProblemD()
        {

        }
    }
}