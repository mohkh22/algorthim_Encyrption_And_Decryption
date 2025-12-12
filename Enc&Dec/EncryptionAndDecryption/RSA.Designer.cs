namespace EncyrptionAndDecryption
{
    partial class frmrsa
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
            label1 = new Label();
            txtplain = new TextBox();
            btnenc = new Button();
            txtp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtq = new TextBox();
            txte = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            Cipher = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btndec = new Button();
            txtedec = new TextBox();
            txtqdec = new TextBox();
            Plain = new TextBox();
            txtpdec = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtplaindec = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // txtplain
            // 
            txtplain.Location = new Point(94, 31);
            txtplain.Name = "txtplain";
            txtplain.Size = new Size(193, 29);
            txtplain.TabIndex = 1;
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
            // txtp
            // 
            txtp.Location = new Point(40, 129);
            txtp.Name = "txtp";
            txtp.Size = new Size(71, 29);
            txtp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 131);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 3;
            label2.Text = "P";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(116, 131);
            label3.Name = "label3";
            label3.Size = new Size(22, 21);
            label3.TabIndex = 5;
            label3.Text = "Q";
            label3.Click += label3_Click;
            // 
            // txtq
            // 
            txtq.Location = new Point(144, 129);
            txtq.Name = "txtq";
            txtq.Size = new Size(63, 29);
            txtq.TabIndex = 6;
            txtq.TextChanged += textBox3_TextChanged;
            // 
            // txte
            // 
            txte.Location = new Point(247, 129);
            txte.Name = "txte";
            txte.Size = new Size(63, 29);
            txte.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(219, 131);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 7;
            label4.Tag = "";
            label4.Text = "E";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cipher);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txte);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtq);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnenc);
            groupBox1.Controls.Add(txtplain);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 320);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encryption";
            // 
            // Cipher
            // 
            Cipher.Location = new Point(110, 178);
            Cipher.Name = "Cipher";
            Cipher.Size = new Size(193, 29);
            Cipher.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 181);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 10;
            label6.Text = "CipherText";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(76, 85);
            label5.Name = "label5";
            label5.Size = new Size(179, 21);
            label5.TabIndex = 9;
            label5.Text = "--------- Option ---------";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btndec);
            groupBox2.Controls.Add(txtedec);
            groupBox2.Controls.Add(txtqdec);
            groupBox2.Controls.Add(Plain);
            groupBox2.Controls.Add(txtpdec);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtplaindec);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(413, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 320);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Decryption";
            // 
            // btndec
            // 
            btndec.Location = new Point(110, 232);
            btndec.Name = "btndec";
            btndec.Size = new Size(139, 44);
            btndec.TabIndex = 12;
            btndec.Text = "Decryption";
            btndec.UseVisualStyleBackColor = true;
            btndec.Click += btndec_Click;
            // 
            // txtedec
            // 
            txtedec.Location = new Point(240, 129);
            txtedec.Name = "txtedec";
            txtedec.Size = new Size(63, 29);
            txtedec.TabIndex = 14;
            // 
            // txtqdec
            // 
            txtqdec.Location = new Point(137, 129);
            txtqdec.Name = "txtqdec";
            txtqdec.Size = new Size(63, 29);
            txtqdec.TabIndex = 13;
            // 
            // Plain
            // 
            Plain.Location = new Point(110, 178);
            Plain.Name = "Plain";
            Plain.Size = new Size(193, 29);
            Plain.TabIndex = 11;
            // 
            // txtpdec
            // 
            txtpdec.Location = new Point(33, 129);
            txtpdec.Name = "txtpdec";
            txtpdec.Size = new Size(71, 29);
            txtpdec.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(12, 181);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 10;
            label7.Text = "PlainText";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(219, 131);
            label9.Name = "label9";
            label9.Size = new Size(19, 21);
            label9.TabIndex = 7;
            label9.Tag = "";
            label9.Text = "E";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(116, 131);
            label10.Name = "label10";
            label10.Size = new Size(22, 21);
            label10.TabIndex = 5;
            label10.Text = "Q";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(14, 131);
            label11.Name = "label11";
            label11.Size = new Size(20, 21);
            label11.TabIndex = 3;
            label11.Text = "P";
            // 
            // txtplaindec
            // 
            txtplaindec.Location = new Point(105, 31);
            txtplaindec.Name = "txtplaindec";
            txtplaindec.Size = new Size(193, 29);
            txtplaindec.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(7, 34);
            label12.Name = "label12";
            label12.Size = new Size(92, 21);
            label12.TabIndex = 0;
            label12.Text = "CipherText";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(225, 21);
            label13.Name = "label13";
            label13.Size = new Size(326, 25);
            label13.TabIndex = 13;
            label13.Text = "Please Your letter Message is Upper";
            // 
            // frmrsa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmrsa";
            Text = "RSA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtplain;
        private Button btnenc;
        private TextBox txtp;
        private Label label2;
        private Label label3;
        private TextBox txtq;
        private TextBox txte;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox Cipher;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox Plain;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox4;
        private Label label11;
        private Button button1;
        private TextBox txtplaindec;
        private Label label12;
        private Button btndec;
        private TextBox txtedec;
        private TextBox txtqdec;
        private TextBox txtpdec;
        private Label label13;
    }
}