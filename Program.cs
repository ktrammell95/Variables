using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 3;
            var fullName = "Katherine Trammell";

            var rightNow = DateTime.Now;
            var currentMonth = rightNow.Month;
            var currentDay = rightNow.Day;
            var currentYear = rightNow.Year;

            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + currentMonth + "/" + currentDay + "/" + currentYear);
            Console.WriteLine("\n");

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"It is nice meeting you, {userName}");
            Console.WriteLine("\n");

            Console.WriteLine("Please enter a number");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Please enter another number");
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"Numbers given: {firstNumberAsString} and {secondNumberAsString}");


        }
    }
}
