using System;
using Chessboard;
using Chess; 

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosition());

            Console.ReadLine();


        }
    }
}
