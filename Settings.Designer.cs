﻿namespace LFGMainWindow
{
    partial class Settings
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
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("ProFont IIx Nerd Font", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(356, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Gay References";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("ProFont IIx Nerd Font", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(277, 371);
            button1.Name = "button1";
            button1.Size = new Size(284, 69);
            button1.TabIndex = 1;
            button1.Text = "GENERAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("ProFont IIx Nerd Font", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(-7, 371);
            button2.Name = "button2";
            button2.Size = new Size(284, 69);
            button2.TabIndex = 2;
            button2.Text = "GAME PATHS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("ProFont IIx Nerd Font", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(559, 371);
            button3.Name = "button3";
            button3.Size = new Size(284, 69);
            button3.TabIndex = 3;
            button3.Text = "CLOSE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += this.button3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(838, 441);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent; // Add this line
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}