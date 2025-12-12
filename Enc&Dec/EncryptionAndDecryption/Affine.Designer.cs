namespace EncyrptionAndDecryption
{
    partial class frmAffine
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
            result = new TextBox();
            btndec = new Button();
            btnenc = new Button();
            keyA = new TextBox();
            text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            KeyB = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // result
            // 
            result.Location = new Point(61, 130);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(282, 23);
            result.TabIndex = 29;
            // 
            // btndec
            // 
            btndec.Location = new Point(215, 159);
            btndec.Name = "btndec";
            btndec.Size = new Size(148, 23);
            btndec.TabIndex = 28;
            btndec.Text = "Decyrpt";
            btndec.Click += btndec_Click;
            // 
            // btnenc
            // 
            btnenc.Location = new Point(40, 159);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(147, 23);
            btnenc.TabIndex = 27;
            btnenc.Text = "Encyrpt";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click;
            // 
            // keyA
            // 
            keyA.Location = new Point(43, 16);
            keyA.Name = "keyA";
            keyA.Size = new Size(67, 23);
            keyA.TabIndex = 26;
            keyA.Text = "17";
            // 
            // text
            // 
            text.Location = new Point(61, 24);
            text.Name = "text";
            text.Size = new Size(282, 23);
            text.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 19);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 24;
            label2.Text = "A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 23;
            label1.Text = "Text";
            // 
            // KeyB
            // 
            KeyB.Location = new Point(177, 16);
            KeyB.Name = "KeyB";
            KeyB.Size = new Size(67, 23);
            KeyB.TabIndex = 31;
            KeyB.Text = "20";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 19);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 30;
            label3.Text = "B";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(KeyB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(keyA);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(64, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 53);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Key";
            // 
            // frmAffine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 230);
            Controls.Add(groupBox1);
            Controls.Add(result);
            Controls.Add(btndec);
            Controls.Add(btnenc);
            Controls.Add(text);
            Controls.Add(label1);
            Name = "frmAffine";
            Text = "Affine";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result;
        private Button btndec;
        private Button btnenc;
        private TextBox keyA;
        private TextBox text;
        private Label label2;
        private Label label1;
        private TextBox KeyB;
        private Label label3;
        private GroupBox groupBox1;
    }
}