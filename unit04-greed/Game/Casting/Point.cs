namespace Unit04_greed.Game.Casting
{
    // Point is essentiall an X and Y value. Class also includes methods to manipulate these coordinates.
    public class Point
    {
        private int _x = 0;
        private int _y = 0;


        // Constructs a new instance of Point using the given x and y values.
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        // Adds the given point to this one by summing the x and y values.
        public Point Add(Point other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new Point(x, y);
        }

        // Whether or not this Point is equal to the given one.
        public bool Equals(Point other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }

        /// Gets the value of the x coordinate.
        public int GetX()
        {
            return _x;
        }

        /// Gets the value of the y coordinate.
        public int GetY()
        {
            return _y;
        }

        /// Scales the point by multiplying the x and y values by the provided factor.
        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
}