using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.ChessPieces
{
    class Queen : Piece
    {
        String pieceType;
        String pieceColor;
        //This is the constructor, we set the initial values of the PIECE class. 
        public Queen(int _col, int _row, bool _player)
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
                pieceType = "humQueen";
                pieceColor = "White";
            }
            else
            {
                pieceType = "compQueen";
                pieceColor = "Black";
            }

            value = 900;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
