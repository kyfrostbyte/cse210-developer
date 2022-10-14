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
        int loopCount = 0;
        string [] hintArray;
        public Director()
        {

        }
        // Calls functions in a loop until game outcome is decided
        public void RunGame()
        {  
            while(isPlaying)
            {
                GetInput();
                ApplyInput();
                DetermineOutcome();
            }
        }
        // Asks user to guess a letter
        private void GetInput()
        {   
            if(loopCount == 0)
            {
                hintArray = _goalWord.CreateHintArray();
            }
            _terminalService.WriteArray(hintArray);
            _terminalService.WriteText("");
            _jumper.PrintJumper();
            _terminalService.WriteText(" ");
            if(loopCount > 0)
            {
                string listString = string.Join(" ", guessList);
                _terminalService.WriteListInline(listString);
            }
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
            VerifyInput();
            loopCount += 1;
        }
        // Verifies that the users input is an unused lower case letter
        private void VerifyInput()
        {
            bool isLetter = userGuess.All(c => (c >= 'a' && c <= 'z'));
            if (!isLetter || guessList.Contains(userGuess) || userGuess.Length > 1)
            {   
                _terminalService.WriteText("Invalid input.");
                _terminalService.WriteText("Please enter a unused single lower case letter.");
                GetInput();
            }
        }
        // Determines if guess was right or wrong. Updates the hint array if guess was right.
        private void ApplyInput()
        {
            string stringGoalWord =_goalWord._finalWord;
            string duplicateGoalWord = stringGoalWord;
            int index1 = stringGoalWord.IndexOf(userGuess);
            if(index1 != -1)
                {
                    char[] ch = stringGoalWord.ToCharArray();
                    ch[index1] = '0';
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
                }
                else
                {
                    _terminalService.WriteText("BAD GUESS");
                    _terminalService.WriteText("");
                    guessList.Add(userGuess);
                    _jumper.wrong_guess_count += 1;
                }

        }
        // Determines if the game is over and prints the results
        private void DetermineOutcome()
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