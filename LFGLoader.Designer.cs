
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
            VRMode = new CheckBox();
            InstallPlay = new Button();
            BoxMiddle = new PictureBox();
            close = new Button();
            topdrag = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            SettingsButtonMain = new Button();
            StatusLabel = new Label();
            panel1 = new Panel();
            LFGText = new Label();
            ((System.ComponentModel.ISupportInitialize)BoxMiddle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // VRMode
            // 
            VRMode.Anchor = AnchorStyles.Bottom;
            VRMode.AutoSize = true;
            VRMode.FlatStyle = FlatStyle.Popup;
            VRMode.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VRMode.Location = new Point(581, 560);
            VRMode.Name = "VRMode";
            VRMode.Size = new Size(103, 24);
            VRMode.TabIndex = 2;
            VRMode.Text = "VR Mode";
            VRMode.UseVisualStyleBackColor = true;
            // 
            // InstallPlay
            // 
            InstallPlay.Anchor = AnchorStyles.Bottom;
            InstallPlay.BackColor = Color.SpringGreen;
            InstallPlay.Cursor = Cursors.Hand;
            InstallPlay.FlatAppearance.BorderColor = Color.Black;
            InstallPlay.FlatAppearance.BorderSize = 3;
            InstallPlay.FlatStyle = FlatStyle.Flat;
            InstallPlay.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstallPlay.Location = new Point(532, 591);
            InstallPlay.Name = "InstallPlay";
            InstallPlay.Size = new Size(200, 50);
            InstallPlay.TabIndex = 3;
            InstallPlay.Text = "FIND GAME DIR";
            InstallPlay.UseVisualStyleBackColor = false;
            InstallPlay.Click += InstallPlay_Click;
            // 
            // BoxMiddle
            // 
            BoxMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxMiddle.BackColor = SystemColors.ActiveCaptionText;
            BoxMiddle.Image = LFGMainWindow.Properties.Resources._2505179ede56bc369c490b377cc73744;
            BoxMiddle.Location = new Point(511, 111);
            BoxMiddle.Name = "BoxMiddle";
            BoxMiddle.Size = new Size(243, 432);
            BoxMiddle.SizeMode = PictureBoxSizeMode.StretchImage;
            BoxMiddle.TabIndex = 4;
            BoxMiddle.TabStop = false;
            BoxMiddle.Click += BoxMiddle_Click;
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(192, 0, 0);
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 3;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("ProFont IIx Nerd Font", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = SystemColors.ControlText;
            close.Location = new Point(1214, 0);
            close.Name = "close";
            close.Size = new Size(50, 50);
            close.TabIndex = 7;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // topdrag
            // 
            topdrag.Location = new Point(0, 0);
            topdrag.Name = "topdrag";
            topdrag.Size = new Size(1208, 53);
            topdrag.TabIndex = 8;
            topdrag.Paint += topdrag_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = LFGMainWindow.Properties.Resources.wallpaper_minecraft_pc_bundle_1080x1920;
            pictureBox1.Location = new Point(760, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = LFGMainWindow.Properties.Resources._5dea59a6a24c400fac4fbb4606eb865a;
            pictureBox2.Location = new Point(262, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 432);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // SettingsButtonMain
            // 
            SettingsButtonMain.BackColor = Color.DimGray;
            SettingsButtonMain.Cursor = Cursors.Hand;
            SettingsButtonMain.FlatAppearance.BorderColor = Color.Black;
            SettingsButtonMain.FlatAppearance.BorderSize = 3;
            SettingsButtonMain.FlatStyle = FlatStyle.Flat;
            SettingsButtonMain.Font = new Font("ProFont IIx Nerd Font", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsButtonMain.ForeColor = SystemColors.ControlText;
            SettingsButtonMain.Location = new Point(1053, 597);
            SettingsButtonMain.Name = "SettingsButtonMain";
            SettingsButtonMain.Size = new Size(199, 72);
            SettingsButtonMain.TabIndex = 13;
            SettingsButtonMain.Text = "Settings";
            SettingsButtonMain.UseVisualStyleBackColor = false;
            SettingsButtonMain.Click += SettingsButtonMain_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.Bottom;
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = SystemColors.ControlLightLight;
            StatusLabel.Location = new Point(425, 651);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(414, 15);
            StatusLabel.TabIndex = 14;
            StatusLabel.Text = "Nothing is happening. Try launching or installing a game!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(254, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 444);
            panel1.TabIndex = 17;
            // 
            // LFGText
            // 
            LFGText.AutoSize = true;
            LFGText.Font = new Font("ProFont IIx Nerd Font", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LFGText.Location = new Point(356, 38);
            LFGText.Name = "LFGText";
            LFGText.Size = new Size(553, 60);
            LFGText.TabIndex = 18;
            LFGText.Text = "SELECT YOUR GAME";
            LFGText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LFGLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 681);
            Controls.Add(LFGText);
            Controls.Add(StatusLabel);
            Controls.Add(SettingsButtonMain);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(close);
            Controls.Add(BoxMiddle);
            Controls.Add(InstallPlay);
            Controls.Add(VRMode);
            Controls.Add(topdrag);
            Controls.Add(panel1);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LFGLoader";
            Text = "GGLoader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BoxMiddle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private CheckBox VRMode;
        private Button InstallPlay;
        private Button gaybutton;
        private PictureBox BoxMiddle;
        private Button close;
        private Panel topdrag;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button SettingsButtonMain;
        private Label StatusLabel;
        private Panel panel1;
        private Label LFGText;
    }
}
