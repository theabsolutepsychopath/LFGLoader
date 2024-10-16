using System.Linq.Expressions;
using System.Runtime.InteropServices;
using LFGSettings;
using LFGMainWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        public LFGLoader()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture and send a message to move the form
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void InstallPlay_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string path = @"C:\Program Files (x86)\Steam\steamapps\common\Among Us\Among Us.exe";
                if (File.Exists(path))
                {
                    MessageBox.Show("Among Us is already installed.");
                }
                else
                {
                    MessageBox.Show("Among Us is not installed. Please install Among Us before continuing.");
                }
            }
        }
        private void BoxMiddle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is working as intended.");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topdrag_Paint(object sender, PaintEventArgs e)
        {
            topdrag.MouseDown += Form1_MouseDown;
        }

        private void SettingsButtonMain_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog(this);
        }
    }
}
