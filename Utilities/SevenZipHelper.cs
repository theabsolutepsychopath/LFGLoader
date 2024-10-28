using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
namespace LFGLoader.Utilities
{
    public class SevenZipHelper
    {
        public static async Task Extract7zFileAsync(string archivePath, string extractPath)
        {
            if (!File.Exists(archivePath))
                throw new FileNotFoundException("The specified archive file does not exist.", archivePath);

            if (!Directory.Exists(extractPath))
                Directory.CreateDirectory(extractPath);

            try
            {
                await Task.Run(() =>
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo
                    {
                        FileName = $"{Environment.CurrentDirectory}\\7za.exe", // Ensure 7za.exe is in the same directory or provide the full path
                        Arguments = $"x \"{archivePath}\" -o\"{extractPath}\" -y",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process { StartInfo = processStartInfo })
                    {
                        process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
                        process.ErrorDataReceived += (sender, args) => Console.Error.WriteLine(args.Data);

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();

                        if (process.ExitCode != 0)
                        {
                            throw new InvalidOperationException($"7-Zip exited with code {process.ExitCode}");
                        }
                    }
                });

                LFGLoader.Instance.UpdateStatusBar("Finished extraction");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Extraction failed: " + ex.Message);
                throw new InvalidOperationException("Extraction failed.", ex);
            }
        }
    }
}