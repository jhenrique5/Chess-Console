namespace Chessboard
{
    class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece ChessPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public void AddPiece(Piece p, Position pos)
        {
            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;
        }
    }
}
