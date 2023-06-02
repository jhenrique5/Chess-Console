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
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.Board);
                    Console.WriteLine();
                    Console.WriteLine("Turn: " + match.Turn);
                    Console.WriteLine("Waiting for move: " + match.CurrentPlayer);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    bool[,] possibleMoves = match.Board.ChessPiece(origin).PossibleMoves();

                    Console.Clear();
                    Screen.PrintBoard(match.Board, possibleMoves);

                    Console.WriteLine();
                    Console.Write("Destination: ");
                    Position destination = Screen.ReadChessPosition().ToPosition();

                    match.ExecuteMovement(origin, destination);
                }

                
            }
            catch (ChessboardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();


        }
    }
}
