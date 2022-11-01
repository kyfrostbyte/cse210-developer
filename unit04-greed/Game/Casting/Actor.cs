using System;


namespace Unit04_greed.Game.Casting
{
   
    public class Actor
    {
        private string _text = "";
        private int _fontSize = 15;
        private Color _color = new Color(255, 255, 255); // white
        private Point _position = new Point(0,0);
        private Point _velocity = new Point(0, 0);

        
        public Actor()
        {
        }


        //Gets the actor's color.
        public Color GetColor()
        {
            return _color;
        }

        //Gets the actor's font size
        public int GetFontSize()
        {
            return _fontSize;
        }

        //Gets the actor's position
        public Point GetPosition()
        {
            return _position;
        }

        // Gets the actor's text.
        public string GetText()
        {
            return _text;
        }

        //Gets the actor's current velocity
        public Point GetVelocity()
        {
            return _velocity;
        }

        //Sets rock and gems velocity to move downward slowly
        public Point SetVelocityDown()
        {
            _velocity = new Point(0, 5);
            return _velocity;
        }

        // Moves actor's position on screen
        public void MoveNext(int maxX, int maxY)
        {
            int x = ((_position.GetX() + _velocity.GetX()) + maxX) % maxX;
            int y = ((_position.GetY() + _velocity.GetY()) + maxY) % maxY;
            _position = new Point(x, y);
        }

        //Sets color of actor based on parameter
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this._color = color;
        }

        //Sets the actor's font size based on parameter
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this._fontSize = fontSize;
        }

        //Sets the actor's position based on parameter
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this._position = position;
        }

       //Sets the actor's text based on parameter
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this._text = text;
        }


        //Sets the actor's velocity based on parameter
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity = velocity;
        }

    }
}