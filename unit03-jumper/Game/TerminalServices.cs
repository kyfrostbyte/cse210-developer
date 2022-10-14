using System;
namespace Jumper.Game
{
    public class TerminalService
    {
        public TerminalService()
        {
        }

        // Gets numerical input from user based on prompt that is passed in.
        public int ReadNumber(string prompt)
        {
            string rawValue = ReadText(prompt);
            return int.Parse(rawValue, System.Globalization.CultureInfo.InvariantCulture);
        }

        // Gets string input from user based on prompt that is passed in.
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Prints whatever string is passed in
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        // Prints whatever int is passed in
        public void WriteNumber(int number)
        {
            Console.WriteLine(number);
        }

        // Prints whatever array is passed in
        public void WriteArray(string [] array)
        {
            Console.WriteLine("{0}", string.Join(" ", array));
        }

        public void WriteListInline(string list)
        {
            Console.WriteLine("Previous Guesses: " + list);
        }

    }
}