using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Board
    {
        // Wherever there is not a piece located on the board, have it as "null" in the Piece array.
        // All other locations contain Piece objects (via inheritance, Pawn, Rook, etc.) to be moved.
        public Piece[,] chessBoard;

        // Applies starting positions to board.
        public Board()
        { 
            // Player Pieces
            chessBoard[6, 0] = new ChessPieces.Pawn(6, 0, true);
            chessBoard[6, 1] = new ChessPieces.Pawn(6, 1, true);
            chessBoard[6, 2] = new ChessPieces.Pawn(6, 2, true);
            chessBoard[6, 3] = new ChessPieces.Pawn(6, 3, true);
            chessBoard[6, 4] = new ChessPieces.Pawn(6, 4, true);
            chessBoard[6, 5] = new ChessPieces.Pawn(6, 5, true);
            chessBoard[6, 6] = new ChessPieces.Pawn(6, 6, true);
            chessBoard[6, 7] = new ChessPieces.Pawn(6, 7, true);
            chessBoard[7, 0] = new ChessPieces.Rook(7, 0, true);
            chessBoard[7, 7] = new ChessPieces.Rook(7, 7, true);
            chessBoard[7, 1] = new ChessPieces.Knight(7, 1, true);
            chessBoard[7, 6] = new ChessPieces.Knight(7, 6, true);
            chessBoard[7, 2] = new ChessPieces.Bishop(7, 2, true);
            chessBoard[7, 5] = new ChessPieces.Bishop(7, 5, true);
            chessBoard[7, 4] = new ChessPieces.King(7, 4, true);
            chessBoard[7, 3] = new ChessPieces.Queen(3, 3, true);

            // PC Pieces
            chessBoard[1, 0] = new ChessPieces.Pawn(1, 0, true);
            chessBoard[1, 1] = new ChessPieces.Pawn(1, 1, true);
            chessBoard[1, 2] = new ChessPieces.Pawn(1, 2, true);
            chessBoard[1, 3] = new ChessPieces.Pawn(1, 3, true);
            chessBoard[1, 4] = new ChessPieces.Pawn(1, 4, true);
            chessBoard[1, 5] = new ChessPieces.Pawn(1, 5, true);
            chessBoard[1, 6] = new ChessPieces.Pawn(1, 6, true);
            chessBoard[1, 7] = new ChessPieces.Pawn(1, 7, true);
            chessBoard[0, 0] = new ChessPieces.Rook(0, 0, true);
            chessBoard[0, 7] = new ChessPieces.Rook(0, 7, true);
            chessBoard[0, 1] = new ChessPieces.Knight(0, 1, true);
            chessBoard[0, 6] = new ChessPieces.Knight(0, 6, true);
            chessBoard[0, 2] = new ChessPieces.Bishop(0, 2, true);
            chessBoard[0, 5] = new ChessPieces.Bishop(0, 5, true);
            chessBoard[0, 4] = new ChessPieces.King(0, 4, true);
            chessBoard[0, 3] = new ChessPieces.Queen(0, 3, true);
        }

        public void print()
        {
            //chessBoard[2, 3] = "Hi"; //test string
            for (int i = 0; i < chessBoard.Length; i++)
            {
                for(int j =0; j < chessBoard.Length; j++) 
                {
                    Console.WriteLine(chessBoard[i, j].pieceType);
                }
            }
        }
    }
}
