using System;

namespace GuessANumberByUsernam
{
    class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            Console.WriteLine("Please input your number");

            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string playersInput = Console.ReadLine();
                bool isValid = int.TryParse(playersInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it, nice :)");
                        break;
                    }
                    else if (playerNumber>computerNumber)
                    {
                        Console.WriteLine("Too High, try lower digit :(");

                    }
                    else if (playerNumber<computerNumber)
                    {
                        Console.WriteLine("Too Low, try higher digit :(");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! This time enter digits...");
                }
            }
        }
    }
}
