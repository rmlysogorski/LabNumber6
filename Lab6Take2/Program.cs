using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Take2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice;
            int count = 0;

            Console.Clear();
            Console.WriteLine("Welcome to  the Grand Circus Casino!");
            Console.WriteLine("------------------------------------");
            choice = DiceRollerApp.GetUserChoice("Would you like to roll the dice? (y/n)", "y", "n");

            if (choice)
            {
                count++;
            }

            while (choice)
            {
                DiceRollerApp.RollTheDice(count);
                count++;
                choice = DiceRollerApp.GetUserChoice("Roll Again? (y/n)", "y", "n");
            }

            if(count == 1)
            {
                Console.WriteLine($"\nYou rolled the dice {count} time.\n");
            }
            else
            {
                Console.WriteLine($"\nYou rolled the dice {count} times.\n");
            }
            
        }
    }
}
