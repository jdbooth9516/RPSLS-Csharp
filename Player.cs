using System;

namespace RPSLS_C_
{
    public class Player
    {
        public string name = "";
        public int roundsWon = 0;
    }

    public class Human : Player
    {
        public void setName()
        {
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            this.name = userName;
        }

    }

    public class Computer : Player
    {
        public string name = "AI";

    }
}