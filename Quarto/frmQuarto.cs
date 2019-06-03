using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarto
{
    public partial class frmQuarto : Form
    {

        private Game game;

        public frmQuarto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Quarto.Game();

            SetBoardView();

            //Show all pieces in the box
            lvPieces.DataSource = game.Pieces;                          
            
        }

        protected void SetBoardView()
        {
            //Could have been a control array. This is a bit grim.
            txtBoard00.Text = game.Board.GetPiece(0, 0).ToString();
            txtBoard01.Text = game.Board.GetPiece(0, 1).ToString();
            txtBoard02.Text = game.Board.GetPiece(0, 2).ToString();
            txtBoard03.Text = game.Board.GetPiece(0, 3).ToString();

            txtBoard10.Text = game.Board.GetPiece(1, 0).ToString();
            txtBoard11.Text = game.Board.GetPiece(1, 1).ToString();
            txtBoard12.Text = game.Board.GetPiece(1, 2).ToString();
            txtBoard13.Text = game.Board.GetPiece(1, 3).ToString();

            txtBoard20.Text = game.Board.GetPiece(2, 0).ToString();
            txtBoard21.Text = game.Board.GetPiece(2, 1).ToString();
            txtBoard22.Text = game.Board.GetPiece(2, 2).ToString();
            txtBoard23.Text = game.Board.GetPiece(2, 3).ToString();

            txtBoard30.Text = game.Board.GetPiece(3, 0).ToString();
            txtBoard31.Text = game.Board.GetPiece(3, 1).ToString();
            txtBoard32.Text = game.Board.GetPiece(3, 2).ToString();
            txtBoard33.Text = game.Board.GetPiece(3, 3).ToString();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvPieces.SelectedItem != null)
                {
                    GamePiece p = (GamePiece)lvPieces.SelectedItem;

                    txtPicked.Text = p.ToString();
                    //lvPieces.Items.Remove(lvPieces.SelectedItem);

                    game.Pick(p);

                    //Annoying old listview refresh.
                    lvPieces.DataSource = null;
                    lvPieces.DataSource = game.Pieces;
                    lvPieces.Refresh();

                    lblInstructions.Text = game.WhosNext() + " place this piece.";
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            
        }

 
        private void PlaceEvent(int row, int column)
        {
            try
            {
                if (game.State == GamesState.Place)
                {
                    game.Place(row, column);
                    txtPicked.Text = String.Empty;
                    lblInstructions.Text = game.WhosNext() + " pick a piece.";
                    SetBoardView();
                }

                if (game.State == GamesState.Win)
                {
                    lblInstructions.Text = game.WhosNext() + " wins.";

                }
                else if (game.State == GamesState.Draw)
                {
                    lblInstructions.Text = "The game is a draw.";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // All click handlers - should be able to replace this with data handed into the EventArgs

        private void txtBoard00_Click(object sender, EventArgs e)
        {
            PlaceEvent(0, 0);
        }

        private void txtBoard01_Click(object sender, EventArgs e)
        {
            PlaceEvent(0, 1);
        }

        private void txtBoard02_Click(object sender, EventArgs e)
        {
            PlaceEvent(0, 2);
        }

        private void txtBoard03_Click(object sender, EventArgs e)
        {
            PlaceEvent(0, 3);
        }

        private void txtBoard10_Click(object sender, EventArgs e)
        {
            PlaceEvent(1, 0);
        }

        private void txtBoard11_Click(object sender, EventArgs e)
        {
            PlaceEvent(1, 1);
        }

        private void txtBoard12_Click(object sender, EventArgs e)
        {
            PlaceEvent(1, 2);
        }

        private void txtBoard13_Click(object sender, EventArgs e)
        {
            PlaceEvent(1, 3);
        }

        private void txtBoard20_Click(object sender, EventArgs e)
        {
            PlaceEvent(2, 0);
        }

        private void txtBoard21_Click(object sender, EventArgs e)
        {
            PlaceEvent(2, 1);
        }

        private void txtBoard22_Click(object sender, EventArgs e)
        {
            PlaceEvent(2, 2);
        }

        private void txtBoard23_Click(object sender, EventArgs e)
        {
            PlaceEvent(2, 3);
        }

        private void txtBoard30_Click(object sender, EventArgs e)
        {
            PlaceEvent(3, 0);
        }

        private void txtBoard31_Click(object sender, EventArgs e)
        {
            PlaceEvent(3, 1);
        }

        private void txtBoard32_Click(object sender, EventArgs e)
        {
            PlaceEvent(3, 2);
        }

        private void txtBoard33_Click(object sender, EventArgs e)
        {
            PlaceEvent(3, 3);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            game = null;
            game = new Quarto.Game();

            lvPieces.DataSource = null;
            lvPieces.DataSource = game.Pieces;
            lvPieces.Refresh();
            SetBoardView();
        }
    }
}
