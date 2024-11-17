namespace WorkWithMdiAndShowDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rENGÝNÝDEÐÝÞTÝRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;

            }


          
        }
    }
}
