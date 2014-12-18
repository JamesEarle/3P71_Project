using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.ChessPieces
{
    class Rook : Piece
    {
        String pieceType;
        String pieceColor;
        //This is the constructor for a pawn, we set the initial values of the PIECE class. 
        public Rook(int _colPosition, int _rowPosition, int _humOrComp, bool _alive, int _timesMoved)
        {
            colPosition = _colPosition;
            rowPosition = _rowPosition;
            humOrComp = _humOrComp;
            alive = _alive;
            timesMoved = _timesMoved;
            if (humOrComp == 0)
            {
                pieceType = "humRook";
                pieceColor = "White";
            }
            else
            {
                pieceType = "compRook";
                pieceColor = "Black";
            }

            value = 500;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
