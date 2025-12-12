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
    public partial class frmAffine : Form
    {
        public frmAffine()
        {
            InitializeComponent();
        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            result.Text = AffineEnc_dec.Encyrption(text.Text, int.Parse(keyA.Text), int.Parse(KeyB.Text));
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            result.Text = AffineEnc_dec.Dencyrption(text.Text, int.Parse(keyA.Text), int.Parse(KeyB.Text));
        }
    }
}
