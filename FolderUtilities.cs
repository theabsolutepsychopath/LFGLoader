using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFGMainWindow
{
    public class FolderUtilities
    {
       // 55 CHEESE BURGERS 55 FRIES
        public static string GetSelectedBox(string selectedBoxName)
        {
            string FolderPath = "this broke please fix";
            if ( selectedBoxName == "None")
            {
                MessageBox.Show("No box selected, how are you even seeing this error?");
            }
            else
            {
                MessageBox.Show("Box selected: " + selectedBoxName);
                switch (selectedBoxName)
                {
                    case "boxLeft":
                        FolderPath = "C:\\Program Files (x86)\\steam\\steamapps\\common\\Valheim\\";
                        break;
                    case "boxMiddle":
                        FolderPath = "C:\\Program Files (x86)\\steam\\steamapps\\common\\ProjectZomboid\\";
                        break;
                    case "boxRight":
                        string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        FolderPath = System.IO.Path.Combine(userDirectory, ".minecraft");
                        break;
                    default:
                        MessageBox.Show("No box selected, how are you even seeing this error?");
                        break;
                    case null:
                        MessageBox.Show("No box detected?!?!?!?, how are you even seeing this error?");
                        break;
                }
            }

            return FolderPath;
        }

        public static bool CheckFolderExists(string selectedBoxName)
        {
            string FolderPath = GetSelectedBox(selectedBoxName);
            if (!System.IO.Directory.Exists(FolderPath))
            {
                return false;
            }
            return true;
        }

        public static void ChooseFolder()
        {
            
        }
    }
}
