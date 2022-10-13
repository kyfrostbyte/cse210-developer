using System.Collections.Generic;
namespace Jumper.Game

{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        private Jumper _jumper = new Jumper();
        public Words _goal = new Words();
        string userGuess = "";
        public Director()
        {
            
        }
        public void RunGame()
        {
            GetInput();
            
        }

        private void GetInput()
        {
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }
    }
}