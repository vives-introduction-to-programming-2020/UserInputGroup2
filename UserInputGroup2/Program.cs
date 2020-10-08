using System;

namespace UserInputGroup2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Wow, my name is also " + name);

            Console.Write("Please enter your age: ");
            string userInput = Console.ReadLine();
            int age = Convert.ToInt32(userInput);

            Console.WriteLine(age + " Damn that is almost old.");

            Console.Write("Please enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(height + " is quite normal");

            // Random values
            Random generator = new Random();

            int randomNumber = generator.Next();
            Console.WriteLine(randomNumber);

            int dieThrow = generator.Next(1, 7);
            Console.WriteLine(dieThrow);

            int secretNumber = generator.Next(20);
            Console.WriteLine(secretNumber);

        }
    }
}
