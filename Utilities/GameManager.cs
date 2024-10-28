using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFGLoader;

namespace LFGLoader.Utilities
{
    internal class GameManager
    {
        public static string MinecraftDownload = "http://share.harryeffingpotter.com/u/DL5els.7z";
        public static string ValheimDownload = "http://share.harryeffingpotter.com/u/DL5els.7z";
        public static string ProjectZomboidDownload = "http://share.harryeffingpotter.com/u/DL5els.7z";

        public async Task<string> ModGameAsync(string selectedGame)
        {
            if (selectedGame == "None")
            {
                NoGameSelected();
                return "Failure";
            }
            var path = FolderUtilities.GetGameModFolder(selectedGame);
            if (path == "")
            {
                MessageBox.Show("Game not installed.");
                return "Failure";
            }
            if (path == "Cancelled")
            {
                return "Failure";
            }
            await DownloadGameAsync(path, selectedGame);
            return "Success";
        }
        private async Task DownloadGameAsync(string gamePath, string gamename)
        {
            IProgress<int> progress = new Progress<int>(percent =>
            {
                LFGLoader.Instance.UpdateStatusBar($"Downloading... {percent}%");
            });
            var fileURL = GetGameUrl(gamename);
            int lastIndex = fileURL.LastIndexOf('/');
            string filename = fileURL.Substring(lastIndex + 1);
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filepath = Path.Combine(appdatadir, "LFGLoader", "storage", gamename, filename);
            // TODO: EXTRACT FILEPATH INTO DIRECTORY THEN SUPPLY THAT TO RUNADMINHELPER INSTEAD
            if (await GrabFilesAsync(fileURL, gamename, progress))
            {
                LFGLoader.Instance.UpdateStatusBar("Download complete... verifying file integrity.");
                var folderUtilities = new FolderUtilities();
                bool isMatch = await FolderUtilities.MD5FileCheckAsync(filepath, "7fc272addc955c0b208f85b9611bdced"); // this needs to be pulled from github or some shit
                if (!isMatch)
                {
                    LFGLoader.Instance.UpdateStatusBar("Download failed.");
                    await Task.Delay(3000);
                    LFGLoader.Instance.ResetStatusbar();
                    return;
                }
                LFGLoader.Instance.UpdateStatusBar("Download complete... moving files.");
                var modPath = GetGameModPath(gamename, gamePath);
                AdminHelperCreator.RunAdminHelper(modPath, filepath);
                // TODO: Move files
            }
            else
            {
                LFGLoader.Instance.UpdateStatusBar("Download failed.");
            }
            await Task.Delay(3000);
            LFGLoader.Instance.ResetStatusbar();
        }

        private static string GetGameModPath(string gamename, string gamepath)
        {
            return gamename switch
            {
                "valheim" => gamepath + "\\BepInEx",
                "projectzomboid" => "N/A",
                "minecraft" => gamepath,
                _ => "",
            };

        }
        private static string GetGameUrl(string selectedGame)
        {
            return selectedGame switch
            {
                "valheim" => ValheimDownload,
                "projectzomboid" => ProjectZomboidDownload,
                "minecraft" => MinecraftDownload,
                _ => "",
            };
        }
        private static void NoGameSelected()
        {
            MessageBox.Show("You must select a game to mod");
        }

        private async Task<bool> GrabFilesAsync(string fileURL, string gamename, IProgress<int> progress)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string downloadfolder = Path.Combine(appdatadir, "LFGLoader", "storage", gamename);

            if (Directory.Exists(downloadfolder))
            {
                Directory.Delete(downloadfolder, true);
            }
            Directory.CreateDirectory(downloadfolder);
            using HttpClient client = new();
            try
            {
                using HttpResponseMessage response = await client.GetAsync(fileURL, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                var canReportProgress = totalBytes != -1 && progress != null;

                using var contentStream = await response.Content.ReadAsStreamAsync();
                var fileName = GetFileNameFromUrl(fileURL);
                var filePath = Path.Combine(downloadfolder, fileName);

                using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 1048576, true); // Buffer size: 1MB
                var totalRead = 0L;
                var buffer = new byte[1048576]; // 1MB buffer for large files.
                var isMoreToRead = true;

                do
                {
                    var read = await contentStream.ReadAsync(buffer);
                    if (read == 0)
                    {
                        isMoreToRead = false;
                        progress?.Report(100); // Report 100% completion when done.
                        continue;
                    }

                    await fileStream.WriteAsync(buffer.AsMemory(0, read));

                    totalRead += read;

                    if (canReportProgress)
                    {
                        var percentComplete = (int)((totalRead * 1d) / (totalBytes * 1d) * 100);
                        progress?.Report(percentComplete); // Report progress.
                    }
                }
                while (isMoreToRead);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
                CleanUpIncompleteFiles(downloadfolder);
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access Denied: {ex.Message}");
                CleanUpIncompleteFiles(downloadfolder);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                CleanUpIncompleteFiles(downloadfolder);
                return false;
            }
            return true;
        }


        private static void CleanUpIncompleteFiles(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    // Optionally delete the folder itself or delete any partial files inside
                    foreach (var file in Directory.GetFiles(folderPath))
                    {
                        File.Delete(file); // Delete all files inside the folder
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning up incomplete files: {ex.Message}");
            }
        }

        private static string GetFileNameFromUrl(string url)
        {
            Uri uri = new(url);
            return Path.GetFileName(uri.LocalPath);
        }
    }
}
