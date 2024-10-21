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
        public static string GetSelectedBox()
        {
            string selectedBoxName = LFGMainWindow.Properties.Settings.Default.selectedBox;
            string FolderPath = "this broke please fix";
            if ( selectedBoxName == "None")
            {
                Console.WriteLine("No box selected, how are you even seeing this error?");
            }
            else
            {
                Console.WriteLine("Box selected: " + selectedBoxName);
                switch (selectedBoxName)
                {
                    case "boxLeft":
                        Console.WriteLine("Box Left selected");
                        FolderPath = "C:\\Program Files (x86)\\steam\\steamapps\\common\\Valheim\\";
                        break;
                    case "boxMiddle":
                        Console.WriteLine("Box Middle selected");
                        FolderPath = "C:\\Program Files (x86)\\steam\\steamapps\\common\\ProjectZomboid\\";
                        break;
                    case "boxRight":
                        Console.WriteLine("Box Right selected");
                        string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        FolderPath = System.IO.Path.Combine(userDirectory, ".minecraft");
                        break;
                    default:
                        Console.WriteLine("No box selected, how are you even seeing this error?");
                        break;
                    case null:
                        Console.WriteLine("No box detected?!?!?!?, how are you even seeing this error?");
                        break;
                }
            }

            return FolderPath;
        }

        public static bool CheckFolderExists()
        {
            string FolderPath = GetSelectedBox();
            if (!System.IO.Directory.Exists(FolderPath))
            {
                return false;
            }
            return true;
        }
    }
}
