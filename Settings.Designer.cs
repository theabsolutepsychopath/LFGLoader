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
            closeButton = new Button();
            minecraftdirbox = new TextBox();
            valheimdirbox = new TextBox();
            zomboiddirbox = new TextBox();
            minecraftbrowse = new Button();
            valheimbrowse = new Button();
            zomboidbrowse = new Button();
            minecraftclear = new Button();
            valheimclear = new Button();
            zomboidclear = new Button();
            SuspendLayout();
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
            // minecraftdirbox
            // 
            minecraftdirbox.Location = new Point(48, 30);
            minecraftdirbox.Name = "minecraftdirbox";
            minecraftdirbox.Size = new Size(373, 22);
            minecraftdirbox.TabIndex = 4;
            // 
            // valheimdirbox
            // 
            valheimdirbox.Location = new Point(48, 58);
            valheimdirbox.Name = "valheimdirbox";
            valheimdirbox.Size = new Size(373, 22);
            valheimdirbox.TabIndex = 5;
            // 
            // zomboiddirbox
            // 
            zomboiddirbox.Location = new Point(48, 86);
            zomboiddirbox.Name = "zomboiddirbox";
            zomboiddirbox.Size = new Size(373, 22);
            zomboiddirbox.TabIndex = 6;
            // 
            // minecraftbrowse
            // 
            minecraftbrowse.Location = new Point(427, 30);
            minecraftbrowse.Name = "minecraftbrowse";
            minecraftbrowse.Size = new Size(75, 23);
            minecraftbrowse.TabIndex = 7;
            minecraftbrowse.Text = "BROWSE";
            minecraftbrowse.UseVisualStyleBackColor = true;
            // 
            // valheimbrowse
            // 
            valheimbrowse.Location = new Point(427, 59);
            valheimbrowse.Name = "valheimbrowse";
            valheimbrowse.Size = new Size(75, 23);
            valheimbrowse.TabIndex = 8;
            valheimbrowse.Text = "BROWSE";
            valheimbrowse.UseVisualStyleBackColor = true;
            // 
            // zomboidbrowse
            // 
            zomboidbrowse.Location = new Point(427, 88);
            zomboidbrowse.Name = "zomboidbrowse";
            zomboidbrowse.Size = new Size(75, 23);
            zomboidbrowse.TabIndex = 9;
            zomboidbrowse.Text = "BROWSE";
            zomboidbrowse.UseVisualStyleBackColor = true;
            // 
            // minecraftclear
            // 
            minecraftclear.Location = new Point(508, 30);
            minecraftclear.Name = "minecraftclear";
            minecraftclear.Size = new Size(75, 23);
            minecraftclear.TabIndex = 10;
            minecraftclear.Text = "CLEAR";
            minecraftclear.UseVisualStyleBackColor = true;
            minecraftclear.Click += minecraftclear_Click;
            // 
            // valheimclear
            // 
            valheimclear.Location = new Point(508, 59);
            valheimclear.Name = "valheimclear";
            valheimclear.Size = new Size(75, 23);
            valheimclear.TabIndex = 11;
            valheimclear.Text = "CLEAR";
            valheimclear.UseVisualStyleBackColor = true;
            // 
            // zomboidclear
            // 
            zomboidclear.Location = new Point(508, 88);
            zomboidclear.Name = "zomboidclear";
            zomboidclear.Size = new Size(75, 23);
            zomboidclear.TabIndex = 12;
            zomboidclear.Text = "CLEAR";
            zomboidclear.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(838, 441);
            Controls.Add(zomboidclear);
            Controls.Add(valheimclear);
            Controls.Add(minecraftclear);
            Controls.Add(zomboidbrowse);
            Controls.Add(valheimbrowse);
            Controls.Add(minecraftbrowse);
            Controls.Add(zomboiddirbox);
            Controls.Add(valheimdirbox);
            Controls.Add(minecraftdirbox);
            Controls.Add(closeButton);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeButton;
        private TextBox minecraftdirbox;
        private TextBox valheimdirbox;
        private TextBox zomboiddirbox;
        private Button minecraftbrowse;
        private Button valheimbrowse;
        private Button zomboidbrowse;
        private Button minecraftclear;
        private Button valheimclear;
        private Button zomboidclear;
    }
}