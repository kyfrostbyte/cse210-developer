using System.Collections.Generic;
namespace Jumper.Game

{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        public Words _goalWord = new Words();
        
        string userGuess = "";
        public Director()
        {
            
        }
        public void RunGame()
        {
            Jumper _jumper = new Jumper();
            _terminalService.WriteText(" ");

            for (int i = 0; i < 4; i++)
            {
                _jumper.JumperKill();
            }

            
        }

        private void GetInput()
        {
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }
    }
}