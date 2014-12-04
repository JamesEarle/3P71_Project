using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void A8_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(
                BoardPanel.Controls.IndexOf(A8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(B8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(C8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(D8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(E8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(F8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(G8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(H8).ToString()
                );
             * 
             * 
             * TODO: Prompt event listener when you click a tile, and then once you click 
             * another tile it will interpret this as a move. If the move is valid, it will make that move by 
             * swapping out the necessary images on the board.
             */ 
            //Below code successfully swaps images on A8 tile
            if (!Boolean.Equals(A8.BackgroundImage, null))
            {
                A8.BackgroundImage = null;
            }
            else
            {
                A8.BackgroundImage = global::ChessMain.Properties.Resources.white_rook_w;
            }
        }

        private void Swap_Tiles(PictureBox a, PictureBox b)
        {
            MessageBox.Show(BoardPanel.Controls.IndexOf(a).ToString() + "\n" +
                BoardPanel.Controls.IndexOf(b).ToString());

            int i = BoardPanel.Controls.IndexOf(a);
            int j = BoardPanel.Controls.IndexOf(b);

            BoardPanel.Controls.RemoveAt(i);
            BoardPanel.Controls.Add(b);

            //TODO
            /* Figure out the logic to transferring tiles between spaces in the grid.
             *
             * Mainly problematic due to the fact that insertion uses array indices such as
             * add(object,0,0) or add(object,2,1)
             * but indexOf(object) returns 0 <= val < n*n -1 labeled in row major
             * add(C4,4,2) is that location, but the indexOf will return 20.
             */

        }

        private void A6_Click(object sender, EventArgs e)
        {

        }

        private void B5_Click(object sender, EventArgs e)
        {

        }

        private void C4_Click(object sender, EventArgs e)
        {

        }

        private void D3_Click(object sender, EventArgs e)
        {

        }

        private void E2_Click(object sender, EventArgs e)
        {

        }

        private void F1_Click(object sender, EventArgs e)
        {

        }

        private void G2_Click(object sender, EventArgs e)
        {

        }

        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void H3_Click(object sender, EventArgs e)
        {

        }

        private void G4_Click(object sender, EventArgs e)
        {

        }

        private void H5_Click(object sender, EventArgs e)
        {

        }

        private void G6_Click(object sender, EventArgs e)
        {

        }

        private void F5_Click(object sender, EventArgs e)
        {

        }

        private void E6_Click(object sender, EventArgs e)
        {

        }

        private void D5_Click(object sender, EventArgs e)
        {

        }

        private void C6_Click(object sender, EventArgs e)
        {

        }

        private void A4_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void D1_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (!Boolean.Equals(B8.BackgroundImage, null))
            {
                B8.BackgroundImage = null;
            }
            else
            {
                B8.BackgroundImage = global::ChessMain.Properties.Resources.white_rook_w;
            }
        }
    }
}
