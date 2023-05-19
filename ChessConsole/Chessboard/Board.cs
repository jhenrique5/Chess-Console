namespace Chessboard
{
    class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private ChessPiece[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new ChessPiece[rows, columns];
        }
    }
}
