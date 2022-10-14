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
        // Prints the body of the jumper
        private void PrintJumperBody()
        {
            _terminalService.WriteText(" /|\\");
            _terminalService.WriteText(" / \\");
            _terminalService.WriteText(" ");
            _terminalService.WriteText("______");
        }
        // Prints the jumper's parachute
        private void PrintParachute()
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
            else
            {
                _terminalService.WriteText("  X ");
            }
        }
        // Calls both print functions to print everything in one go
        public void PrintJumper()
        {
            PrintParachute();
            PrintJumperBody();
        }
    }
}