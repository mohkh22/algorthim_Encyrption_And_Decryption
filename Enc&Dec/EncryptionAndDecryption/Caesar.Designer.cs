namespace EncyrptionAndDecryption
{
    partial class frmCaesar
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
            result.Location = new Point(84, 113);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(282, 23);
            result.TabIndex = 15;
            // 
            // btndec
            // 
            btndec.Location = new Point(238, 165);
            btndec.Name = "btndec";
            btndec.Size = new Size(148, 23);
            btndec.TabIndex = 14;
            btndec.Text = "Decyrpt";
            btndec.Click += btndec_Click_1;
            // 
            // btnenc
            // 
            btnenc.Location = new Point(63, 165);
            btnenc.Name = "btnenc";
            btnenc.Size = new Size(147, 23);
            btnenc.TabIndex = 13;
            btnenc.Text = "Encyrpt";
            btnenc.UseVisualStyleBackColor = true;
            btnenc.Click += btnenc_Click_1;
            // 
            // key
            // 
            key.Location = new Point(84, 72);
            key.Name = "key";
            key.Size = new Size(282, 23);
            key.TabIndex = 12;
            // 
            // text
            // 
            text.Location = new Point(84, 30);
            text.Name = "text";
            text.Size = new Size(282, 23);
            text.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 75);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 10;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 9;
            label1.Text = "Text";
            // 
            // frmCaesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 252);
            Controls.Add(result);
            Controls.Add(btndec);
            Controls.Add(btnenc);
            Controls.Add(key);
            Controls.Add(text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCaesar";
            Text = "Caesar";
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