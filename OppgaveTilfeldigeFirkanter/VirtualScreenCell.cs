using System;
namespace OppgaveTilfeldigeFirkanter
{
    public class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public VirtualScreenCell()
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }
        public char GetCharacter()
        {
            if (Down && Up && Left && Right) return '┼';
            else if (Down && Left && Right) return '┬';
            else if (Up && Left && Right) return '┴';
            else if (Left && Down && Up) return '┤';
            else if (Right && Down && Up) return '├';
            else if (Up && Down) return '│';
            else if (Right && Left) return '─';
            else if (Right && Down) return '┌';
            else if (Right && Up) return '└';
            else if (Left && Down) return '┐';
            else if (Left && Up) return '┘';
            else return ' ';

        }
        public void AddHorizontal()
        {
            Right = true;
            Left = true;
        }
        public void AddVertical()
        {
            Up = true;
            Down = true;
        }
        public void AddLowerLeftCorner()
        {
            Right = true;
            Up = true;
        }
        public void AddUpperLeftCorner()
        {
            Right = true;
            Down = true;
        }
        public void AddUpperRightCorner()
        {
            Left = true;
            Down = true;
        }
        public void AddLowerRightCorner()
        {
            Left = true;
            Up = true;
        }
    }
}

