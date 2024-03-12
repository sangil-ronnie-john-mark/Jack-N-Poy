namespace WinFormsApp25
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            pbxPlayer = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            pbxCPU = new FontAwesome.Sharp.IconPictureBox();
            lblResult = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPU).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(iconButton1);
            panel1.Location = new Point(-11, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 58);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(893, 14);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(58, 29);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "x";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Brown;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HandPeace;
            iconButton2.IconColor = Color.FromArgb(224, 224, 224);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(229, 438);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(152, 47);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Green;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
            iconButton3.IconColor = Color.FromArgb(224, 224, 224);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(406, 438);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(152, 47);
            iconButton3.TabIndex = 2;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Teal;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.HandRock;
            iconButton4.IconColor = Color.FromArgb(224, 224, 224);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(582, 438);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(152, 47);
            iconButton4.TabIndex = 3;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // pbxPlayer
            // 
            pbxPlayer.BackColor = SystemColors.Control;
            pbxPlayer.ForeColor = SystemColors.ControlText;
            pbxPlayer.IconChar = FontAwesome.Sharp.IconChar.None;
            pbxPlayer.IconColor = SystemColors.ControlText;
            pbxPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbxPlayer.IconSize = 216;
            pbxPlayer.Location = new Point(244, 140);
            pbxPlayer.Name = "pbxPlayer";
            pbxPlayer.Rotation = 90D;
            pbxPlayer.Size = new Size(219, 216);
            pbxPlayer.TabIndex = 4;
            pbxPlayer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 82);
            label1.Name = "label1";
            label1.Size = new Size(61, 31);
            label1.TabIndex = 5;
            label1.Text = "YOU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(565, 82);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 7;
            label2.Text = "CPU";
            // 
            // pbxCPU
            // 
            pbxCPU.BackColor = SystemColors.Control;
            pbxCPU.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            pbxCPU.ForeColor = SystemColors.ControlText;
            pbxCPU.IconChar = FontAwesome.Sharp.IconChar.None;
            pbxCPU.IconColor = SystemColors.ControlText;
            pbxCPU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbxCPU.IconSize = 216;
            pbxCPU.Location = new Point(488, 140);
            pbxCPU.Name = "pbxCPU";
            pbxCPU.Rotation = 270D;
            pbxCPU.Size = new Size(219, 216);
            pbxCPU.TabIndex = 6;
            pbxCPU.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(453, 388);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(952, 594);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(pbxCPU);
            Controls.Add(label1);
            Controls.Add(pbxPlayer);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconPictureBox pbxPlayer;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox pbxCPU;
        private Label lblResult;
    }
}
