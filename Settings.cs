using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void close_Click(object sender, EventArgs e)
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
            LFGLoader.Properties.Settings.Default.minecraftDir = "not initalized";
            minecraftdirbox.Text = "not initalized";
        }
        private void valheimclear_Click(object sender, EventArgs e)
        {
            LFGLoader.Properties.Settings.Default.valheimDir = "not initalized";
            valheimdirbox.Text = "not initalized";
        }
        private void zomboidclear_Click(object sender, EventArgs e)
        {
            LFGLoader.Properties.Settings.Default.zomboidDir = "not initalized";
            zomboiddirbox.Text = "not initalized";
        }

        private void minecraftbrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderbrowser = new();
            folderbrowser.ShowNewFolderButton = false;
            folderbrowser.Description = "Locate your \".minecraft\" folder.";
            folderbrowser.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}";

            while (true)
            {
                DialogResult result = folderbrowser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderbrowser.SelectedPath))
                {
                    if ((folderbrowser.SelectedPath.EndsWith("\\.minecraft")))
                    {
                        LFGLoader.Properties.Settings.Default.minecraftDir = folderbrowser.SelectedPath.EndsWith("\\.minecraft") ? folderbrowser.SelectedPath : "";
                        LFGLoader.Properties.Settings.Default.Save();
                        minecraftdirbox.Text = folderbrowser.SelectedPath.EndsWith("\\.minecraft") ? folderbrowser.SelectedPath : "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You need to select the correct folder.");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void valheimbrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderbrowser = new();
            folderbrowser.ShowNewFolderButton = false;
            folderbrowser.Description = "Locate your Valheim folder.";
            folderbrowser.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common";

            while (true)
            {
                DialogResult result = folderbrowser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderbrowser.SelectedPath))
                {
                    if (folderbrowser.SelectedPath.Contains("Valheim"))
                    {
                        LFGLoader.Properties.Settings.Default.valheimDir = folderbrowser.SelectedPath;
                        LFGLoader.Properties.Settings.Default.Save();
                        valheimdirbox.Text = folderbrowser.SelectedPath;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You need to select the correct folder.");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void zomboidbrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderbrowser = new();
            folderbrowser.ShowNewFolderButton = false;
            folderbrowser.Description = "Locate your Project Zomboid folder.";
            folderbrowser.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common";

            while (true)
            {
                DialogResult result = folderbrowser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderbrowser.SelectedPath))
                {
                    if (folderbrowser.SelectedPath.Contains("ProjectZomboid"))
                    {
                        LFGLoader.Properties.Settings.Default.zomboidDir = folderbrowser.SelectedPath;
                        LFGLoader.Properties.Settings.Default.Save();
                        zomboiddirbox.Text = folderbrowser.SelectedPath;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You need to select the correct folder.");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void resetvalues_Click(object sender, EventArgs e)
        {
            LFGLoader.Properties.Settings.Default.Reset();
            LFGLoader.Properties.Settings.Default.Save();
            minecraftdirbox.Text = LFGLoader.Properties.Settings.Default.minecraftDir;
            valheimdirbox.Text = LFGLoader.Properties.Settings.Default.valheimDir;
            zomboiddirbox.Text = LFGLoader.Properties.Settings.Default.zomboidDir;
        }
    }
}
