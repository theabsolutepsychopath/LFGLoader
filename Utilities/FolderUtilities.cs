using System.Security.Cryptography;

namespace LFGLoader.Utilities
{
    public class FolderUtilities
    {

        // Public method to set the selected game folder

        // Public method for MD5 check
        public static async Task<bool> MD5FileCheckAsync(string filepath, string expectedhash)
        {
            LFGLoader.Instance.UpdateStatusBar("Download complete... verifying file integrity.");
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filepath);
            var fileHashBytes = await Task.Run(() => md5.ComputeHash(stream));
            var fileHash = BitConverter.ToString(fileHashBytes).Replace("-", "").ToLowerInvariant();
            return fileHash.Equals(expectedhash, StringComparison.InvariantCultureIgnoreCase);
        }

        public static string GetGameModFolder(string selectedBoxName)
        {
            if (selectedBoxName == "None")
            {
                MessageBox.Show("You must select a game first!");
                return "";
            }
            return SelectedFolder(selectedBoxName);
        }

        private static string SelectedFolder(string selectedGame)
        {
            using FolderBrowserDialog folderbrowser = new();
            using OpenFileDialog filebrowser = new();
            folderbrowser.ShowNewFolderButton = false;
            string steamDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common";

            if (selectedGame == "minecraft")
            {
                if (Properties.Settings.Default.minecraftDir == "not initalized")
                {
                    string defaultMinecraftModFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.minecraft";
                    if (Directory.Exists(defaultMinecraftModFolder))
                    {
                        Properties.Settings.Default.minecraftDir = defaultMinecraftModFolder;
                        return defaultMinecraftModFolder;
                    }
                    folderbrowser.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}";
                    folderbrowser.Description = "Locate your \".minecraft\" folder.";
                    DialogResult result = folderbrowser.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderbrowser.SelectedPath))
                    {
                        Properties.Settings.Default.minecraftDir = folderbrowser.SelectedPath.EndsWith("\\.minecraft") ? folderbrowser.SelectedPath : "";
                        return folderbrowser.SelectedPath.EndsWith("\\.minecraft") ? folderbrowser.SelectedPath : "";
                    }
                }
                else
                {
                    return Properties.Settings.Default.minecraftDir;
                }
            }
            else if (selectedGame == "valheim")
            {
                string valheimDirectory = Path.Combine(steamDirectory, "Valheim");
                if (Directory.Exists(valheimDirectory))
                {
                    return valheimDirectory;
                }
                MessageBox.Show("Couldn't find your Valheim Installation. Please locate it manually.");
                return SelectExecutable(filebrowser, steamDirectory, "Valheim.exe");
            }
            else if (selectedGame == "projectzomboid")
            {
                string projectZomboidDirectory = Path.Combine(steamDirectory, "ProjectZomboid");
                if (Directory.Exists(projectZomboidDirectory))
                {
                    return projectZomboidDirectory;
                }
                MessageBox.Show("Couldn't find your Project Zomboid Installation. Please locate it manually.");
                return SelectExecutable(filebrowser, steamDirectory, "ProjectZomboid64.exe");
            }
            return "";
        }

        private static string SelectExecutable(OpenFileDialog filebrowser, string initialDirectory, string fileName)
        {
            filebrowser.InitialDirectory = initialDirectory;
            filebrowser.Filter = "Executable files (*.exe)|*.exe";
            filebrowser.Title = $"Locate {fileName}";
            filebrowser.FileName = fileName;

            while (true)
            {
                if (filebrowser.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetFileName(filebrowser.FileName) == fileName)
                    {
                        return Path.GetDirectoryName(filebrowser.FileName) ?? "";
                    }
                    MessageBox.Show("You need to select the correct executable.");
                }
                else
                {
                    return "Cancelled";
                }
            }
        }
    }
}
