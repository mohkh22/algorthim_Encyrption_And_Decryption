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
    public partial class frmHill : Form
    {
        public frmHill()
        {
            InitializeComponent();
        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            result.Text = Hillenc_dec.Encyrption(text.Text, key.Text);
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            result.Text = Hillenc_dec.Dencyrption(text.Text, key.Text);

        }
    }
}
