using EncryptionAndDecryption;
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
    public partial class frmCaesar : Form
    {
        public frmCaesar()
        {
            InitializeComponent();
        }

        private void btnenc_Click_1(object sender, EventArgs e)
        {
            result.Text = CaesarCipher.Encyrption(text.Text, int.Parse(key.Text));

        }

        private void btndec_Click_1(object sender, EventArgs e)
        {
            result.Text = CaesarCipher.Decryption(text.Text, int.Parse(key.Text));

        }


       
    }
}
