using System;

namespace TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a guessing game. I will ask for a small number, and a bigger number.");
            Console.WriteLine("Once you tell me those, I will think of a number between them. Then you guess that number!");

            Console.Write("The Smaller Number: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now the Bigger Number: ");
            int max = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("I am thinking of a number between " + min + " and " + max + ". Guess it!");

            System.Random random = new System.Random();

            int number = random.Next(min, max);

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
