using System;
using Chessboard;
using Chess; 

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.AddPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.AddPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.AddPiece(new King(board, Color.Black), new Position(0, 2));

                board.AddPiece(new Rook(board, Color.White), new Position(3, 5));



                Screen.PrintBoard(board);
            }
            catch (ChessboardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();


        }
    }
}
