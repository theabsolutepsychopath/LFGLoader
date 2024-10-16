using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFGMain;
using LFGMainWindow;

namespace LFGSettings
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings1.Default.GayReference = checkBox1.Checked;
            Settings1.Default.Save();
            this.Close();
        }

    }
}
