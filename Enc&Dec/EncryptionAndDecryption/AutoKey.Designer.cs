namespace EncyrptionAndDecryption
{
    partial class frmAuto
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
            key = new TextBox();
            text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // result
            // 
            result.Location = new Point(74, 112);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(282, 23);
            result.TabIndex = 22;
            // 
            // btndec
            // 
            btndec.Location = new Point(228, 164);
            btndec.Name = "btndec";
            btndec.Size = new Size(148, 23);
            btndec.TabIndex = 21;
            btndec.Text = "Decyrpt";
            btndec.Click += btndec_Click;
            // 
            // btnenc
            // 
            btnenc.Location = new Point(53, 164);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(147, 23);
            btnenc.TabIndex = 20;
            btnenc.Text = "Encyrpt";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click;
            // 
            // key
            // 
            key.Location = new Point(74, 71);
            key.Name = "key";
            key.Size = new Size(282, 23);
            key.TabIndex = 19;
            // 
            // text
            // 
            text.Location = new Point(74, 29);
            text.Name = "text";
            text.Size = new Size(282, 23);
            text.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 17;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 16;
            label1.Text = "Text";
            // 
            // frmAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 228);
            Controls.Add(result);
            Controls.Add(btndec);
            Controls.Add(btnenc);
            Controls.Add(key);
            Controls.Add(text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAuto";
            Text = "AutoKey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result;
        private Button btndec;
        private Button btnenc;
        private TextBox key;
        private TextBox text;
        private Label label2;
        private Label label1;
    }
}