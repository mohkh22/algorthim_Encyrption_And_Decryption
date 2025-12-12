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
    public partial class frmother : Form
    {
        public frmother()
        {
            InitializeComponent();
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            var obj = OtherEnc_dec.Encryption(txtplain.Text);
            Cipher.Text =obj.cipher ;
            txtk.Text = obj.key;
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            plain.Text = OtherEnc_dec.Decryption(txtcipher.Text, txtkdec.Text);
        }
    }
}
