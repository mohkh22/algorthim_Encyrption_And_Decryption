using EncyrptionAndDecryption;

namespace EncryptionAndDecryption
{
    public partial class EncyrptionAndDecryption : Form
    {
        public EncyrptionAndDecryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMono frm = new frmMono();
            frm.Show();
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            frmCaesar frm = new frmCaesar();
            frm.Show();
        }

        private void btnpoly_Click(object sender, EventArgs e)
        {
            frmPoly frm = new frmPoly();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show();
        }

        private void btnvgn_Click(object sender, EventArgs e)
        {
            frmvgn frm = new frmvgn();
            frm.Show();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            frmplay frm = new frmplay();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmsql();
            frm.Show();
        }

        private void btnanother_Click(object sender, EventArgs e)
        {
            frmAuto frm = new frmAuto();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAffine frm = new frmAffine();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHill frm = new frmHill();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmother frm = new frmother();
            frm.Show();
        }
    }
}
