namespace LFGSettings
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
            closeButton = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("ProFont IIx Nerd Font", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(12, 19);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Gay References";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Firebrick;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("ProFont IIx Nerd Font", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(787, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(39, 40);
            closeButton.TabIndex = 3;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += button3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(838, 441);
            Controls.Add(closeButton);
            Controls.Add(checkBox1);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button closeButton;
    }
}