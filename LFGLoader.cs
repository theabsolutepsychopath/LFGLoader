using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using LFGSettings;

namespace LFGMain
{
    public partial class LFGLoader : Form
    {
        // Import necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constant values for window dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Declare private fields for the overlays
        private Panel overlayLeft;
        private Panel overlayMiddle;
        private Panel overlayRight;

        // Track the currently active (dimmed) box
        private Control activeBox = null;

        public LFGLoader()
        {
            InitializeComponent();

            // Add semi-transparent overlays to the PictureBoxes and store them
            AddOverlay(boxLeft, ref overlayLeft);
            AddOverlay(boxMiddle, ref overlayMiddle);
            AddOverlay(boxRight, ref overlayRight);

            // Reset all overlays first (make sure no box starts dimmed by default)
            ResetOverlays();

            // Load the previously selected box
            string selectedBoxName = LFGMainWindow.Properties.Settings.Default.selectedBox;
            if (!string.IsNullOrEmpty(selectedBoxName) && selectedBoxName != "None")
            {
                // Find the corresponding control (box) by name
                Control selectedBox = this.Controls.Find(selectedBoxName, true).FirstOrDefault();
                if (selectedBox != null)
                {
                    activeBox = selectedBox;
                    DimOtherBoxes(selectedBox);  // Ensure only other boxes are dimmed
                }
            }
        }

        private void AddOverlay(Control parentControl, ref Panel overlayField)
        {
            Panel overlay = new Panel
            {
                BackColor = Color.FromArgb(130, 0, 0, 0), // 170 is the transparency level (50% opacity), black color
                Dock = DockStyle.Fill,
                Visible = false, // Start as hidden
                Tag = parentControl // Tag to associate the overlay with the PictureBox
            };

            // Intercept the click and manually invoke the parent control's click event using reflection
            overlay.Click += (s, e) =>
            {
                var clickHandler = parentControl.GetType().GetMethod("OnClick", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                clickHandler?.Invoke(parentControl, new object[] { e });
            };

            parentControl.Controls.Add(overlay);
            overlay.BringToFront(); // Make sure it's above the image

            // Assign the overlay to the passed reference
            overlayField = overlay;
        }

        private void ShowOverlay(Panel overlay)
        {
            if (overlay != null)
            {
                overlay.Visible = true; // Show the overlay to "darken" the image
            }
        }

        private void HideOverlay(Panel overlay)
        {
            if (overlay != null)
            {
                overlay.Visible = false; // Hide the overlay to "undim" the image
            }
        }

        private void ResetOverlays()
        {
            // Ensure all boxes are undimmed
            HideOverlay(overlayLeft);
            HideOverlay(overlayMiddle);
            HideOverlay(overlayRight);
        }

        private void DimOtherBoxes(Control clickedBox)
        {
            // Dim all other boxes, but undim the clicked one
            ResetOverlays();  // Start by undimming all boxes

            if (clickedBox != boxLeft)
            {
                ShowOverlay(overlayLeft);
            }
            if (clickedBox != boxMiddle)
            {
                ShowOverlay(overlayMiddle);
            }
            if (clickedBox != boxRight)
            {
                ShowOverlay(overlayRight);
            }
        }

        private void box_Click(object sender, EventArgs e)
        {
            Control clickedBox = sender as Control;

            // If the same box is clicked again, undim all boxes
            if (activeBox == clickedBox)
            {
                LFGMainWindow.Properties.Settings.Default.selectedBox = "None";
                LFGMainWindow.Properties.Settings.Default.Save();

                // Undim all boxes
                ResetOverlays();
                activeBox = null; // Reset the active box
            }
            else
            {
                // If a new box is clicked, dim the others and undim the clicked one
                LFGMainWindow.Properties.Settings.Default.selectedBox = clickedBox.Name;
                LFGMainWindow.Properties.Settings.Default.Save();

                DimOtherBoxes(clickedBox);
                activeBox = clickedBox; // Set the clicked box as the active one
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsButtonMain_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog(this);
        }

        private void LFGLoader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture and send a message to move the form
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void boxLeft_Click(object sender, EventArgs e)
        {
            box_Click(sender, e);
        }

        private void boxMiddle_Click(object sender, EventArgs e)
        {
            box_Click(sender, e);
        }

        private void boxRight_Click(object sender, EventArgs e)
        {
            box_Click(sender, e);
        }
    }
}
