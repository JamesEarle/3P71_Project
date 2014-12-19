using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Piece
    {
        /* Can use this array to assign/alter the type of a piece (e.g. pawn to queen) */
        public String[] types = {"King", "Queen", "Bishop", "Knight", "Rook", "Pawn", };

        public int col;
        public int row;

        //"int humOrComp" changed to "bool player"
        //false for PC, true for human.
        public bool player;
        public bool alive;

        public int timesMoved;

        public String pieceType;
        public String pieceColor;

        public int value;

    }
}
