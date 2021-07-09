using System;


namespace RPSLS_C_
{
    public class Game
    {   
        public int rounds;
        public int currentRound;
        public int totalPlayers;
        public string player1;
        public string player2;

        public Game() {
            this.rounds = 0;
            this.currentRound = 0; 
            this.totalPlayers = 0;
            this.player1 = "";
            this.player2 = "";
        }

        public void RunGame()
        {
            Menu main = new Menu();
            main.MainMenu();
            this.totalPlayers = main.getNumberOfPlayers();
            Console.WriteLine($"{this.totalPlayers}");
            
            

        }
    }

}