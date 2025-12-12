namespace EncyrptionAndDecryption
{
    partial class frmother
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Cipher = new TextBox();
            label6 = new Label();
            txtk = new TextBox();
            label2 = new Label();
            btnenc = new Button();
            txtplain = new TextBox();
            label1 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
            txtkdec = new TextBox();
            label3 = new Label();
            plain = new TextBox();
            label7 = new Label();
            btndec = new Button();
            txtcipher = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cipher);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtk);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnenc);
            groupBox1.Controls.Add(txtplain);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encryption";
            // 
            // Cipher
            // 
            Cipher.Location = new Point(94, 175);
            Cipher.Name = "Cipher";
            Cipher.Size = new Size(193, 29);
            Cipher.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(0, 178);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 10;
            label6.Text = "CipherText";
            // 
            // txtk
            // 
            txtk.Location = new Point(94, 101);
            txtk.Name = "txtk";
            txtk.ReadOnly = true;
            txtk.Size = new Size(193, 29);
            txtk.TabIndex = 4;
            txtk.TextChanged += txtp_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 3;
            label2.Text = "Key";
            // 
            // btnenc
            // 
            btnenc.Location = new Point(99, 232);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(139, 44);
            btnenc.TabIndex = 2;
            btnenc.Text = "Encryption";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click;
            // 
            // txtplain
            // 
            txtplain.Location = new Point(94, 31);
            txtplain.Name = "txtplain";
            txtplain.Size = new Size(193, 29);
            txtplain.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "PlainText";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(221, 22);
            label13.Name = "label13";
            label13.Size = new Size(326, 25);
            label13.TabIndex = 14;
            label13.Text = "Please Your letter Message is Upper";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtkdec);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(plain);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btndec);
            groupBox2.Controls.Add(txtcipher);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(396, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 320);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Decryption";
            // 
            // txtkdec
            // 
            txtkdec.Location = new Point(94, 101);
            txtkdec.Name = "txtkdec";
            txtkdec.Size = new Size(193, 29);
            txtkdec.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 12;
            label3.Text = "Key";
            // 
            // plain
            // 
            plain.Location = new Point(94, 178);
            plain.Name = "plain";
            plain.Size = new Size(193, 29);
            plain.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(0, 34);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 10;
            label7.Text = "CipherText";
            // 
            // btndec
            // 
            btndec.Location = new Point(99, 232);
            btndec.Name = "btndec";
            btndec.Size = new Size(139, 44);
            btndec.TabIndex = 2;
            btndec.Text = "Decryption";
            btndec.UseVisualStyleBackColor = true;
            btndec.Click += btndec_Click;
            // 
            // txtcipher
            // 
            txtcipher.Location = new Point(94, 31);
            txtcipher.Name = "txtcipher";
            txtcipher.Size = new Size(193, 29);
            txtcipher.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(6, 186);
            label12.Name = "label12";
            label12.Size = new Size(81, 21);
            label12.TabIndex = 0;
            label12.Text = "PlainText";
            label12.Click += label12_Click;
            // 
            // frmother
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Name = "frmother";
            Text = "other";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Cipher;
        private Label label6;
        private TextBox txtk;
        private Label label2;
        private Button btnenc;
        private TextBox txtplain;
        private Label label1;
        private Label label13;
        private GroupBox groupBox2;
        private TextBox plain;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox4;
        private Label label11;
        private Button btndec;
        private TextBox txtcipher;
        private Label label12;
        private TextBox txtkdec;
        private Label label3;
    }
}