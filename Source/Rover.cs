using System;

namespace MarsRovers
{
    public class Rover
    {
        private Point _position;
        private string _direction;
        private string _orientation;

        internal void SetPosition(Point position)
        {
            _position = position;
        }

        internal Point GetPosition()
        {
            return _position;
        }

        internal void SetDirection(string direction)
        {
            _direction = direction;
        }

        internal string GetDirection()
        {
            return _direction;
        }

        internal void Move()
        {
            switch (_direction)
            {
                case "N":
                    _position = new Point(_position.X, _position.Y + 1);
                    break;
                case "S":
                    _position = new Point(_position.X, _position.Y - 1);
                    break;
                case "E":
                    _position = new Point(_position.X + 1, _position.Y);
                    break;
                case "W":
                    _position = new Point(_position.X - 1, _position.Y);
                    break;


            }
        }

        internal void Turns(string orientation)
        {
            if (_direction == "N" && orientation == "L")
            {
                _direction = "W";
            }
            else if (_direction == "W" && orientation == "L")
            {
                _direction = "S";
            }
            else if (_direction == "S" && orientation == "L")
            {
                _direction = "E";
            }
            else if (_direction == "E" && orientation == "L")
            {
                _direction = "N";
            }
            else if (_direction == "N" && orientation == "R")
            {
                _direction = "E";
            }
            else if (_direction == "E" && orientation == "R")
            {
                _direction = "S";
            }
            else if (_direction == "S" && orientation == "R")
            {
                _direction = "W";
            }
            else if (_direction == "W" && orientation == "R")
            {
                _direction = "N";
            }
        }

        internal string GetOrientation()
        {
            return _orientation;

        }

        internal void SetOrientation(string orientation)
        {
            _orientation = orientation; 
        }
    }
}