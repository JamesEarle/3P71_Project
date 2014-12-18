using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Piece
    {
        public int colPosition;
        public int rowPosition;

        //0 for human, 1 for computer
        public int humOrComp;
        public bool alive;
        public int timesMoved;

        public String pieceType;
        public String pieceColor;

        public int value;

    }
}
