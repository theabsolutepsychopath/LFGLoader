
namespace LFGMain
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
            vrMode = new CheckBox();
            installPlay = new Button();
            boxMiddle = new PictureBox();
            close = new Button();
            boxLeft = new PictureBox();
            SettingsButtonMain = new Button();
            statusLabel = new Label();
            LFGText = new Label();
            boxRight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)boxMiddle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxRight).BeginInit();
            SuspendLayout();
            // 
            // vrMode
            // 
            vrMode.Anchor = AnchorStyles.Bottom;
            vrMode.AutoSize = true;
            vrMode.FlatStyle = FlatStyle.Popup;
            vrMode.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // boxMiddle
            // 
            boxMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxMiddle.BackColor = SystemColors.ActiveCaptionText;
            boxMiddle.Image = LFGMainWindow.Properties.Resources.library_600x900;
            boxMiddle.Location = new Point(340, 124);
            boxMiddle.Name = "boxMiddle";
            boxMiddle.Size = new Size(246, 432);
            boxMiddle.SizeMode = PictureBoxSizeMode.StretchImage;
            boxMiddle.TabIndex = 4;
            boxMiddle.TabStop = false;
            boxMiddle.Click += BoxMiddle_Click;
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(192, 0, 0);
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 3;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("ProFont IIx Nerd Font", 14F);
            close.ForeColor = SystemColors.ControlText;
            close.Location = new Point(897, -4);
            close.Name = "close";
            close.Size = new Size(35, 35);
            close.TabIndex = 7;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += Close_Click;
            // 
            // boxLeft
            // 
            boxLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxLeft.Image = LFGMainWindow.Properties.Resources._5dea59a6a24c400fac4fbb4606eb865a;
            boxLeft.Location = new Point(89, 124);
            boxLeft.Name = "boxLeft";
            boxLeft.Size = new Size(246, 432);
            boxLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            boxLeft.TabIndex = 10;
            boxLeft.TabStop = false;
            boxLeft.Click += BoxLeft_Click;
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
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = SystemColors.ControlLightLight;
            statusLabel.Location = new Point(256, 650);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(414, 15);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "Nothing is happening. Try launching or installing a game!";
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
            // boxRight
            // 
            boxRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRight.Image = LFGMainWindow.Properties.Resources.wallpaper_minecraft_pc_bundle_1080x1920;
            boxRight.Location = new Point(591, 124);
            boxRight.Name = "boxRight";
            boxRight.Size = new Size(246, 432);
            boxRight.SizeMode = PictureBoxSizeMode.StretchImage;
            boxRight.TabIndex = 9;
            boxRight.TabStop = false;
            boxRight.Click += BoxRight_Click;
            // 
            // LFGLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(927, 681);
            Controls.Add(boxLeft);
            Controls.Add(LFGText);
            Controls.Add(statusLabel);
            Controls.Add(SettingsButtonMain);
            Controls.Add(boxRight);
            Controls.Add(close);
            Controls.Add(boxMiddle);
            Controls.Add(installPlay);
            Controls.Add(vrMode);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LFGLoader";
            Opacity = 0.98D;
            Text = "GGLoader";
            Load += LFGLoader_Load;
            MouseDown += LFGLoader_MouseDown;
            ((System.ComponentModel.ISupportInitialize)boxMiddle).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxRight).EndInit();
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
        private Label statusLabel;
        private Label LFGText;
        public PictureBox boxMiddle;
        public PictureBox boxRight;
        public PictureBox boxLeft;
    }
}
