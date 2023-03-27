using System;
namespace OppgaveTilfeldigeFirkanter
{
    public class VirtualScreen
    {
        private VirtualScreenRow[] _rows;

        public VirtualScreen(int width, int height)
        {
            _rows = new VirtualScreenRow[height];

            for (int i = 0; i < _rows.Length; i++)
            {
                _rows[i] = new VirtualScreenRow(width);
            }
        }
        public void Add(Box box)
        {
            _rows[box.Y].AddBoxTopRow(box.X, box.Width);

            var startIndex = box.Y + 1;
            for (int i = startIndex; i < startIndex + box.Height -2; i++)
            {
                _rows[i].AddBoxMiddleRow(box.X, box.Width);
            }
            _rows[box.Y + box.Height -1].AddBoxBottomRow(box.X, box.Width);
            

        }
        public void Show()
        {
            foreach (var row in _rows)
            {
                row.Show();
            }
        }
    }
}

