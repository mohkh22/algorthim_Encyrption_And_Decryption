namespace Cipher
{
    partial class Form1
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "pltxt";
            textBox1.Location = new Point(129, 133);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 43);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 1;
            label1.Text = "Plain Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 217);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 3;
            label2.Text = "Key";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "key";
            textBox2.Location = new Point(129, 217);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 43);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 41);
            label3.Name = "label3";
            label3.Size = new Size(282, 54);
            label3.TabIndex = 4;
            label3.Text = "Caesar Cipher";
            // 
            // button1
            // 
            button1.AccessibleName = "encryptbtn";
            button1.Location = new Point(105, 297);
            button1.Name = "button1";
            button1.Size = new Size(176, 54);
            button1.TabIndex = 5;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "decrypttbtn";
            button2.Location = new Point(105, 380);
            button2.Name = "button2";
            button2.Size = new Size(176, 54);
            button2.TabIndex = 6;
            button2.Text = "Decrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 478);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 483);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 15;
            label5.Text = "Result";
            // 
            // button3
            // 
            button3.AccessibleName = "decrypttbtn";
            button3.Location = new Point(556, 385);
            button3.Name = "button3";
            button3.Size = new Size(176, 54);
            button3.TabIndex = 14;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AccessibleName = "encryptbtn";
            button4.Location = new Point(556, 302);
            button4.Name = "button4";
            button4.Size = new Size(176, 54);
            button4.TabIndex = 13;
            button4.Text = "Encrypt";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 46);
            label6.Name = "label6";
            label6.Size = new Size(336, 54);
            label6.TabIndex = 12;
            label6.Text = "MonoAlphabetic";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(491, 222);
            label7.Name = "label7";
            label7.Size = new Size(50, 31);
            label7.TabIndex = 11;
            label7.Text = "Key";
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "key";
            textBox3.Location = new Point(580, 222);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 43);
            textBox3.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(463, 138);
            label8.Name = "label8";
            label8.Size = new Size(111, 31);
            label8.TabIndex = 9;
            label8.Text = "Plain Text";
            // 
            // textBox4
            // 
            textBox4.AccessibleName = "pltxt";
            textBox4.Location = new Point(580, 138);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 43);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(918, 548);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
    }
}
