namespace WinFormsApp2
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
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(216, 280);
            button1.Name = "button1";
            button1.Size = new Size(379, 59);
            button1.TabIndex = 0;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(68, 115);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "espresso(80)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(68, 145);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "latte(105)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(68, 175);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(129, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "turkkhavesi(50)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(68, 205);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(121, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "milkshake(65)";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(533, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "double shot(25)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(533, 146);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "sade";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(533, 176);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(96, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "orta şeker";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Visible = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(533, 206);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(95, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "tam şeker";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Visible = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
