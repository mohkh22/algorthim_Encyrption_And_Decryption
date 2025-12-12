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
    public partial class frmMono : Form
    {
        public frmMono()
        {
            InitializeComponent();
        }

        private void Mono_Load(object sender, EventArgs e)
        {

        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            txtc.Text = Monoalphabetic.Encyrption(txtp.Text);
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            txtc.Text = Monoalphabetic.Decryption(txtp.Text);
        }
    }
}
