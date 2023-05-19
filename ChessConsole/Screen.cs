using System;
using Chessboard;

namespace ChessConsole
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for(int i = 0; i < board.Rows; i++)
            {
                for(int j = 0; j < board.Columns; j++)
                {
                    if(board.ChessPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.ChessPiece(i, j) + " ");
                    }                    
                }

                Console.WriteLine();
            }
        }
    }
}
