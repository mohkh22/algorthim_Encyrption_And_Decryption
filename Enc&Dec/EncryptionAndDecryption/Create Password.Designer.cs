namespace EncyrptionAndDecryption
{
    partial class frmPassword
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
            txtPass = new TextBox();
            label1 = new Label();
            progress = new ProgressBar();
            lblstatus = new Label();
            ch1 = new CheckBox();
            ch3 = new CheckBox();
            ch4 = new CheckBox();
            ch5 = new CheckBox();
            ch2 = new CheckBox();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(68, 62);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(405, 25);
            txtPass.TabIndex = 0;
            txtPass.TextChanged += textBox1_TextChanged;
            txtPass.KeyDown += txtPass_KeyDown;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 1;
            label1.Text = "Write Your Password";
            // 
            // progress
            // 
            progress.BackColor = SystemColors.ActiveBorder;
            progress.ForeColor = Color.White;
            progress.Location = new Point(68, 91);
            progress.Name = "progress";
            progress.Size = new Size(405, 10);
            progress.TabIndex = 2;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(68, 104);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(0, 17);
            lblstatus.TabIndex = 3;
            // 
            // ch1
            // 
            ch1.AutoSize = true;
            ch1.BackColor = Color.FromArgb(224, 224, 224);
            ch1.Enabled = false;
            ch1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ch1.ForeColor = SystemColors.ActiveCaptionText;
            ch1.Location = new Point(68, 142);
            ch1.Name = "ch1";
            ch1.Size = new Size(298, 25);
            ch1.TabIndex = 4;
            ch1.Text = "It must be at least 8 characters long";
            ch1.UseVisualStyleBackColor = false;
            ch1.CheckedChanged += ch1_CheckedChanged;
            ch1.TextChanged += ch1_TextChanged;
            // 
            // ch3
            // 
            ch3.AutoSize = true;
            ch3.BackColor = Color.FromArgb(224, 224, 224);
            ch3.Enabled = false;
            ch3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ch3.Location = new Point(68, 204);
            ch3.Name = "ch3";
            ch3.Size = new Size(280, 25);
            ch3.TabIndex = 5;
            ch3.Text = "It must contain lowercase letters.";
            ch3.UseVisualStyleBackColor = false;
            // 
            // ch4
            // 
            ch4.AutoSize = true;
            ch4.BackColor = Color.FromArgb(224, 224, 224);
            ch4.Enabled = false;
            ch4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ch4.Location = new Point(68, 235);
            ch4.Name = "ch4";
            ch4.Size = new Size(256, 25);
            ch4.TabIndex = 6;
            ch4.Text = "It must contain capital letters.";
            ch4.UseVisualStyleBackColor = false;
            // 
            // ch5
            // 
            ch5.AutoSize = true;
            ch5.BackColor = Color.FromArgb(224, 224, 224);
            ch5.Enabled = false;
            ch5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ch5.Location = new Point(68, 266);
            ch5.Name = "ch5";
            ch5.Size = new Size(287, 25);
            ch5.TabIndex = 7;
            ch5.Text = "It must contain special characters.";
            ch5.UseVisualStyleBackColor = false;
            // 
            // ch2
            // 
            ch2.AutoSize = true;
            ch2.BackColor = Color.FromArgb(224, 224, 224);
            ch2.Enabled = false;
            ch2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ch2.Location = new Point(68, 173);
            ch2.Name = "ch2";
            ch2.Size = new Size(215, 25);
            ch2.TabIndex = 8;
            ch2.Text = "It must contain numbers";
            ch2.UseVisualStyleBackColor = false;
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(ch2);
            Controls.Add(ch5);
            Controls.Add(ch4);
            Controls.Add(ch3);
            Controls.Add(ch1);
            Controls.Add(lblstatus);
            Controls.Add(progress);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Name = "frmPassword";
            Text = "Create_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private Label label1;
        private ProgressBar progress;
        private Label lblstatus;
        private CheckBox ch1;
        private CheckBox ch3;
        private CheckBox ch4;
        private CheckBox ch5;
        private CheckBox ch2;
    }
}