using System;
using System.Collections.Generic;

namespace Jumper.Game
{
    
    public class Words
    {
        public TerminalService _terminalService = new TerminalService();
        public List<string> _wordOptions = new List<string>();  
        public string _finalWord = "";
        public int finalWordLength;
        static int x;
        // String[] hint = new string [x];
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
            _finalWord = _wordOptions[random.Next(1, 16)];
            // finalWordLength = WordLength(_finalWord);
            // Hint();
        }

        // public int WordLength(string _finalWord)
        // {
        //     finalWordLength = _finalWord.Length;
        //     return finalWordLength;
        // }

        // public void Hint()
        // {
        //     x = finalWordLength;
        //     String[] hintArray = new string [x];
        //     for (int i = 0; i < x; i++)
        //     {
        //         hintArray[i] = "_";
        //     }   
        //     _terminalService.WriteArray(hintArray);

        // }

        
    }
}



