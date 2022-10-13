using System.Collections.Generic;
using System.Linq;
namespace Jumper.Game
{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        Jumper _jumper = new Jumper();
        public Words _goalWord = new Words();

        public string real_hint;
        public string real_word;

        private bool isPlaying = true;
        
        // public Hints hint = new Hints();
        List<string> guessList = new List<string>();
        string userGuess = "";
        string [] hintArray;
        public Director()
        {

        }
        public void RunGame()
        {  
            hintArray = _goalWord.CreateHintArray(_goalWord._finalWord);
            while(isPlaying)
            {
                 _terminalService.WriteText(_goalWord._finalWord);
                GetInput();
                CheckInput();
                ApplyInput();
            }
        }

        public void GetInput()
        {
            _terminalService.WriteArray(hintArray);
            _terminalService.WriteText("");
            _jumper.PrintJumper();
            _terminalService.WriteText(" ");
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }

        public void CheckInput()
        {
            if(guessList.Contains(userGuess))
            {
                _terminalService.WriteText("You have already made that guess. ");
            }
        }

        public void ApplyInput()
        {
            string stringGoalWord =_goalWord._finalWord;
            int index1 = stringGoalWord.IndexOf(userGuess);
            if(index1 != -1)
                {
                    _terminalService.WriteText("CORRECT GUESS");
                    _terminalService.WriteText("");
                    guessList.Add(userGuess);
                    hintArray[index1] = userGuess;
                }
                else
                {
                    _terminalService.WriteText("BAD GUESS");
                    _terminalService.WriteText("");
                    guessList.Add(userGuess);
                    _jumper.wrong_guess_count += 1;
                    if(_jumper.wrong_guess_count == 4)
                    {
                        _terminalService.WriteText("Game over!");
                        _jumper.PrintJumper();
                        isPlaying = false;
                    }
                }

        }

    }
}