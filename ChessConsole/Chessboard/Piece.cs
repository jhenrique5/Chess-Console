﻿namespace Chessboard
{
    class ChessPiece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public Board Board { get; protected set; }

        public ChessPiece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
        }
    }
}
