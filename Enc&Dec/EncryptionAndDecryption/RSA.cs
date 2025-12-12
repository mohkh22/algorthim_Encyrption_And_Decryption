using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyrptionAndDecryption
{
    public partial class frmrsa : Form
    {
        public frmrsa()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            var obj = RSAEnc_Dec.Encryption(txtplain.Text, txtp.Text, txtq.Text, txte.Text); 
            Cipher.Text = obj.result ;
            txtp.Text = obj.p.ToString();
            txtq.Text = obj.q.ToString();
            txte.Text = obj.e.ToString();
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            Plain.Text = RSAEnc_Dec.Decryption(txtplain.Text, int.Parse(txtp.Text), int.Parse(txtq.Text), int.Parse(txte.Text));

        }
    }
}
