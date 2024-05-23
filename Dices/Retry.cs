namespace CSDiceRollGame.Dices
{
    public class Retry
    {
        private static readonly int _maximumRetries = 3;
        public int Retries { get; private set; } = 0; 

        public void CountRetry()
        {
            if (_maximumRetries > Retries)
            {
                Retries++;
            }
        }

        public int RetriesLeft() => _maximumRetries - Retries;
    }
}
