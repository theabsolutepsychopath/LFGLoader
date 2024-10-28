using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace LFGLoader
{
    public class AdminHelperCreator
    {
        public static string CreateHelperExe()
        {
            // Path to save the helper executable
            string helperExePath = Path.Combine(Environment.CurrentDirectory, "AdminHelper.exe");

            // Check if the helper executable already exists
            if (File.Exists(helperExePath))
                return helperExePath;

            // Code to be included in the helper executable
            string helperCode = @"
                    using System;
                    using System.IO;
                    using System.Windows.Forms;

                    public class AdminHelper
                    {
                        public static void Main(string[] args)
                        {
                            if (args.Length < 2)
                            {
                                MessageBox.Show(""Usage: AdminHelper <sourcePath> <destinationPath>"");
                                return;
                            }

                            string sourcePath = args[0];
                            string destinationPath = args[1];

                            try
                            {
                                // Ensure the destination directory exists
                                Directory.CreateDirectory(destinationPath);

                                // Move files from source to destination
                                foreach (string file in Directory.GetFiles(sourcePath))
                                {
                                    string destFile = Path.Combine(destinationPath, Path.GetFileName(file));
                                    File.Move(file, destFile);
                                }

                                MessageBox.Show($""Files moved from '{sourcePath}' to '{destinationPath}'."");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($""Error: {ex.Message}"");
                            }
                        }
                    }";

            // Compile the helper executable
            var codeProvider = CodeDomProvider.CreateProvider("CSharp");
            var compilerParameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = helperExePath,
                CompilerOptions = "/target:winexe" // Prevent console window from appearing
            };

            // Add necessary references
            compilerParameters.ReferencedAssemblies.Add("System.dll");
            compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll"); // my fucking mom woke up somehow 

            // Compile the code
            CompilerResults results = codeProvider.CompileAssemblyFromSource(compilerParameters, helperCode);

            // Check for compile errors
            if (results.Errors.Count > 0)
            {
                throw new Exception("Failed to create helper executable: " + results.Errors[0].ErrorText);
            }

            return helperExePath;
        }

        public static void RunAdminHelper(string sourcePath, string destinationPath)
        {
            string helperExePath = CreateHelperExe();

            // Launch the helper executable with elevated privileges
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = helperExePath,
                Arguments = $"\"{sourcePath}\" \"{destinationPath}\"",
                Verb = "runas", // Trigger the UAC prompt
                UseShellExecute = true
            };

            try
            {
                var process = System.Diagnostics.Process.Start(startInfo);
                if (process != null)
                {
                    process.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Failed to start the process.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run helper with administrator privileges: {ex.Message}");
            }
        }
    }
}
