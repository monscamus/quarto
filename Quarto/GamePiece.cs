using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{
    [Flags]
    public enum PieceType
    {
        Red = 1,
        Tall = 2,
        Dotted = 4,
        Round = 8,
        Empty = 16
    }

    public struct GamePiece
    {
        int properties;

        public GamePiece(int Properties)
        {
            this.properties = Properties;
        }

        public int Properties {
            get { return properties;}
        }

        /// <summary>
        /// Use case for "tall" pieces, r and B for red and blue, "."s for dots and [] () for square and round.
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {            
            if (CheckAttribute(PieceType.Empty)) return " ";

            String pieceProfile = String.Empty;

            pieceProfile = CheckAttribute(PieceType.Red) ?
                CheckAttribute(PieceType.Tall) ? "R" : "r" : 
                CheckAttribute(PieceType.Tall) ? "B" : "b";

            pieceProfile = CheckAttribute(PieceType.Dotted) ?                 
                "." + pieceProfile + ".": " " + pieceProfile + " ";

            pieceProfile = CheckAttribute(PieceType.Round) ?
                "(" + pieceProfile + ")" : "[" + pieceProfile + "]";

            return pieceProfile;
        }

        public bool CheckAttribute(PieceType type)
        {
            return (this.properties & (int)type) > 0;
        }
    }

    

}
