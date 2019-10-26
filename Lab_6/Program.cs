using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numberOfSides, rollCount = 1, firstDie, secondDie;

            Console.Write("Welcome to the Casino!\nRoll the dice? (y/n): ");
            userInput = Console.ReadLine();
            while (userInput.ToLower() != "y" && userInput.ToLower() != "n")
            {
                Console.WriteLine();
                Console.Write("Input not valid.\nRoll the dice? (y/n): ");
                userInput = Console.ReadLine();
            }

            if(userInput.ToLower() == "y")
            {
                do
                {
                    Console.Write("\nHow many sides should each die have?: ");
                    userInput = Console.ReadLine();
                    while (!int.TryParse(userInput, out numberOfSides))
                    {
                        Console.WriteLine();
                        Console.Write("Input not valid.\nHow many sides should each die have?: ");
                        userInput = Console.ReadLine();
                    }

                    firstDie = DiceRoller.getRandom(numberOfSides);
                    secondDie = DiceRoller.getRandom(numberOfSides);

                    Console.WriteLine($"\nRoll {rollCount}");
                    Console.WriteLine($"Die 1: {firstDie}");
                    Console.WriteLine($"Die 2: {secondDie}");
                    Console.WriteLine($"Total: {firstDie + secondDie}\n");

                    CrapsMessages.getSpecialMessage(firstDie, secondDie);


                    Console.Write("\nRoll again? (y/n): ");
                    userInput = Console.ReadLine();
                    while (userInput.ToLower() != "y" && userInput.ToLower() != "n")
                    {
                        Console.WriteLine();
                        Console.Write("Input not valid.\nRoll again? (y/n): ");
                        userInput = Console.ReadLine();
                    }
                    rollCount++;
                } while (userInput.ToLower() == "y");
            }
            
            Console.WriteLine("\nOkay, have a good day!");
        }
    }
}
