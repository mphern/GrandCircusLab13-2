using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
            Console.Write("Enter your name: ");
            UserPlayer player = new UserPlayer(Console.ReadLine());
            string keepPlaying = "y";
            while (keepPlaying == "y" || keepPlaying == "yes")
            {
                int wins = 0;
                int loses = 0;
                Alien alien = new Alien();
                Predator predator = new Predator();
                string opponent = Validator.Validate($"\nWould you like to play against {alien.PlayerName} or {predator.PlayerName}? ({alien.PlayerName.Substring(0,1).ToLower()}/{predator.PlayerName.Substring(0, 1).ToLower()}): ", alien.PlayerName.Substring(0,1).ToLower(), predator.PlayerName.Substring(0, 1).ToLower());
                if (opponent == alien.PlayerName.Substring(0, 1).ToLower())
                {
                    PlayGame(player, alien, ref wins, ref loses);
                }
                else
                {
                    PlayGame(player, predator, ref wins, ref loses);
                }
                keepPlaying = Validator.Validate("\nContinue playing? (y/n): ", "yes", "y", "no", "n");
            }
            Console.ReadKey();
        }

        static void PlayGame(UserPlayer player, Player opponent, ref int wins, ref int loses)
        {
            int delay = 500;
            string playAgain = "y";
            while (playAgain == "y" || playAgain == "yes")
            {
                Roshambo playerChoice = player.GenerateRoshambo();
                Roshambo oppChoice = opponent.GenerateRoshambo();

                Console.WriteLine("\n"+ player.PlayerName + " chooses " + playerChoice);
                Console.Write(opponent.PlayerName +" chose");
                Thread.Sleep(delay);
                Console.Write(" . ");
                Thread.Sleep(delay);
                Console.Write(" . ");
                Thread.Sleep(delay);
                Console.Write(" . ");
                Thread.Sleep(delay);
                Console.Write(oppChoice + "\n");
                CheckForWin(player.PlayerName, opponent.PlayerName, playerChoice, oppChoice, ref wins, ref loses);
                playAgain = Validator.Validate("\nPlay again against this oppenent? (y/n): ", "yes", "y", "no", "n");
            }
            Console.WriteLine($"\nYou won {wins} {(wins == 1 ? "game" : "games")} and lost {loses} {(loses == 1 ? "game" : "games")} against {opponent.PlayerName}.");
        }


        static void CheckForWin(string playerName, string oppName, Roshambo playerChoice, Roshambo oppChoice, ref int wins, ref int loses)
        {
            if(playerChoice == oppChoice)
            {
                Console.WriteLine("Draw!");
            }
            else if(playerChoice == Roshambo.rock && oppChoice == Roshambo.scissors)
            {
                Console.WriteLine(playerName + " wins!");
                wins++;
            }
            else if(playerChoice == Roshambo.scissors && oppChoice == Roshambo.paper)
            {
                Console.WriteLine(playerName + " wins!");
                wins++;
            }
            else if(playerChoice == Roshambo.paper && oppChoice == Roshambo.rock)
            {
                Console.WriteLine(playerName + " wins!");
                wins++;
            }
            else
            {
                Console.WriteLine(oppName + " wins!");
                loses++;
            }
        }

    }
}
