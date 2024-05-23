namespace CSDiceRollGame.Dices
{
    public static class Dice
    {
        private static readonly Random _random = new();
        public static int Roll()
        {
            var rawRandomNumber = _random.NextDouble() * 6;

            return (int)Math.Round(rawRandomNumber);
        }
    }
}
