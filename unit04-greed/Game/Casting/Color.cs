using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    public class Color
    {
        private int _red = 0;
        private int _green = 0;
        private int _blue = 0;
        private int _alpha = 255;

        // Constructs a new instance of Color    
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Gets the color's alpha value.
        public int GetAlpha()
        {
            return _alpha;
        }

        // Gets the color's blue value.
        public int GetBlue()
        {
            return _blue;
        }

        // Gets the color's green value.
        public int GetGreen()
        {
            return _green;
        }

        // Gets the color's red value.
        public int GetRed()
        {
            return _red;
        }

    }
}