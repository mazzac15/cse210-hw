using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();  
        
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1,101);
            
            int guessCount = 0;

        
            int userGuess = -1;
        
            while (userGuess != magicNumber)
            {   
                guessCount = guessCount +1;

                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Guess lower next time.");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Guess higher next time.");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }    
    }
}