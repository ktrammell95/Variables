using System;

namespace Variables
{
    class Program
    {

        static void NameMethod()
        {
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"It is nice meeting you, {userName}");
        }
        static void NumbersMethod()
        {
            Console.Write("Please enter a number: ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Please enter another number: ");
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"Numbers given: {firstNumberAsString} and {secondNumberAsString}");

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            Console.WriteLine($"Numbers converted are: {firstOperand} and {secondOperand}");

            Console.WriteLine("\n");

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"{sum}");
            Console.WriteLine($"{difference}");
            Console.WriteLine($"{product}");
            Console.WriteLine($"{quotient}");
            Console.WriteLine($"{remainder}");
            Console.WriteLine("\n");

            Console.WriteLine($"If you add {firstOperand} and {secondOperand} you get {sum}");
            Console.WriteLine($"If you subtract {secondOperand} from {firstOperand} you get {difference}");
            Console.WriteLine($"If you multiply {firstOperand} and {secondOperand} you get {product}");
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} you get {quotient}");
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} the remainder is {remainder}");
        }

        static void GreetingMethod()
        {
            Console.Write("What is your first name? ");
            var firstName = Console.ReadLine();
            if (firstName == "Alice")
            {
                Console.WriteLine("Alice! It is so great to meet you!");
            }
            else
            {
                Console.WriteLine($"It is nice meeting you, {firstName}");
            }
        }
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 3;
            var fullName = "Katherine Trammell";

            var rightNow = DateTime.Now;
            var currentMonth = rightNow.Month;
            var currentDay = rightNow.Day;
            var currentYear = rightNow.Year;

            Console.WriteLine($"{numberOfCupsOfCoffee} {fullName} {currentMonth}/{currentDay}/{currentYear}");
            Console.WriteLine("\n");

            NameMethod();
            Console.WriteLine("\n");

            NumbersMethod();
            Console.WriteLine("\n");

            GreetingMethod();
        }

    }
}
