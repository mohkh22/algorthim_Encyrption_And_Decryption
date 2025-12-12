namespace EncryptionAndDecryption
{
    partial class EncyrptionAndDecryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCaesar = new Button();
            btnmono = new Button();
            btnauto = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnanother = new Button();
            btnplay = new Button();
            btnvgn = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCaesar
            // 
            btnCaesar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaesar.Location = new Point(22, 45);
            btnCaesar.Name = "btnCaesar";
            btnCaesar.Size = new Size(232, 53);
            btnCaesar.TabIndex = 1;
            btnCaesar.Text = "Caesar Cipher";
            btnCaesar.UseVisualStyleBackColor = true;
            btnCaesar.Click += btnCaesar_Click;
            // 
            // btnmono
            // 
            btnmono.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmono.Location = new Point(288, 45);
            btnmono.Name = "btnmono";
            btnmono.Size = new Size(232, 53);
            btnmono.TabIndex = 2;
            btnmono.Text = "Mono-Alphabetic";
            btnmono.UseVisualStyleBackColor = true;
            btnmono.Click += button1_Click;
            // 
            // btnauto
            // 
            btnauto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnauto.Location = new Point(555, 45);
            btnauto.Name = "btnauto";
            btnauto.Size = new Size(232, 53);
            btnauto.TabIndex = 3;
            btnauto.Text = "Brute Force";
            btnauto.UseVisualStyleBackColor = true;
            btnauto.Click += btnpoly_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(112, 31);
            button1.Name = "button1";
            button1.Size = new Size(307, 53);
            button1.TabIndex = 4;
            button1.Text = "Make Password Strength";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnanother);
            groupBox1.Controls.Add(btnplay);
            groupBox1.Controls.Add(btnvgn);
            groupBox1.Controls.Add(btnauto);
            groupBox1.Controls.Add(btnmono);
            groupBox1.Controls.Add(btnCaesar);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 318);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Make Encyrption And Decryption Using ";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(555, 199);
            button5.Name = "button5";
            button5.Size = new Size(232, 53);
            button5.TabIndex = 9;
            button5.Text = "Other";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(22, 199);
            button4.Name = "button4";
            button4.Size = new Size(232, 53);
            button4.TabIndex = 8;
            button4.Text = "Affine Cipher";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(288, 199);
            button3.Name = "button3";
            button3.Size = new Size(232, 53);
            button3.TabIndex = 7;
            button3.Text = "Hill Cipher";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnanother
            // 
            btnanother.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnanother.Location = new Point(555, 120);
            btnanother.Name = "btnanother";
            btnanother.Size = new Size(232, 53);
            btnanother.TabIndex = 6;
            btnanother.Text = "Auto Key";
            btnanother.UseVisualStyleBackColor = true;
            btnanother.Click += btnanother_Click;
            // 
            // btnplay
            // 
            btnplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplay.Location = new Point(288, 120);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(232, 53);
            btnplay.TabIndex = 5;
            btnplay.Text = "Playfair Cipher";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // btnvgn
            // 
            btnvgn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvgn.Location = new Point(22, 120);
            btnvgn.Name = "btnvgn";
            btnvgn.Size = new Size(232, 53);
            btnvgn.TabIndex = 4;
            btnvgn.Text = "Vigenère Cipher";
            btnvgn.UseVisualStyleBackColor = true;
            btnvgn.Click += btnvgn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(458, 31);
            button2.Name = "button2";
            button2.Size = new Size(307, 53);
            button2.TabIndex = 6;
            button2.Text = "Sql_Injection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EncyrptionAndDecryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 465);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "EncyrptionAndDecryption";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCaesar;
        private Button btnmono;
        private Button btnauto;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnvgn;
        private Button btnplay;
        private Button btnanother;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
