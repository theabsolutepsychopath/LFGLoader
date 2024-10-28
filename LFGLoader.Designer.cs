
namespace LFGLoader
{
    partial class LFGLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFGLoader));
            vrMode = new CheckBox();
            installPlay = new Button();
            projectzomboid = new PictureBox();
            close = new Button();
            valheim = new PictureBox();
            SettingsButtonMain = new Button();
            statusLabel = new Label();
            LFGText = new Label();
            minecraft = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)projectzomboid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valheim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minecraft).BeginInit();
            SuspendLayout();
            // 
            // vrMode
            // 
            vrMode.Anchor = AnchorStyles.Bottom;
            vrMode.AutoSize = true;
            vrMode.FlatStyle = FlatStyle.Popup;
            vrMode.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vrMode.ForeColor = SystemColors.Control;
            vrMode.Location = new Point(412, 565);
            vrMode.Name = "vrMode";
            vrMode.Size = new Size(103, 24);
            vrMode.TabIndex = 2;
            vrMode.Text = "VR Mode";
            vrMode.UseVisualStyleBackColor = true;
            // 
            // installPlay
            // 
            installPlay.Anchor = AnchorStyles.Bottom;
            installPlay.BackColor = Color.SpringGreen;
            installPlay.Cursor = Cursors.Hand;
            installPlay.FlatAppearance.BorderColor = Color.Black;
            installPlay.FlatAppearance.BorderSize = 3;
            installPlay.FlatStyle = FlatStyle.Flat;
            installPlay.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            installPlay.Location = new Point(363, 593);
            installPlay.Name = "installPlay";
            installPlay.Size = new Size(200, 50);
            installPlay.TabIndex = 3;
            installPlay.Text = "FIND GAME DIR";
            installPlay.UseVisualStyleBackColor = false;
            installPlay.Click += InstallPlay_Click;
            // 
            // projectzomboid
            // 
            projectzomboid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectzomboid.BackColor = SystemColors.ActiveCaptionText;
            projectzomboid.Image = Properties.Resources.library_600x900;
            projectzomboid.Location = new Point(340, 124);
            projectzomboid.Name = "projectzomboid";
            projectzomboid.Size = new Size(246, 432);
            projectzomboid.SizeMode = PictureBoxSizeMode.StretchImage;
            projectzomboid.TabIndex = 4;
            projectzomboid.TabStop = false;
            projectzomboid.Click += BoxMiddle_Click;
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(192, 0, 0);
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 3;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("ProFont IIx Nerd Font", 14F);
            close.ForeColor = SystemColors.ControlText;
            close.Location = new Point(892, 0);
            close.Name = "close";
            close.Size = new Size(35, 35);
            close.TabIndex = 7;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += Close_Click;
            // 
            // valheim
            // 
            valheim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valheim.Image = Properties.Resources._5dea59a6a24c400fac4fbb4606eb865a;
            valheim.Location = new Point(89, 124);
            valheim.Name = "valheim";
            valheim.Size = new Size(246, 432);
            valheim.SizeMode = PictureBoxSizeMode.StretchImage;
            valheim.TabIndex = 10;
            valheim.TabStop = false;
            valheim.Click += BoxLeft_Click;
            // 
            // SettingsButtonMain
            // 
            SettingsButtonMain.BackColor = Color.DimGray;
            SettingsButtonMain.Cursor = Cursors.Hand;
            SettingsButtonMain.FlatAppearance.BorderColor = Color.Black;
            SettingsButtonMain.FlatAppearance.BorderSize = 3;
            SettingsButtonMain.FlatStyle = FlatStyle.Flat;
            SettingsButtonMain.Font = new Font("ProFont IIx Nerd Font", 14F);
            SettingsButtonMain.ForeColor = SystemColors.ControlText;
            SettingsButtonMain.Location = new Point(794, 638);
            SettingsButtonMain.Name = "SettingsButtonMain";
            SettingsButtonMain.Size = new Size(130, 40);
            SettingsButtonMain.TabIndex = 13;
            SettingsButtonMain.Text = "Settings";
            SettingsButtonMain.UseVisualStyleBackColor = false;
            SettingsButtonMain.Click += SettingsButtonMain_Click;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Bottom;
            statusLabel.Font = new Font("ProFont IIx Nerd Font", 12F);
            statusLabel.ForeColor = SystemColors.ControlLightLight;
            statusLabel.Location = new Point(145, 646);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(636, 32);
            statusLabel.TabIndex = 14;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LFGText
            // 
            LFGText.AutoSize = true;
            LFGText.Font = new Font("ProFont IIx Nerd Font", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LFGText.ForeColor = Color.White;
            LFGText.Location = new Point(279, 73);
            LFGText.Name = "LFGText";
            LFGText.Size = new Size(369, 39);
            LFGText.TabIndex = 18;
            LFGText.Text = "SELECT YOUR GAME";
            LFGText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minecraft
            // 
            minecraft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minecraft.Image = Properties.Resources.wallpaper_minecraft_pc_bundle_1080x1920;
            minecraft.Location = new Point(591, 124);
            minecraft.Name = "minecraft";
            minecraft.Size = new Size(246, 432);
            minecraft.SizeMode = PictureBoxSizeMode.StretchImage;
            minecraft.TabIndex = 9;
            minecraft.TabStop = false;
            minecraft.Click += BoxRight_Click;
            // 
            // LFGLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(927, 681);
            Controls.Add(valheim);
            Controls.Add(LFGText);
            Controls.Add(statusLabel);
            Controls.Add(SettingsButtonMain);
            Controls.Add(minecraft);
            Controls.Add(close);
            Controls.Add(projectzomboid);
            Controls.Add(installPlay);
            Controls.Add(vrMode);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LFGLoader";
            Opacity = 0.98D;
            Text = "LFGLoader";
            MouseDown += LFGLoader_MouseDown;
            ((System.ComponentModel.ISupportInitialize)projectzomboid).EndInit();
            ((System.ComponentModel.ISupportInitialize)valheim).EndInit();
            ((System.ComponentModel.ISupportInitialize)minecraft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private CheckBox vrMode;
        private Button installPlay;
        private Button gaybutton;
        private Button close;
        private Button SettingsButtonMain;
        private Label LFGText;
        public PictureBox projectzomboid;
        public PictureBox minecraft;
        public PictureBox valheim;
        public Label statusLabel;
    }
}
