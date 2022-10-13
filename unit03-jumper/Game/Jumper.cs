using System;

namespace Jumper.Game
{
    public class Jumper
    {
        TerminalService _terminalService = new TerminalService();
        public int wrong_guess_count = 0;
        public Jumper()
        {
    
        }

        public void PrintJumperBody()
        {
            _terminalService.WriteText(" /|\\");
            _terminalService.WriteText(" / \\");
            _terminalService.WriteText(" ");
            _terminalService.WriteText("______");
        }

        public void PrintParachute()
        {
            if(wrong_guess_count == 0)
            {
                _terminalService.WriteText(" ___ ");
                _terminalService.WriteText("/___\\ ");
                _terminalService.WriteText("\\   / ");
                _terminalService.WriteText(" \\ / ");
                _terminalService.WriteText("  0 ");
            }
            else if(wrong_guess_count == 1)
            {
                _terminalService.WriteText("/___\\ ");
                _terminalService.WriteText("\\   / ");
                _terminalService.WriteText(" \\ / ");
                _terminalService.WriteText("  0 ");
            }
            else if(wrong_guess_count == 2)
            {
                _terminalService.WriteText("\\   / ");
                _terminalService.WriteText(" \\ / ");
                _terminalService.WriteText("  0 ");
            }
            else if(wrong_guess_count == 3)
            {
                _terminalService.WriteText(" \\ / ");
                _terminalService.WriteText("  0 ");
            }
            else if(wrong_guess_count == 1)
            {
                _terminalService.WriteText("  0 ");
            }
            else
            {
                _terminalService.WriteText("  X ");
            }
        }

        public void PrintJumper()
        {
            PrintParachute();
            PrintJumperBody();
        }
    }
}