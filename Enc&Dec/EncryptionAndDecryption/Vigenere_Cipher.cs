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
    public partial class frmvgn : Form
    {
        public frmvgn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = PolyAlphabetic.VgnDecryption(text.Text, key.Text);

        }

        private void btnenc_Click(object sender, EventArgs e)
        {
            result.Text = PolyAlphabetic.VgnEncyrption(text.Text , key.Text );
        }
    }
}
