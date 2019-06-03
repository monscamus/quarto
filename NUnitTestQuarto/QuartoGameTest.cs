using NUnit.Framework;
using Quarto;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckWinRowTest()
        {
            Game game = new Game();
            Board b = game.Board;

            b.SetPiece(new GamePiece(1), 0, 0);
            b.SetPiece(new GamePiece(1), 0, 1);
            b.SetPiece(new GamePiece(1), 0, 2);
            b.SetPiece(new GamePiece(1), 0, 3);

            Assert.IsTrue(game.CheckWin());
        }

        [Test]
        public void CheckWinColumnTest()
        {
            Game game = new Game();
            Board b = game.Board;

            b.SetPiece(new GamePiece(1), 0, 0);
            b.SetPiece(new GamePiece(1), 1, 0);
            b.SetPiece(new GamePiece(1), 2, 0);
            b.SetPiece(new GamePiece(1), 3, 0);

            Assert.IsTrue(game.CheckWin());
        }

        [Test]
        public void CheckWinBlueTest()
        {
            Game game = new Game();
            Board b = game.Board;

            b.SetPiece(new GamePiece(0), 0, 0);
            b.SetPiece(new GamePiece(0), 0, 1);
            b.SetPiece(new GamePiece(0), 0, 2);
            b.SetPiece(new GamePiece(0), 0, 3);

            Assert.IsTrue(game.CheckWin());
        }

        [Test]
        public void CheckNoWinIncompleteRow()
        {
            Game game = new Game();
            Board b = game.Board;

            //incomplete row
            b.SetPiece(new Quarto.GamePiece(0), 0, 0);
            b.SetPiece(new Quarto.GamePiece(0), 0, 2);
            b.SetPiece(new Quarto.GamePiece(0), 0, 3);

            Assert.IsFalse(game.CheckWin());
        }
        [Test]
        public void CheckRed()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece(1);

            Assert.IsTrue(p.CheckAttribute(PieceType.Red));
        }

        [Test]
        public void CheckDotted()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece((int)PieceType.Dotted);

            Assert.IsTrue(p.CheckAttribute(PieceType.Dotted));
        }

        [Test]
        public void CheckRound()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece((int)PieceType.Round);

            Assert.IsTrue(p.CheckAttribute(PieceType.Round));

        }

        [Test]
        public void CheckTall()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece((int)PieceType.Tall);

            Assert.IsTrue(p.CheckAttribute(PieceType.Tall));

        }


        [Test]
        public void CheckNotTall()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece(0);

            Assert.IsTrue(!p.CheckAttribute(PieceType.Tall));

        }

        [Test]
        public void CheckEmpty()
        {
            Game game = new Game();
            Board b = game.Board;

            GamePiece p = new GamePiece(0);

            Assert.IsTrue(!p.CheckAttribute(PieceType.Empty));
        }
    }
}