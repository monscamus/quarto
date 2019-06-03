using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{

    /// <summary>
    /// Holds GamePieces or empty squares for the game. Can return columns and rows
    /// as a square board. Acts as the model for the game data.
    /// </summary>
    public class Board
    {
        private GamePiece[,] board;        //Squares may be empty of gamepieces.
        private int size = 4;

        /// <summary>
        /// Creates a standard board with "empty" pieces in it's squares.
        /// </summary>
        public Board()
        {
            board = new GamePiece[Size, Size];

            FillEmpty();            
        }

        /// <summary>
        /// Novelty constructor for making bigger boards. However for simplicity let's keep it square!
        /// </summary>
        /// <param name="size">Allow the caller to set the board size.</param>
        public Board(int size)
        {
            board = new GamePiece[Size, Size];

            FillEmpty();
        }

        public GamePiece[] GetColumn(int c)
        {
            GamePiece[] t = new GamePiece[Size];

            for (int i = 0; i < Size; i++)
                t[i] = board[i, c];

            return t;
        }

        public GamePiece[] GetRow(int r)
        {
            GamePiece[] t = new GamePiece[Size];

            for (int i = 0; i < Size; i++)
                t[i] = board[r, i];

            return t;
        }

        public GamePiece GetPiece(int row, int column) 
        {
            if (row > Size || row < 0 || column > Size || column < 0) throw new Exception("Piece requested from a square not on the board.");
            return board[column, row];
        }

        public GamePiece SetPiece(GamePiece p, int row, int column)
        {
            if (row > Size || row < 0 || column > Size || column < 0) throw new Exception("Piece requested at a square not on the board.");
            board[column, row] = p;

            return board[column, row];
        }

        public int Size
        {
            get { return size; }
        }

        private void FillEmpty()
        {
            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++)
                {
                    board[i, j] = new GamePiece((int)PieceType.Empty);
                }
            }

        }
    }
}
