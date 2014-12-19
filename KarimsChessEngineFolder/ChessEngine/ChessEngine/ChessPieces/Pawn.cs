using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.ChessPieces
{
    class Pawn : Piece
    {
        //This is the constructor for a pawn, we set the initial values of the PIECE class. 
        public Pawn(int _col, int _row, bool _player)
        {
            col = _col;
            row = _row;
            player = _player;

            // When initializing a new piece, these values will always be true and 0. 
            // Removed as parameters.
            alive = true;
            timesMoved = 0;

            if (player)
            {
                pieceType = "humPawn";
                pieceColor = "White";
            }
            else
            {
                pieceType = "compPawn";
                pieceColor = "Black";
            }

            value = 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
