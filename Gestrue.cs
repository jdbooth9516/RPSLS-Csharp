namespace RPSLS_C_
{
    
    public class Rock 
    {
        public string name = "rock";
        public string[] losesTo = {"paper", "spock"};
    }

    public class Scissor 
    {
        public string name = "scissor";
        public string[] losesTo = {"rock", "spock"};
    }

    public class Paper 
    {
        public string name = "paper";
        public string[] losesTo = {"scissor", "lizard"};
    }

    public class Lizard 
    {
        public string name = "lizard";
        public string[] losesTo = {"scissor", "rock"};
    }

    public class Spock 
    {
        public string name = "spock";
        public string[] losesTo = {"lizard", "paper"};
    }
}