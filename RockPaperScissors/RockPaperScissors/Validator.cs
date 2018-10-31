using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Validator
    {
        //Method to valid input when there are 2 possible valid choices
        static public string Validate(string message, string choice1, string choice2)
        {
            Console.Write(message);
            string choice = Console.ReadLine().ToLower().Trim();
            while(choice != choice1 && choice != choice2)
            {
                Console.Write("Invalid selection. "+message);
                choice = Console.ReadLine().ToLower().Trim();
            }

            return choice;
        }

        //Method to valid input when there are 3 possible valid choices
        static public string Validate(string message, string choice1, string choice2, string choice3)
        {
            Console.Write(message);
            string choice = Console.ReadLine().ToLower().Trim();
            while (choice != choice1 && choice != choice2 && choice != choice3)
            {
                Console.Write("Invalid selection. " + message);
                choice = Console.ReadLine().ToLower().Trim();
            }

            return choice;
        }

        //Method to valid input when there are 4 possible valid choices
        static public string Validate(string message, string choice1, string choice2, string choice3, string choice4)
        {
            Console.Write(message);
            string choice = Console.ReadLine().ToLower().Trim();
            while (choice != choice1 && choice != choice2 && choice != choice3 && choice != choice4)
            {
                Console.Write("Invalid selection. " + message);
                choice = Console.ReadLine().ToLower().Trim();
            }

            return choice;
        }
    }
}
