using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFGMain;

namespace LFGMainWindow
{
    internal class GameManager
    {
        public static async Task ModThatGameAsync(string selectedgame)
        {
            switch (selectedgame)
            {
                case "boxLeft":
                    // Mod Valheim
                    ModValheim();
                    break;
                case "boxMiddle":
                    // Mod Project Zomboid
                    ModProjectZomboid();
                    break;
                case "boxRight":
                    // Mod Minecraft (asynchronously)
                    FolderUtilities.GetSelectedBox(selectedgame);
                    await ModMinecraftAsync();
                    break;
                default:
                    // No game selected
                    NoGameSelected();
                    break;
            }
        }

        private static void ModValheim()
        {
            Console.WriteLine("not making this yet");
        }

        private static void ModProjectZomboid()
        {
            Console.WriteLine("not making this yet");
        }

        private static async Task ModMinecraftAsync()
        {
            MessageBox.Show("Let's go!");
            // Grab the files :)

            string fileURL = "http://share.harryeffingpotter.com/u/rQ4ACD.jpg";
            string userdirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string minecraftdir = Path.Combine(userdirectory, ".minecraft");
            string gamename = "minecraftnon";

            Progress<int> progress = new Progress<int>(percent =>
            {
                // Update your UI here
                string percentnumber = $"Downloading... {percent}%";
                LFGLoader.UpdateStatusBar(percentnumber);  // Call to update the label
            });

            await GrabFilesAsync(fileURL, minecraftdir, gamename, progress);

            await Task.Delay(100);
            LFGLoader.ResetStatusbar(); // Reset the status bar
        }

        private static void NoGameSelected()
        {
            MessageBox.Show("No game selected, how are you even seeing this error?");
        }

        private static async Task GrabFilesAsync(string fileURL, string gamedir, string gamename, IProgress<int> progress)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string downloadfolder = Path.Combine(appdatadir, "GGLoader", "storage", gamename);

            if (!Directory.Exists(downloadfolder))
            {
                Directory.CreateDirectory(downloadfolder);
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage response = await client.GetAsync(fileURL, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();

                        var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                        var canReportProgress = totalBytes != -1 && progress != null;

                        using (var contentStream = await response.Content.ReadAsStreamAsync())
                        {
                            var fileName = GetFileNameFromUrl(fileURL);
                            var filePath = Path.Combine(downloadfolder, fileName);

                            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 1048576, true)) // Buffer size: 1MB
                            {
                                var totalRead = 0L;
                                var buffer = new byte[1048576]; // 1MB buffer for large files.
                                var isMoreToRead = true;

                                do
                                {
                                    var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                                    if (read == 0)
                                    {
                                        isMoreToRead = false;
                                        progress?.Report(100); // Report 100% completion when done.
                                        continue;
                                    }

                                    await fileStream.WriteAsync(buffer, 0, read);

                                    totalRead += read;

                                    if (canReportProgress)
                                    {
                                        var percentComplete = (int)((totalRead * 1d) / (totalBytes * 1d) * 100);
                                        progress?.Report(percentComplete); // Report progress.
                                    }
                                }
                                while (isMoreToRead);
                            }
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                    CleanUpIncompleteFiles(downloadfolder);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine($"Access Denied: {ex.Message}");
                    CleanUpIncompleteFiles(downloadfolder);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    CleanUpIncompleteFiles(downloadfolder);
                }
            }
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
            Uri uri = new Uri(url);
            return Path.GetFileName(uri.LocalPath);
        }
    }
}
