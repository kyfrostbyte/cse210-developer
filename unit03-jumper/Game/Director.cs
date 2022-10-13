using System.Collections.Generic;
using System.Linq;
namespace Jumper.Game
{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        Jumper _jumper = new Jumper();
        public Words _goalWord = new Words();
        
        List<string> goodGuess = new List<string>();
        List<string> badGuess = new List<string>();
        string userGuess = "";
        public Director()
        {

        }
        public void RunGame()
        {  
            _terminalService.WriteText(_goalWord._finalWord);
            _terminalService.WriteText(_goalWord.finalWordLength.ToString());
            GetInput();
        }

        public void GetInput()
        {
            _jumper.PrintJumper();
            _terminalService.WriteText(" ");
            _jumper.wrong_guess_count += 1;
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }

        public void CheckInput()
        {
            string _ngoalWord =_goalWord.ToString();
            if (_ngoalWord.ToLower().Contains(userGuess)) { }
            goodGuess.Add(userGuess);

        }

        // Jumper _jumper = new Jumper();
        // _terminalService.WriteText(" ");

        // for (int i = 0; i < 4; i++)
        // {
        //     _jumper.JumperKill();
        // }      


    }
}