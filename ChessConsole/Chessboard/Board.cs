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

        public Piece ChessPiece(Position pos)
        {
            return Pieces[pos.Row, pos.Column];
        }

        public bool ExistsPiece(Position pos)
        {
            ValidatePosition(pos);
            return ChessPiece(pos) != null;
        }

        public void AddPiece(Piece p, Position pos)
        {
            if (ExistsPiece(pos))
            {
                throw new ChessboardException("There is already a piece at this position!");
            }
            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition (Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new ChessboardException("Invalid position!");
            }
        }
    }
}
