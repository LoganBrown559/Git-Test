using System;

namespace TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 - 100. Guess it!");

            System.Random random = new System.Random();

            int number = random.Next(0, 100);

            int guess = -1;

            int tries = 0;

            Console.Write("What is the number? ");
            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("Too high, silly!");
                    tries++;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low, Joe");
                    tries++;
                }
                else
                {
                    Console.WriteLine("How did you even manage to see this?");
                    tries++;
                }

                Console.Write("What is the number? ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("That didn't take long! Only " + tries + " times! Oh well...");
            Console.WriteLine("Press Enter to finish program");
            Console.ReadLine();

        }
    }
}
