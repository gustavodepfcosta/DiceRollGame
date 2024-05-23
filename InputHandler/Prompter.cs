namespace CSDiceRollGame.InputHandler
{
    public static class Prompter
    {
        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine() ?? "";

            return userInput;
        }
    }
}
