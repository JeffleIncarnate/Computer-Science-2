using System;
using System.Diagnostics;

namespace CompSci
{
    internal static class PartOne
    {
        public static void ProblemOne()
        {
            Console.Write("How many lollies do you have? ");
            int lollies = Convert.ToInt16(Console.ReadLine());

            Console.Write("How many students are there? ");
            int students = Convert.ToInt16(Console.ReadLine());

            float divide = MathF.Floor(lollies / students);
            double leftOver = lollies % students;

            Console.WriteLine($"Give each student {divide} lollies and there should be {leftOver} lollies left over.");
        }

        public static void ProblemTwo()
        {
            Console.Write("How many NZD do you have? ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the NZD to USD exchange rate? ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(amount);
            Console.WriteLine(rate);

            float exchanged = MathF.Round((float)(amount * rate), 2);

            Console.WriteLine($"NZD: ${amount}");
            Console.WriteLine($"Exchange Rate: {rate}");
            Console.WriteLine($"USD: ${exchanged}");
        }

        public static void ProblemThreeOne()
        {
            Console.Write("Team Name: ");
            string? name = "e";

            Console.Write("How many tries did you score? ");
            int tries = 4 * 5;

            Console.Write("How many conversions did you score? ");
            int conversions = 2 * 2;

            Console.Write("How many penalties did you score? ");
            int penalties = 3 * 3;

            Console.WriteLine($"The {name} scored {tries + conversions + penalties} points today.");
        }

        public static void ProblemFour()
        {
            Console.Write("Enter first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int numThree = Convert.ToInt32(Console.ReadLine());

            int[] ints = { numOne, numTwo, numThree };

            Array.Sort(ints);

            Console.WriteLine(string.Join(", ", ints.Select(x => x.ToString()).ToArray()));
        }

        public static void ProblemFive()
        {
            Console.Write("Enter your fullname: ");
            string[] names = Console.ReadLine()!.ToUpper().Split(' ');
            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($"Last name: {names[1]}");
        }

        public static void Test()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            int[]? ints2 = new int[10];

            Array.Copy(ints, ints2, ints.Length);
            Array.Reverse(ints2);

            foreach (int i in ints)
                Console.WriteLine(i);

            foreach (int i in ints2)
                Console.WriteLine(i);
        }
    }
}