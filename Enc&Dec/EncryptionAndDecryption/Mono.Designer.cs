namespace EncyrptionAndDecryption
{
    partial class frmMono
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
            txtp = new TextBox();
            txtc = new TextBox();
            btnenc = new Button();
            btndec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 77);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Plain Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 145);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Cipher Text";
            // 
            // txtp
            // 
            txtp.Location = new Point(135, 74);
            txtp.Name = "txtp";
            txtp.Size = new Size(268, 23);
            txtp.TabIndex = 2;
            // 
            // txtc
            // 
            txtc.Location = new Point(135, 142);
            txtc.Name = "txtc";
            txtc.ReadOnly = true;
            txtc.Size = new Size(268, 23);
            txtc.TabIndex = 3;
            // 
            // btnenc
            // 
            btnenc.Location = new Point(90, 218);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(135, 23);
            btnenc.TabIndex = 4;
            btnenc.Text = "Encyrption";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click;
            // 
            // btndec
            // 
            btndec.Location = new Point(278, 218);
            btndec.Name = "btndec";
            btndec.Size = new Size(135, 23);
            btndec.TabIndex = 5;
            btndec.Text = "Decyrption";
            btndec.UseVisualStyleBackColor = true;
            btndec.Click += btndec_Click;
            // 
            // frmMono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btndec);
            Controls.Add(btnenc);
            Controls.Add(txtc);
            Controls.Add(txtp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMono";
            Text = "Mono";
            Load += Mono_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtp;
        private TextBox txtc;
        private Button btnenc;
        private Button btndec;
    }
}