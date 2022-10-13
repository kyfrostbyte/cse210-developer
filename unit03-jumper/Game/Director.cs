using System.Collections.Generic;
namespace Jumper.Game

{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        private Jumper _jumper = new Jumper();
        public Words _words = new Words();
        public List<string> _wordList = new List<string>(15);
        string userGuess = "";
        public Director()
        {
            _wordList.Add("monkey");
            _wordList.Add("orange");
            _wordList.Add("watermelon");
            _wordList.Add("computer");
            _wordList.Add("charger");
            _wordList.Add("parachute");
            _wordList.Add("terminal");
            _wordList.Add("gatorade");
            _wordList.Add("library");
            _wordList.Add("sweatshirt");
            _wordList.Add("skateboard");
            _wordList.Add("silver");
            _wordList.Add("basketball");
            _wordList.Add("wildcat");
            _wordList.Add("chicken");
        }

        public void RunGame()
        {
            foreach(string a in _wordList)
            _terminalService.WriteText(a);
            // GetInput();
            
        }

        private void GetInput()
        {
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }
    }
}