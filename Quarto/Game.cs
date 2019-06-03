using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{
    public enum Players
    {
        Player1,
        Player2
    }

    public enum GamesState
    {
        Pick,
        Place,
        Draw,
        Win
    }

    public class Game
    {
        # region Member variables
        private List<GamePiece> pieces;
        private Board board = new Board();
        private static int NumberOfPieces = 16;
        Players turn = Players.Player1;
        GamesState state = GamesState.Pick;
        GamePiece activePiece;
        GamePiece[] winData;
        #endregion

        public Game()
        {
            Initialize();
        }

        /// <summary>
        /// Check to see if a win condition exists on the board i.e. a row or column with a common property.
        /// Here we are allowing for bigger and weird shaped boards (but not jagged). Note the need to check
        /// for empty slots first on the table this may a weakness in the flag.Empty.
        /// </summary>
        public Boolean CheckWin()
        {
            bool hasEmpties = false;

            //Check rows
            for (int i = 0; i < board.Size; i++)
            {
                GamePiece[] row = board.GetRow(i);
                foreach (GamePiece p in row)
                    if (p.CheckAttribute(PieceType.Empty))
                        hasEmpties = true;

                if (!hasEmpties && CheckGroup(row)) return true;
                
                hasEmpties = false;
            }


            //Check columns
            for (int i = 0; i < board.Size; i++)
            {
                GamePiece[] column = board.GetColumn(i);

                foreach (GamePiece p in column)
                    if (p.CheckAttribute(PieceType.Empty))
                        hasEmpties = true;

                if (!hasEmpties && CheckGroup(column)) return true;

                hasEmpties = false;
            }

            //TODO: Return better WIN data so that the UI can highlight it.

            return false;
        }

        /// <summary>
        /// Checks all items in the array to see if they match an attribute or it's opposite (e.g. all Red or all NOT red)
        ///  - all squares in group must contain a GamePiece.
        /// </summary>
        /// <param name="cg">An array of pieces that should be checked for a common attribute.</param>
        /// <returns>True if a common attribute exists across the pieces, i.e. someone has won.</returns>
        private bool CheckGroup(GamePiece[] cg)
        {
            PieceType[] validTypes = new PieceType[] { PieceType.Dotted, PieceType.Red, PieceType.Round, PieceType.Tall };

            foreach (PieceType pt in validTypes) {
                bool winline = true;

                foreach (GamePiece p in cg)
                {
                    winline = winline && p.CheckAttribute(pt);
                }
                //They all match stop and return a win
                if (winline) return winline;

                //Check all opposites { Undotted, Blue, Square, Short}
                winline = true;

                foreach (GamePiece p in cg)
                {
                    winline = winline && !p.CheckAttribute(pt);
                }

                //They all match stop and return a win
                if (winline) return winline;
            }


            return false;
        }

        /// <summary>
        /// Sets up a collection of the pieces to play, each piece has four binary attributes (tall/short, red/blue, 
        /// dotted/undotted, round/square).
        /// </summary>
        void Initialize()
        {
            pieces = new List<GamePiece>();
                
            //Each piece is described by 4 attributes and no two are the same - a bit simpler than generating them by symmetries 
            for(UInt16 i=0; i<NumberOfPieces; i++)
                pieces.Add(new GamePiece(i));

        }

        public List<GamePiece> Pieces
        {
            get { return pieces; }
        }

        public Board Board
        {
            get { return board; }
        }

        /// <summary>
        /// Returns the current game situation picking or placing.
        /// </summary>
        public GamesState State
        {
            get { return state; }
        }

        public void Pick(GamePiece p) 
        {
            if (State == GamesState.Pick)
            {
                //Take the piece from the "box" so that it can't be picked again.
                pieces.Remove(p);

                activePiece = p;
                state = GamesState.Place;

                NextPlayer();
            } else
                throw new ApplicationException("Wrong game state to pick a piece.");
        }

        public void Place(int row, int column)
        {

            if (State == GamesState.Place)
            {
                //Check the space is empty
                if (!Board.GetPiece(row, column).CheckAttribute(PieceType.Empty)) throw new ApplicationException("That board square is not empty.");

                Board.SetPiece(activePiece, row, column);

                //See if this creates a line of attributes
                if (CheckWin())
                {
                    //Set state to won.
                    state = GamesState.Win;

                } else if(Pieces.Count == 0)
                {
                    //No pieces left and it's not a win.
                    state = GamesState.Draw;
                } else
                {
                    //Not a win with piece left, continue.
                    NextPlayer();

                    state = GamesState.Pick;
                }                
            }
            else
                throw new ApplicationException("Not the right stage to pick a piece.");
        }    

        public string WhosNext()
        {
            if (turn == Players.Player1)
                return "Player 1";
            else
                return "Player 2";
        }

        public void NextPlayer()
        {
            if (turn == Players.Player1)
                turn = Players.Player2;
            else
                turn = Players.Player1;
        }
    }
}
