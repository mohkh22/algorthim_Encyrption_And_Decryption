namespace EncyrptionAndDecryption
{
    partial class frmvgn
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
            label2 = new Label();
            text = new TextBox();
            key = new TextBox();
            result = new TextBox();
            label3 = new Label();
            btnenc = new Button();
            btndec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 96);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Key";
            // 
            // text
            // 
            text.Location = new Point(100, 33);
            text.Name = "text";
            text.Size = new Size(291, 23);
            text.TabIndex = 2;
            // 
            // key
            // 
            key.Location = new Point(100, 93);
            key.Name = "key";
            key.Size = new Size(291, 23);
            key.TabIndex = 3;
            // 
            // result
            // 
            result.Location = new Point(100, 148);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(291, 23);
            result.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 156);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // btnenc
            // 
            btnenc.Location = new Point(65, 226);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(146, 41);
            btnenc.TabIndex = 6;
            btnenc.Text = "Encyrption";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click;
            // 
            // btndec
            // 
            btndec.Location = new Point(241, 226);
            btndec.Name = "btndec";
            btndec.Size = new Size(136, 41);
            btndec.TabIndex = 7;
            btndec.Text = "Decyrption";
            btndec.UseVisualStyleBackColor = true;
            btndec.Click += button2_Click;
            // 
            // frmvgn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 317);
            Controls.Add(btndec);
            Controls.Add(btnenc);
            Controls.Add(label3);
            Controls.Add(result);
            Controls.Add(key);
            Controls.Add(text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmvgn";
            Text = "Vigenere_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text;
        private TextBox key;
        private TextBox result;
        private Label label3;
        private Button btnenc;
        private Button btndec;
    }
}