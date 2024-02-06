namespace Combustion_Calculator
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Graphics.DrawRoundedCorners(OKbutton, 10);
            Graphics.DrawRoundedCorners(AboutTextBox, 5);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
