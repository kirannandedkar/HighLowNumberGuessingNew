namespace HighLowNumberGuessing
{
    internal class Program
    {
        const int MAXDIFFERENCEBETWEENGUESSEDNUMBERS = 5;
        const int TOTALNUMBEROFGUESSESALLOWED = 5;
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
                var difference = Math.Abs(guessedNumber - rnd);
                bool guessedNumberGreaterThanActualNumber = guessedNumber > rnd;
                bool guessedNumberLessThanActualNumber = guessedNumber < rnd;

                if (guessedNumber == rnd)
                {
                    Console.WriteLine("Great job you guessed right");
                    return;
                }

                if (guessedNumberGreaterThanActualNumber)
                {
                    Console.WriteLine("You guesssed too high");
                }

                if (guessedNumberLessThanActualNumber)
                {
                    Console.WriteLine("You guesssed too low");
                }

                if (difference <= MAXDIFFERENCEBETWEENGUESSEDNUMBERS)
                {
                    Console.WriteLine("You are so close");
                }

                totalWrongGuesses++;
            } while (totalWrongGuesses <= TOTALNUMBEROFGUESSESALLOWED);

            Console.WriteLine("You entered too many wrong choices");
        }
    }
}