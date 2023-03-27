namespace OppgaveTilfeldigeFirkanter
{
    internal class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];

            for (int i = 0; i < screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        internal void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();
            AddMiddleLines(boxX, boxWidth);
            _cells[boxX + boxWidth - 1].AddLowerRightCorner();
        }

        internal void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            var indexOfSecondLine = boxX + boxWidth - 1;
            _cells[indexOfSecondLine].AddVertical();
        }

        internal void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            AddMiddleLines(boxX, boxWidth);
            _cells[boxX + boxWidth - 1].AddUpperRightCorner();
        }
        private void AddMiddleLines(int boxX, int boxWidth)
        {
            var indexOfUpperRightCorner = boxX + boxWidth - 1;
            for (int i = (boxX + 1); i < indexOfUpperRightCorner; i++)
            {
                _cells[i].AddHorizontal();
            }
        }
        internal void Show()
        {
            foreach (var cell in _cells)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }
    }
}