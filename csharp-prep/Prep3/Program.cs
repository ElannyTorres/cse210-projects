using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess My Number!");
        Random randomGenerator = new Random();
        string play = "yes";
        int number = randomGenerator.Next(1, 101);
        int numGuess = -1;
        int tries = 0;

        while (play == "yes")
        {
            do
            {
                tries += 1;
                Console.WriteLine("Enter a number:");
                string guess = Console.ReadLine();
                numGuess = int.Parse(guess);
                if (numGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (numGuess < number)
                {
                    Console.WriteLine("Higher");
                }

            } while (numGuess != number);
            Console.WriteLine("Congratulations! It is the number!");
            Console.WriteLine($"Number of guesses: {tries}");
            Console.WriteLine("Keep playing?");
            play = Console.ReadLine();
        }

    }
}