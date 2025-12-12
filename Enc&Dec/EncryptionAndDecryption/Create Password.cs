using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EncyrptionAndDecryption
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changetext();

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                deletetext();
            }

        }

        private void ch1_TextChanged(object sender, EventArgs e)
        {


        }

        private void changetext()
        {
            var text = txtPass.Text;

            var lower = "abcdefghijklmnopqrstuvwxyz";
            var upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var number = "0123456789";
            var special = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";

            if (text.Length > 8)
            {
                if (!ch1.Checked)
                {
                    checkProgress();
                }
                ch1.CheckState = CheckState.Checked;
                ch1.BackColor = Color.Green;
            }
            else
            {
                ch1.CheckState = CheckState.Unchecked;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (number.Contains(text[i]))
                {
                    if (!ch2.Checked)
                    {
                        checkProgress();
                    }
                    ch2.Checked = true;
                    ch2.BackColor = Color.Green;

                }

                if (lower.Contains(text[i]))
                {
                    if (!ch3.Checked)
                    {
                        checkProgress();
                    }
                    ch3.Checked = true;
                    ch3.BackColor = Color.Green;

                }
                if (upper.Contains(text[i]))
                {
                    if (!ch4.Checked)
                    {
                        checkProgress();
                    }
                    ch4.Checked = true;
                    ch4.BackColor = Color.Green;
                }
                if (special.Contains(text[i]))
                {
                    if (!ch5.Checked)
                    {
                        checkProgress();
                    }
                    ch5.Checked = true;
                    ch5.BackColor = Color.Green;
                }
            }


            if (progress.Value < 40)
            {
                progress.ForeColor = Color.Red;
                lblstatus.Text = "Very Weak";
            }
            else if (progress.Value < 60)
            {
                progress.ForeColor = Color.Orange;
                lblstatus.Text = "Very Weak";
            }
            else if (progress.Value < 80)
            {
                progress.ForeColor = Color.Yellow;
                lblstatus.Text = "Weak";
            }
            else if (progress.Value < 100)
            {
                lblstatus.Text = "Strong";
            }
            else
            {
                progress.ForeColor = Color.Green;
                lblstatus.Text = "Very Strong";
            }
        }

        private void deletetext()
        {
            var text = txtPass.Text;

            var lower = "abcdefghijklmnopqrstuvwxyz";
            var upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var number = "0123456789";
            var special = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";

            if(text.Length == 0)
            {
                progress.Value = 0;
                ch1.Checked = false;
                ch1.BackColor = Color.LightGray;
                ch2.Checked = false;
                ch2.BackColor = Color.LightGray;
                ch3.Checked = false;
                ch3.BackColor = Color.LightGray;
                ch4.Checked = false;
                ch4.BackColor = Color.LightGray;
                ch5.Checked = false;
                ch5.BackColor = Color.LightGray;
                lblstatus.Text = " ";
            }

            if (text.Length > 8)
            {
                if (!ch1.Checked)
                {
                    checkProgress();
                }
                ch1.CheckState = CheckState.Checked;
                ch1.BackColor = Color.Green;
            }
            else
            {
                ch1.CheckState = CheckState.Unchecked;
                ch1.BackColor = Color.LightGray;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (number.Contains(text[i]))
                {
                    if (!ch2.Checked)
                    {
                        checkProgress();
                    }
                    ch2.Checked = true;
                    ch2.BackColor = Color.Green;

                }
                else
                {
                    if (ch2.Checked)
                    {
                        progress.Value -= 20;
                    }
                    ch2.Checked = false;
                    ch2.BackColor = Color.LightGray;
                }

                if (lower.Contains(text[i]))
                {
                    if (!ch3.Checked)
                    {
                        checkProgress();
                    }
                    ch3.Checked = true;
                    ch3.BackColor = Color.Green;

                }
                else
                {
                    if (ch3.Checked)
                    {
                        progress.Value -= 20;
                    }
                    ch3.Checked = false;
                    ch3.BackColor = Color.LightGray;
                }
                if (upper.Contains(text[i]))
                {
                    if (!ch4.Checked)
                    {
                        checkProgress();
                    }
                    ch4.Checked = true;
                    ch4.ForeColor = Color.Green;
                }
                else
                {
                    if (ch4.Checked)
                    {
                        progress.Value -= 20;
                    }
                    ch4.Checked = false;
                    ch4.BackColor = Color.LightGray;
                }
                if (special.Contains(text[i]))
                {
                    if (!ch5.Checked)
                    {
                        checkProgress();
                    }
                    ch5.Checked = true;
                    ch5.BackColor = Color.Green;
                }
                else
                {
                    if (ch5.Checked)
                    {
                        progress.Value -= 20;
                    }
                    ch5.Checked = false;
                    ch5.BackColor = Color.LightGray;
                }
            }


            if (progress.Value < 40)
            {
                progress.ForeColor = Color.Red;
                
                lblstatus.Text = "Very Weak";
            }
            else if (progress.Value < 60)
            {
                progress.ForeColor = Color.Orange;
                lblstatus.Text = "Very Weak";
            }
            else if (progress.Value < 80)
            {
                progress.ForeColor = Color.Yellow;
                lblstatus.Text = "Weak";
            }
            else if (progress.Value < 100)
            {
                lblstatus.Text = "Strong";
            }
            else
            {
                progress.ForeColor = Color.Green;
                lblstatus.Text = "Very Strong";
            }
        }


        private void checkProgress()
        {
            if (progress.Value < 100)
            {
                progress.Value += 20;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
