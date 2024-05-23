using CSDiceRollGame.Dices;
using CSDiceRollGame.InputHandler;

namespace CSDiceRollGame
{
    public class Program
    {
        static void Main() 
        {
            Console.WriteLine("Hello, World!");
            Retry retry = new();

            Console.WriteLine("The Dice will Roll and we'll test your luck!");
            int drawnNumber = Dice.Roll();
            Console.WriteLine("The dice was rolled and a number was drawn");

            do
            {
                string usersGuess = Prompter.Prompt("Your guess:");
                bool isGuessValid = Validator.Validate(usersGuess, out int parsedGuess);

                if (!isGuessValid)
                {
                    Console.WriteLine("You must enter a number between 1 and 6");
                    continue;
                }

                if (parsedGuess == drawnNumber)
                {
                    Console.WriteLine($"Correct. The drawn number was {drawnNumber}");
                    break;
                }

                Console.WriteLine($"{parsedGuess} was not the drawn number. Try again!");
                Console.WriteLine($"You have {retry.RetriesLeft() - 1} retries left");

                retry.CountRetry();
            } while (retry.RetriesLeft() > 0);

            Console.WriteLine("Thanks for playing. See you next time!");
        }
    }
}
