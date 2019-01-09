using System;

namespace numberguess
{
    class Program
    {
        static void Main(string[] args)
        {

            int computerChoice;
            Console.WriteLine("Let us play a game");
            Random rnd = new Random();
            computerChoice = rnd.Next(1, 101);
            Console.WriteLine("Guess a number between 1 and 100");
            int guess;
            bool won = false;
            while (!won)
            {
                if (Int32.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == computerChoice)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("The computer chose" + " " + computerChoice);
                        won = true;
                    }
                    else if (guess > computerChoice)
                    {
                        Console.WriteLine("Too high. Guess again.");
                    }
                    else
                    {
                        Console.WriteLine("Too low. Guess again.");
                    }
                }

                else
                {
                    Console.WriteLine("Not a number. Guess with a number.");
                }
            }


        }
    }
}
