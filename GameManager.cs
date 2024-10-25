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

            string fileURL = "http://share.harryeffingpotter.com/u/zgELhC.zip";
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
                    HttpResponseMessage response = await client.GetAsync(fileURL);
                    response.EnsureSuccessStatusCode();

                    var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                    var canReportProgress = totalBytes != -1 && progress != null;

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        var fileName = GetFileNameFromUrl(fileURL);
                        var filePath = Path.Combine(downloadfolder, fileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                        {
                            var totalRead = 0L;
                            var buffer = new byte[8192];
                            var isMoreToRead = true;

                            do
                            {
                                var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                                if (read == 0)
                                {
                                    isMoreToRead = false;
                                    progress?.Report(100);
                                    continue;
                                }

                                await fileStream.WriteAsync(buffer, 0, read);

                                totalRead += read;

                                if (canReportProgress)
                                {
                                    var percentComplete = (int)((totalRead * 1d) / (totalBytes * 1d) * 100);
                                    progress?.Report(percentComplete);
                                }
                            }
                            while (isMoreToRead);
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine($"Access Denied: {ex.Message}");
                }
            }
        }

        private static string GetFileNameFromUrl(string url)
        {
            Uri uri = new Uri(url);
            return Path.GetFileName(uri.LocalPath);
        }
    }
}
