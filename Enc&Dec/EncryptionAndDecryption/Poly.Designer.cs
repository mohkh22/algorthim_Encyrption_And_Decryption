namespace EncyrptionAndDecryption
{
    partial class frmPoly
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
            btnenc = new Button();
            key = new TextBox();
            txtp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbltxt = new Label();
            txtdec = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // result
            // 
            result.Location = new Point(79, 111);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(282, 23);
            result.TabIndex = 26;
            // 
            // btnenc
            // 
            btnenc.Location = new Point(97, 162);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(210, 23);
            btnenc.TabIndex = 24;
            btnenc.Text = "Encyrpt";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click_1;
            // 
            // key
            // 
            key.Location = new Point(79, 70);
            key.Name = "key";
            key.Size = new Size(282, 23);
            key.TabIndex = 23;
            // 
            // txtp
            // 
            txtp.Location = new Point(79, 28);
            txtp.Name = "txtp";
            txtp.Size = new Size(282, 23);
            txtp.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 73);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 21;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 20;
            label1.Text = "Text";
            // 
            // lbltxt
            // 
            lbltxt.AutoSize = true;
            lbltxt.Location = new Point(18, 51);
            lbltxt.Name = "lbltxt";
            lbltxt.Size = new Size(0, 15);
            lbltxt.TabIndex = 19;
            // 
            // txtdec
            // 
            txtdec.Location = new Point(93, 20);
            txtdec.Name = "txtdec";
            txtdec.Size = new Size(282, 23);
            txtdec.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 23);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 17;
            label3.Text = "Text";
            // 
            // button1
            // 
            button1.Location = new Point(126, 484);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 16;
            button1.Text = "Decyrpt Without Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbltxt);
            groupBox1.Controls.Add(txtdec);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(392, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 527);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decrypt Without  Key ";
            // 
            // frmPoly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 543);
            Controls.Add(result);
            Controls.Add(btnenc);
            Controls.Add(key);
            Controls.Add(txtp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmPoly";
            Text = "BruteForce";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result;
        private Button btnenc;
        private TextBox key;
        private TextBox txtp;
        private Label label2;
        private Label label1;
        private Label lbltxt;
        private TextBox txtdec;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
    }
}