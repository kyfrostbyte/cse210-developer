namespace Jumper.Game
{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        private Jumper _jumper = new Jumper();
        private Words _words = new Words();
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