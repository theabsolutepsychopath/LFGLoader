using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFGLoader;

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
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            minecraftdirbox.Text = LFGLoader.Properties.Settings.Default.minecraftDir;
            valheimdirbox.Text = LFGLoader.Properties.Settings.Default.valheimDir;
            zomboiddirbox.Text = LFGLoader.Properties.Settings.Default.zomboidDir;
        }

        private void minecraftclear_Click(object sender, EventArgs e)
        {
            LFGLoader.Properties.Settings.Default.minecraftDir = "";
            minecraftdirbox.Text = "";
        }
    }
}
