namespace HighLowNumberGuessing
{
    internal class Program
    {
        const int CLOSE_DIFF = 5;
        const int MAX_GUESSES = 5;
        static void Main(string[] args)
        {
            GuessTheNumber();
        }

        static void GuessTheNumber()
        {
            int totalWrongGuesses = 0;
            int rnd = new Random().Next(1, 101);
            do
            {
                Console.WriteLine("Please guess the number");
                int guessedNumber = Convert.ToInt16(Console.ReadLine());
                if (guessedNumber == rnd)
                {
                    Console.WriteLine("Great job you guessed right");
                    return;
                }
                int difference = Math.Abs(guessedNumber - rnd);

                if (guessedNumber > rnd)
                {
                    Console.WriteLine("You guesssed too high");
                }

                if (guessedNumber < rnd)
                {
                    Console.WriteLine("You guesssed too low");
                }

                if (difference <= CLOSE_DIFF)
                {
                    Console.WriteLine("You are so close");
                }

                totalWrongGuesses++;
            } while (totalWrongGuesses <= MAX_GUESSES);

            Console.WriteLine("You entered too many wrong choices");
        }
    }
}