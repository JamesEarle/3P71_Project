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
            this.ShowDialog();
        }

        private void A8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                BoardPanel.Controls.IndexOf(A8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(B8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(C8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(D8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(E8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(F8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(G8).ToString()
                + "\n" + BoardPanel.Controls.IndexOf(H8).ToString()
                );
            //BoardPanel.Controls.Remove(A8);
            //BoardPanel.Controls.Add(A7, 0, 0);
            Swap_Tiles(A8, C4);
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
    }
}
