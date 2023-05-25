﻿using System;


namespace ConsoleApp5
{
    internal class Program
    {
        private static void Main()
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 101);
            int guessCount = 0;
            string choice;
            bool continuePlaying = true;

            while (true)
            {
                Console.WriteLine("Guess a number between 1 - 100");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    guessCount++;

                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed it");
                        Console.ResetColor();
                        Console.WriteLine("It took you " + guessCount + " attempts to guess the right number!");

                        Console.WriteLine("Would you like to play again (Y/N)");
                        choice = Console.ReadLine().ToUpper();

                        if (choice != "Y")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Thank you for playing!");
                            Console.ResetColor();
                            continuePlaying = false;
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too High!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Too Low!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Input.");
                }
                Console.ResetColor();
            }
        }
    }
}
