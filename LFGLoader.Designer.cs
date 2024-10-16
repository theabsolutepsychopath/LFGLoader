
namespace winformgay
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // VRMode
            // 
            VRMode.Anchor = AnchorStyles.Bottom;
            VRMode.AutoSize = true;
            VRMode.FlatStyle = FlatStyle.Popup;
            VRMode.Font = new Font("ProFont IIx Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VRMode.Location = new Point(829, 639);
            VRMode.Name = "VRMode";
            VRMode.Size = new Size(103, 24);
            VRMode.TabIndex = 2;
            VRMode.Text = "VR Mode";
            VRMode.UseVisualStyleBackColor = true;
            // 
            // InstallPlay
            // 
            InstallPlay.Anchor = AnchorStyles.Bottom;
            InstallPlay.BackColor = Color.Tomato;
            InstallPlay.FlatAppearance.BorderColor = Color.Black;
            InstallPlay.FlatAppearance.BorderSize = 3;
            InstallPlay.FlatStyle = FlatStyle.Flat;
            InstallPlay.Font = new Font("ProFont IIx Nerd Font", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstallPlay.Location = new Point(780, 670);
            InstallPlay.Name = "InstallPlay";
            InstallPlay.Size = new Size(200, 50);
            InstallPlay.TabIndex = 3;
            InstallPlay.Text = "INSTALL";
            InstallPlay.UseVisualStyleBackColor = false;
            InstallPlay.Click += InstallPlay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LFGMainWindow.Properties.Resources.wallpaper_minecraft_pc_bundle_1080x1920;
            pictureBox1.Location = new Point(718, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 576);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LFGLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1761, 760);
            Controls.Add(pictureBox1);
            Controls.Add(InstallPlay);
            Controls.Add(VRMode);
            Font = new Font("ProFont IIx Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LFGLoader";
            Text = "GGLoader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private CheckBox VRMode;
        private Button InstallPlay;
        private Button gaybutton;
        private PictureBox pictureBox1;
    }
}
