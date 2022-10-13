// using System;
// using System.Collections.Generic;

// namespace Jumper.Game
// {
    
//     public class Hints
//     {
//         public TerminalService _terminalService = new TerminalService();
//         Director director = new Director();
        

//         int testfinalWordLength;
//         int x;
    
//         public Hints()
//         {
//             Test();
//         }
//         public int WordLength(string _finalWord)
//         {
//             testfinalWordLength = _finalWord.Length;
//             return testfinalWordLength;
//         }


//         public void Hint()
//         {
//             x = testfinalWordLength;
//             String[] hintArray = new string [x];
//             for (int i = 0; i < x; i++)
//             {
//                 hintArray[i] = "_";
//             }   
//             _terminalService.WriteArray(hintArray);
//         }

//         public void Test()
//         {
//             _terminalService.WriteText(director.real_word);
//         }

        
//     }
// }



