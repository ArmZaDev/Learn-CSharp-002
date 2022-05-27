using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number guessing game 🔢
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess, number, guesses;
            string respones;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                respones = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guess++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guess: " + guess);

                Console.WriteLine("Would you like to play again (Y/N): ");
                respones = Console.ReadLine();
                respones = respones.ToUpper();

                if (respones == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing! ... I guess");
            Console.ReadKey();
        }
    }
}
