namespace RekenmachineOpdracht_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGetal1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);

            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dResultaat = Math.Pow(dGetal1, dGetal2);
            string sResultaat = dResultaat.ToString();
            tbGetal3.Text = sResultaat;
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);
            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dSom = dGetal1 + dGetal2;
            string sSom = dSom.ToString();
            tbGetal3.Text = sSom;
        }

        private void tbGetal3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultaatM_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);
            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dSom = dGetal1 - dGetal2;
            string sSom = dSom.ToString();
            tbGetal3.Text = sSom;
        }

        private void btnResultaatX_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);
            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dSom = dGetal1 * dGetal2;
            string sSom = dSom.ToString();
            tbGetal3.Text = sSom;
        }

        private void btnResultaatD_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);
            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dSom = dGetal1 / dGetal2;
            string sSom = dSom.ToString();
            tbGetal3.Text = sSom;
        }

        private void btnResultaatW_Click(object sender, EventArgs e)
        {
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1);
            double dResultaat = Math.Sqrt(dGetal1);
            string sResultaat = dResultaat.ToString();
            tbGetal3.Text = sResultaat;
        }
    }
}
