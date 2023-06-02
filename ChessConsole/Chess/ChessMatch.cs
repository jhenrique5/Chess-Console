using System;
using Chessboard;

namespace Chess
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            AddPieces();
        }

        public void MakeMove(Position origin, Position destination)
        {
            Piece p = Board.RemovePiece(origin);
            p.IncrementNumberOfMoves();
            Piece capturedPiece = Board.RemovePiece(destination);
            Board.AddPiece(p, destination);
        }

        public void ExecuteMovement(Position origin, Position destination)
        {
            MakeMove(origin, destination);
            Turn++;
            SwitchPlayer();
        }

        private void SwitchPlayer()
        {
            if (CurrentPlayer == Color.White)
            {
                CurrentPlayer = Color.Black;
            }
            else
            {
                CurrentPlayer = Color.White;
            }
        }

        private void AddPieces()
        {
            Board.AddPiece(new Rook(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.AddPiece(new Rook(Board, Color.White), new ChessPosition('c', 2).ToPosition());
            Board.AddPiece(new Rook(Board, Color.White), new ChessPosition('d', 2).ToPosition());
            Board.AddPiece(new Rook(Board, Color.White), new ChessPosition('e', 2).ToPosition());
            Board.AddPiece(new Rook(Board, Color.White), new ChessPosition('e', 1).ToPosition());
            Board.AddPiece(new King(Board, Color.White), new ChessPosition('d', 1).ToPosition());

            Board.AddPiece(new Rook(Board, Color.Black), new ChessPosition('c', 7).ToPosition());
            Board.AddPiece(new Rook(Board, Color.Black), new ChessPosition('c', 8).ToPosition());
            Board.AddPiece(new Rook(Board, Color.Black), new ChessPosition('d', 7).ToPosition());
            Board.AddPiece(new Rook(Board, Color.Black), new ChessPosition('e', 7).ToPosition());
            Board.AddPiece(new Rook(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
            Board.AddPiece(new King(Board, Color.Black), new ChessPosition('d', 8).ToPosition());
        }
    }
}
