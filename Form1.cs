namespace Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = textBox1.Text;
                int key = int.Parse(textBox2.Text);

                CaesarCipher cipher = new CaesarCipher(key);

                string encrypted = cipher.Encrypt(plainText);

                label4.Text = "Encrypted Text: " + encrypted;
            }

            catch
            {
                MessageBox.Show("Please enter a valid key (number only).");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherText = textBox1.Text;
                int key = int.Parse(textBox2.Text);

                CaesarCipher cipher = new CaesarCipher(key);
                string decrypted = cipher.Decrypt(cipherText);

                label4.Text = "Decrypted Text: " + decrypted;
            }
            catch
            {
                MessageBox.Show("Please enter a valid key (number only).");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MonoAlphabeticCipher cipher = new MonoAlphabeticCipher(textBox3.Text);
            label5.Text = cipher.Encrypt(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MonoAlphabeticCipher cipher = new MonoAlphabeticCipher(textBox3.Text);
            label5.Text = cipher.Decrypt(textBox4.Text);

        }

        
    }
}
