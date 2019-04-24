using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Take2
{
    class DiceRollerApp
    {
        private static readonly Random rnd = new Random();

        public static void RollTheDice(int count)
        {
            int die1 = 0, die2 = 0, sides = 0;

            sides = GetNumber("\nHow many sides should each die have? (2-20): ");
            die1 = GetRandomNumber(sides);
            die2 = GetRandomNumber(sides);
            PrintResults(die1, die2, count);
            CheckForSpecialRoll(die1, die2);
            
        }

        public static int GetNumber(string message)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int number) && number <= 20 && number >= 2)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Not a valid input!");
                return GetNumber(message);
            }
        }

        public static int GetRandomNumber(int sides)
        {            
            return rnd.Next(1, sides + 1);
        }

        public static void PrintResults(int die1, int die2, int count)
        {
            Console.WriteLine($"Roll {count}:\n{die1}\n{die2}\n");
        }

        public static void CheckForSpecialRoll(int die1, int die2)
        {
            if (die1 == 1 && die2 == 1)
            {
                Console.WriteLine("Snake Eyes!\n");
            }
            else if (die1 + die2 == 7)
            {
                Console.WriteLine("Craps!\n");
            }
            else if (die1 == 6 && die2 == 6)
            {
                Console.WriteLine("Box Cars!\n");
            }
        }

        public static bool GetUserChoice(string message, string option1, string option2)
        {
            Console.Write(message);
            string choice = Console.ReadLine();
            bool answer;

            if(choice == option1)
            {
                answer = true;
            }
            else if (choice == option2)
            {
                answer = false;
            }
            else
            {
                Console.WriteLine("Not a valid option!");
                return GetUserChoice(message, option1, option2); 
            }

            return answer;
        }
    }
}
