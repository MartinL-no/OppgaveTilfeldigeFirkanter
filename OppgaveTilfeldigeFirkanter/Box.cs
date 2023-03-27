using System;
namespace OppgaveTilfeldigeFirkanter
{
    public class Box
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int StartY => Y;
        public int EndY => Y + Height;
        public int Width { get; }
        public int Height { get; }
        private int _minimumSize = 3;
        private int _maxX;
        private int _maxY;
        public int _speedDirectionX;
        public int _speedDirectionY;

        public Box(Random random, int maxX, int maxY, int speedDirectionX, int speedDirectionY)
        {
            Width = random.Next(_minimumSize, maxX);
            Height = random.Next(_minimumSize, maxY);
            X = random.Next(1, maxX - Width);
            Y = random.Next(1, maxY - Height);
            _maxX = maxX;
            _maxY = maxY;
            _speedDirectionX = speedDirectionX;
            _speedDirectionY = speedDirectionY;
        }
        public void Move()
        {
            X += _speedDirectionX;
            Y += _speedDirectionY;

            if (X < 0)
            {
                X *= -1;
                _speedDirectionX = _speedDirectionX * -1;
            }
            else if (X + Width > _maxX)
            {
                X -= _speedDirectionX;
                _speedDirectionX = _speedDirectionX * -1;
            }
            if (Y < 0)
            {
                Y *= -1;
                _speedDirectionY = _speedDirectionY * -1;
            }
            else if (Y + Height > _maxY)
            {
                Y -= _speedDirectionY;
                _speedDirectionY = _speedDirectionY * -1;
            }
        }
    }
}

