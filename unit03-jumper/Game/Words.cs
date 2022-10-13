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
        public int x;
        public string [] hintArray;

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
            WordLength(_finalWord);
        }

        public int WordLength(string word)
        {
            _finalWordLength = word.Length;
            return _finalWordLength;
        }

        public string [] CreateHintArray(string word)
        {
            _finalWordLength = word.Length;
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



