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
            minecraftdirbox = new TextBox();
            valheimdirbox = new TextBox();
            zomboiddirbox = new TextBox();
            minecraftbrowse = new Button();
            valheimbrowse = new Button();
            zomboidbrowse = new Button();
            minecraftclear = new Button();
            valheimclear = new Button();
            zomboidclear = new Button();
            resetvalues = new Button();
            close = new Button();
            minecraftlabel = new Label();
            valheimlabel = new Label();
            zomboidlabel = new Label();
            SettingsLabel = new Label();
            SuspendLayout();
            // 
            // minecraftdirbox
            // 
            minecraftdirbox.BorderStyle = BorderStyle.FixedSingle;
            minecraftdirbox.Font = new Font("ProFont IIx Nerd Font", 8.25F, FontStyle.Italic);
            minecraftdirbox.Location = new Point(151, 147);
            minecraftdirbox.Name = "minecraftdirbox";
            minecraftdirbox.ReadOnly = true;
            minecraftdirbox.ScrollBars = ScrollBars.Horizontal;
            minecraftdirbox.Size = new Size(373, 21);
            minecraftdirbox.TabIndex = 4;
            // 
            // valheimdirbox
            // 
            valheimdirbox.BorderStyle = BorderStyle.FixedSingle;
            valheimdirbox.Font = new Font("ProFont IIx Nerd Font", 8.25F, FontStyle.Italic);
            valheimdirbox.Location = new Point(151, 223);
            valheimdirbox.Name = "valheimdirbox";
            valheimdirbox.ReadOnly = true;
            valheimdirbox.ScrollBars = ScrollBars.Horizontal;
            valheimdirbox.Size = new Size(373, 21);
            valheimdirbox.TabIndex = 5;
            // 
            // zomboiddirbox
            // 
            zomboiddirbox.BorderStyle = BorderStyle.FixedSingle;
            zomboiddirbox.Font = new Font("ProFont IIx Nerd Font", 8.25F, FontStyle.Italic);
            zomboiddirbox.Location = new Point(151, 301);
            zomboiddirbox.Name = "zomboiddirbox";
            zomboiddirbox.ReadOnly = true;
            zomboiddirbox.ScrollBars = ScrollBars.Horizontal;
            zomboiddirbox.Size = new Size(373, 21);
            zomboiddirbox.TabIndex = 6;
            // 
            // minecraftbrowse
            // 
            minecraftbrowse.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minecraftbrowse.Location = new Point(531, 134);
            minecraftbrowse.Name = "minecraftbrowse";
            minecraftbrowse.Size = new Size(75, 45);
            minecraftbrowse.TabIndex = 7;
            minecraftbrowse.Text = "BROWSE";
            minecraftbrowse.UseVisualStyleBackColor = true;
            minecraftbrowse.Click += minecraftbrowse_Click;
            // 
            // valheimbrowse
            // 
            valheimbrowse.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valheimbrowse.Location = new Point(531, 211);
            valheimbrowse.Name = "valheimbrowse";
            valheimbrowse.Size = new Size(75, 45);
            valheimbrowse.TabIndex = 8;
            valheimbrowse.Text = "BROWSE";
            valheimbrowse.UseVisualStyleBackColor = true;
            valheimbrowse.Click += valheimbrowse_Click;
            // 
            // zomboidbrowse
            // 
            zomboidbrowse.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zomboidbrowse.Location = new Point(531, 289);
            zomboidbrowse.Name = "zomboidbrowse";
            zomboidbrowse.Size = new Size(75, 45);
            zomboidbrowse.TabIndex = 9;
            zomboidbrowse.Text = "BROWSE";
            zomboidbrowse.UseVisualStyleBackColor = true;
            zomboidbrowse.Click += valheimbrowse_Click;
            // 
            // minecraftclear
            // 
            minecraftclear.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minecraftclear.Location = new Point(612, 134);
            minecraftclear.Name = "minecraftclear";
            minecraftclear.Size = new Size(75, 45);
            minecraftclear.TabIndex = 10;
            minecraftclear.Text = "CLEAR";
            minecraftclear.UseVisualStyleBackColor = true;
            minecraftclear.Click += minecraftclear_Click;
            // 
            // valheimclear
            // 
            valheimclear.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valheimclear.Location = new Point(612, 211);
            valheimclear.Name = "valheimclear";
            valheimclear.Size = new Size(75, 45);
            valheimclear.TabIndex = 11;
            valheimclear.Text = "CLEAR";
            valheimclear.UseVisualStyleBackColor = true;
            valheimclear.Click += valheimclear_Click;
            // 
            // zomboidclear
            // 
            zomboidclear.Font = new Font("ProFont IIx Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zomboidclear.Location = new Point(612, 289);
            zomboidclear.Name = "zomboidclear";
            zomboidclear.Size = new Size(75, 45);
            zomboidclear.TabIndex = 12;
            zomboidclear.Text = "CLEAR";
            zomboidclear.UseVisualStyleBackColor = true;
            zomboidclear.Click += zomboidclear_Click;
            // 
            // resetvalues
            // 
            resetvalues.BackColor = Color.Red;
            resetvalues.FlatAppearance.BorderSize = 0;
            resetvalues.FlatStyle = FlatStyle.Flat;
            resetvalues.Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetvalues.ForeColor = Color.White;
            resetvalues.Location = new Point(653, 371);
            resetvalues.Name = "resetvalues";
            resetvalues.Size = new Size(173, 58);
            resetvalues.TabIndex = 13;
            resetvalues.Text = "The Big Red Button (Dont Press)";
            resetvalues.UseVisualStyleBackColor = false;
            resetvalues.Click += resetvalues_Click;
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(192, 0, 0);
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 3;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("ProFont IIx Nerd Font", 14F);
            close.ForeColor = SystemColors.ControlText;
            close.Location = new Point(803, 0);
            close.Name = "close";
            close.Size = new Size(35, 35);
            close.TabIndex = 14;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // minecraftlabel
            // 
            minecraftlabel.AutoSize = true;
            minecraftlabel.Font = new Font("ProFont IIx Nerd Font", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minecraftlabel.ForeColor = SystemColors.Control;
            minecraftlabel.Location = new Point(151, 107);
            minecraftlabel.Name = "minecraftlabel";
            minecraftlabel.Size = new Size(166, 29);
            minecraftlabel.TabIndex = 15;
            minecraftlabel.Text = "MINECRAFT";
            // 
            // valheimlabel
            // 
            valheimlabel.AutoSize = true;
            valheimlabel.Font = new Font("ProFont IIx Nerd Font", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valheimlabel.ForeColor = SystemColors.Control;
            valheimlabel.Location = new Point(151, 184);
            valheimlabel.Name = "valheimlabel";
            valheimlabel.Size = new Size(132, 29);
            valheimlabel.TabIndex = 16;
            valheimlabel.Text = "VALHEIM";
            // 
            // zomboidlabel
            // 
            zomboidlabel.AutoSize = true;
            zomboidlabel.Font = new Font("ProFont IIx Nerd Font", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zomboidlabel.ForeColor = SystemColors.Control;
            zomboidlabel.Location = new Point(151, 262);
            zomboidlabel.Name = "zomboidlabel";
            zomboidlabel.Size = new Size(268, 29);
            zomboidlabel.TabIndex = 17;
            zomboidlabel.Text = "PROJECT ZOMBOID";
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("ProFont IIx Nerd Font", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsLabel.ForeColor = Color.White;
            SettingsLabel.Location = new Point(323, 23);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(193, 39);
            SettingsLabel.TabIndex = 19;
            SettingsLabel.Text = "SETTINGS";
            SettingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(838, 441);
            Controls.Add(SettingsLabel);
            Controls.Add(zomboidlabel);
            Controls.Add(valheimlabel);
            Controls.Add(minecraftlabel);
            Controls.Add(close);
            Controls.Add(resetvalues);
            Controls.Add(zomboidclear);
            Controls.Add(valheimclear);
            Controls.Add(minecraftclear);
            Controls.Add(zomboidbrowse);
            Controls.Add(valheimbrowse);
            Controls.Add(minecraftbrowse);
            Controls.Add(zomboiddirbox);
            Controls.Add(valheimdirbox);
            Controls.Add(minecraftdirbox);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Settings";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox minecraftdirbox;
        private TextBox valheimdirbox;
        private TextBox zomboiddirbox;
        private Button minecraftbrowse;
        private Button valheimbrowse;
        private Button zomboidbrowse;
        private Button minecraftclear;
        private Button valheimclear;
        private Button zomboidclear;
        private Button resetvalues;
        private Button close;
        private Label minecraftlabel;
        private Label valheimlabel;
        private Label zomboidlabel;
        private Label SettingsLabel;
    }
}