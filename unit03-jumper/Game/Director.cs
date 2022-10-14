using System.Collections.Generic;
using System.Linq;
namespace Jumper.Game
{    public class Director
    {
        public TerminalService _terminalService = new TerminalService();
        public Words _goalWord = new Words();
        List<string> guessList = new List<string>();
        Jumper _jumper = new Jumper();
        private bool isPlaying = true;
        string userGuess = "";
        string [] hintArray;
        string [] duplicateArray;
        
        public Director()
        {

        }
        public void RunGame()
        {  
            hintArray = _goalWord.CreateHintArray(_goalWord._finalWord);
            duplicateArray = hintArray;
            while(isPlaying)
            {
                 _terminalService.WriteText(_goalWord._finalWord);
                GetInput();
                CheckInput();
                ApplyInput();
                DetermineOutcome();
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
            string duplicateGoalWord = stringGoalWord;
            int index1 = stringGoalWord.IndexOf(userGuess);
            if(index1 != -1)
                {
                    char[] ch = stringGoalWord.ToCharArray();
                    ch[index1] = 'X'; // index starts at 0!
                    string newstring = new string (ch);
                    _terminalService.WriteText("CORRECT GUESS");
                    hintArray[index1] = userGuess;
                    int index2 = newstring.IndexOf(userGuess);
                    if(index2 != -1)
                    {
                        hintArray[index2] = userGuess;
                    }
                    _terminalService.WriteText("");
                    guessList.Add(userGuess);
                    if(index2 != -1)
                    {
                        hintArray[index2] = userGuess;
                    }
                }
                else
                {
                    _terminalService.WriteText("BAD GUESS");
                    _terminalService.WriteText("");
                    guessList.Add(userGuess);
                    _jumper.wrong_guess_count += 1;
                }

        }

        public void DetermineOutcome()
        {
            if(_jumper.wrong_guess_count == 4)
            {
                _terminalService.WriteText("Game over!");
                _jumper.PrintJumper();
                isPlaying = false;
            }
            else if (!hintArray.Contains("_"))
            {
                _terminalService.WriteArray(hintArray);
                _terminalService.WriteText("You guessed the word!");
                isPlaying = false;
            }

        }

    }
}