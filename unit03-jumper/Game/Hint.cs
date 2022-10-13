using System;
using System.Collections.Generic;

namespace Jumper.Game
{
    
    public class Hints
    {
        public TerminalService _terminalService = new TerminalService();
        public Words _goalWord = new Words();
        string real_word;
        int finalWordLength;
        int x;
    
        public Hints()
        {

        }
        public int WordLength(string _finalWord)
        {
            real_word = _goalWord._finalWord;
            finalWordLength = _finalWord.Length;
            return finalWordLength;
        }


        public void Hint()
        {
            x = finalWordLength;
            String[] hintArray = new string [x];
            for (int i = 0; i < x; i++)
            {
                hintArray[i] = "_";
            }   
            _terminalService.WriteArray(hintArray);
        }

        
    }
}



