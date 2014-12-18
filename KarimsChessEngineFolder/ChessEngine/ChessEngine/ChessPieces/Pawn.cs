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
        public Pawn(int _colPosition, int _rowPosition, int _humOrComp, bool _alive, int _timesMoved)
        {
            colPosition = _colPosition;
            rowPosition = _rowPosition;
            humOrComp = _humOrComp;
            alive = _alive;
            timesMoved = _timesMoved;
            if (humOrComp == 0)
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
