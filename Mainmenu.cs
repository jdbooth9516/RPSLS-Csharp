using System;
using System.Threading;


namespace RPSLS_C_
{
    public class Menu
    {
        public bool validEntry;
         public Menu()
        {
            this.validEntry = false;
        }
        public void MainMenu()
        {
            Console.WriteLine($"Welcome ot Rock, Paper, Scisoors, Lizard, Spock!");
            Thread.Sleep(1500);
            Console.WriteLine($"Rules are simply just like Rock, Paper, Scissors. Just with the addition of 2 more options of lizard and spock.");
            Thread.Sleep(1500);
            Console.WriteLine($"Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
            Thread.Sleep(1500);
            Console.WriteLine($"Got it, good");
            Thread.Sleep(1500);
            Console.WriteLine($"For the number of players enter 1 to play against the AI, enter 2 to play against another human");
            Thread.Sleep(1500);
            Console.WriteLine($"when choosing a gesture hit a single number and hit enter the number that you have selected will not be displayed in terminal.");
            Thread.Sleep(1500);
        }

        public int getNumberOfPlayers()
        {  
            int numberOfPlayers = 0;
            while (this.validEntry == false) 
            {
                Console.WriteLine("Enter the number of players: (1 or 2)");
                string playerInput;
                playerInput = Console.ReadLine();
                numberOfPlayers = Convert.ToInt16(playerInput);
                if (numberOfPlayers != 1 && numberOfPlayers != 2)
                {
                    Console.WriteLine("Invalid input please try again");
                }
                else
                {
                    this.validEntry = true;
                    return numberOfPlayers;
                }
            }
            return numberOfPlayers;
        }
    }    
}