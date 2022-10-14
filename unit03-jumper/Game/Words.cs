using System;
using System.Collections.Generic;

namespace Jumper.Game
{
    
    public class Words
    {
        public TerminalService _terminalService = new TerminalService();
        public List<string> _wordOptions = new List<string>();  
        public string _finalWord = "";
        public int _finalWordLength;
        private int x;
        public string [] hintArray;
        // Picks a random word from the list.
        public Words()
        {
            _wordOptions.Add("monkey");
            _wordOptions.Add("orange");
            _wordOptions.Add("watermelon");
            _wordOptions.Add("computer");
            _wordOptions.Add("charger");
            _wordOptions.Add("parachute");
            _wordOptions.Add("terminal");
            _wordOptions.Add("gatorade");
            _wordOptions.Add("library");
            _wordOptions.Add("sweatshirt");
            _wordOptions.Add("skateboard");
            _wordOptions.Add("silver");
            _wordOptions.Add("basketball");
            _wordOptions.Add("wildcat");
            _wordOptions.Add("chicken"); 

            Random random = new Random();
            _finalWord = _wordOptions[random.Next(0, 15)];
            WordLength();
        }
        // Returns the length of the word as an int
        private int WordLength()
        {
            _finalWordLength = _finalWord.Length;
            return _finalWordLength;
        }
        // Creates the array for the hint based on length of the hidden word
        public string [] CreateHintArray()
        {
            x = _finalWordLength;
            String[] hintArray = new string [x];
            for (int i = 0; i < x; i++)
            {
                hintArray[i] = "_";
            }
            return hintArray;
        }    
    }
}



