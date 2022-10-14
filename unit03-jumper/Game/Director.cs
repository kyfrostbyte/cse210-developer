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
        public Director()
        {

        }
        // Calls functions in a loop until game outcome is decided
        public void RunGame()
        {  
            hintArray = _goalWord.CreateHintArray();
            while(isPlaying)
            {
                GetInput();
                CheckInput();
                ApplyInput();
                DetermineOutcome();
            }
        }
        // Asks user to guess a letter
        private void GetInput()
        {
            _terminalService.WriteText(_goalWord._finalWord);
            _terminalService.WriteArray(hintArray);
            _terminalService.WriteText("");
            _jumper.PrintJumper();
            _terminalService.WriteText(" ");
            userGuess = _terminalService.ReadText("Guess a letter (A-Z): ");
        }
        // Verifies that the user hasnt already guessed that letter, and that their input both one character and a letter
        private void CheckInput()
        {
            bool isLetter = userGuess.All(c => (c >= 'a' && c <= 'z'));

            if (!isLetter)
            {
                _terminalService.WriteText("Please enter only lower case letters.");
                RunGame();
            }
 
            if(guessList.Contains(userGuess))
            {
                _terminalService.WriteText("You have already made that guess. ");
            }
            if(userGuess.Length > 1)
            {
                _terminalService.WriteText("Please enter only 1 letter at a time.");
            }
        }
        // Determines if guess was right or wrong. Updates the hint array if it was right.
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