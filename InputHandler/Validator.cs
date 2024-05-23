using Microsoft.VisualBasic;

namespace CSDiceRollGame.InputHandler
{
    public static class Validator
    {
        private static readonly int[] _validGuesses = [1, 2, 3, 4, 5, 6];

        public static bool Validate(string guess, out int parsedGuess)
        {
            bool isGuessInteger = int.TryParse(guess, out parsedGuess);

            if (isGuessInteger)
            {
                if (_validGuesses.Contains(parsedGuess))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
