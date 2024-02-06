using Microsoft.VisualBasic.FileIO;
using System.DirectoryServices;
using System.Media;
using System.Net.Sockets;

namespace Combustion_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Graphics.DrawRoundedCorners(CleanButton, 10);
        }
        /////////////////////////
        // ResultButton Events //
        /////////////////////////
        private void ResultButton_MouseMove(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = Color.CornflowerBlue;
        }

        private void ResultButton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromKnownColor(KnownColor.HotTrack);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double C, H2, S, CO, CH4, C2H2, C2H4, C2H6, C3H8, C4H10, C5H12, O2;
            C = Input_C.Text == string.Empty ? 0 : Convert.ToDouble(Input_C.Text);
            H2 = Input_H2.Text == string.Empty ? 0 : Convert.ToDouble(Input_H2.Text);
            S = Input_S.Text == string.Empty ? 0 : Convert.ToDouble(Input_S.Text);
            CO = Input_CO.Text == string.Empty ? 0 : Convert.ToDouble(Input_CO.Text);
            CH4 = Input_CH4.Text == string.Empty ? 0 : Convert.ToDouble(Input_CH4.Text);
            C2H2 = Input_C2H2.Text == string.Empty ? 0 : Convert.ToDouble(Input_C2H2.Text);
            C2H4 = Input_C2H4.Text == string.Empty ? 0 : Convert.ToDouble(Input_C2H4.Text);
            C2H6 = Input_C2H6.Text == string.Empty ? 0 : Convert.ToDouble(Input_C2H6.Text);
            C3H8 = Input_C3H8.Text == string.Empty ? 0 : Convert.ToDouble(Input_C3H8.Text);
            C4H10 = Input_C4H10.Text == string.Empty ? 0 : Convert.ToDouble(Input_C4H10.Text);
            C5H12 = Input_C5H12.Text == string.Empty ? 0 : Convert.ToDouble(Input_C5H12.Text);
            O2 = Input_O2.Text == string.Empty ? 0 : Convert.ToDouble(Input_O2.Text);

            /*  double[] fuel  = { C, H2, S, CO, CH4, C2H2, C2H4, C2H6, C3H8, C4H10, C5H12 ,O2};
                Output_O2.Text = Convert.ToString( 8 * fuel[1] + fuel[2] + (8 * fuel[0] / 3) + (4 * fuel[3] / 7) +
                                                   4 * fuel[4] + (24 * fuel[6] / 7) + (40 * fuel[5] / 13) + (40 * fuel[8] / 11) +
                                                   (26 * fuel[9] / 7) + (32 * fuel[10] / 9) + (56 * fuel[7] / 15) - fuel[11] ); //By Kg-Weight
            */

            //   Inputs_All_Leave(new object(), new EventArgs());
            Output_O2.Text = Convert.ToString((8 * C / 3) + (8 * H2) + S + (4 * CO / 7) + (4 * CH4) + (40 * C2H2 / 13) +
                                              (24 * C2H4 / 7) + (56 * C2H6 / 15) + (40 * C3H8 / 11) +
                                              (26 * C4H10 / 7) + (32 * C5H12 / 9) - O2); //By Kg-Weight//
        }
        ///////////////////////
        // Inputs_All Events //
        ///////////////////////
        private void Inputs_All_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SelectNextControl((Control)sender, true, true, false, false);
                    break;
                case Keys.Up:
                    SelectNextControl((Control)sender, false, true, false, false);
                    break;
            }
        }

        private void Inputs_All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ((char)Keys.Back) ||
                e.KeyChar == ((char)Keys.Delete) || e.KeyChar == ((char)Keys.Enter))) //Check If Input Key Is Correct!//
            {
                e.Handled = true;
                new SoundPlayer().Play();
            }
            else if (e.KeyChar == ((char)Keys.Enter)) //Same But Without Sound//
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 46 && ((Control)sender).Text.Contains('.')) //Canceling Twice Decimal Dot//
            {
                e.Handled = true;
            }
        }

        private void Inputs_All_Leave(object sender, EventArgs e)
        {
            Actions.FormatInputs(control: (Control)sender);
            /* for (int i = 0; i < Inputs_All.Length; i++)
             {
                 if (true)
                 {
                     Inputs_All[i].Text = Convert.ToString(Convert.ToDouble(Inputs_All[i].Text));
                 }
             }*/
            ((Control)sender).BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void Inputs_All_Enter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.LightGray;
        }
        /////////////////////////
        // MenuMainForm Events //
        /////////////////////////
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox[] Inputs_All = { Input_C, Input_H2, Input_S, Input_CO, Input_CH4,
                                     Input_C2H2, Input_C2H4, Input_C2H6, Input_C3H8,
                                     Input_C4H10, Input_C5H12, Input_O2 };
            for (int i = 0; i < Inputs_All.Length; i++)
            {
                Inputs_All[i].Clear();
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ////////////////////////
        // CleanButton Events //
        ////////////////////////
        private void CleanButton_Click(object sender, EventArgs e)
        {
            ResetToolStripMenuItem.PerformClick();
        }

    }
}
