using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WebMSort
{
    /// <summary>
    /// Base class for folders.
    /// </summary>
    public abstract class Folder
    {
        public string FolderPath { get; set; }

        public Folder()
        {
            FolderPath = "";
        }
    }

    /// <summary>
    /// Source folder containing files for processing.
    /// </summary>
    public class SourceFolder : Folder
    {
        /// <summary>
        /// List of all the files.
        /// </summary>
        public List<string> FilePaths { get; set; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="FolderPath"> Directory path.</param>
        public SourceFolder(string folderPath)
        {
            //if (Directory.Exists(FolderPath))
            //{
            //    FolderPath = FolderPath;
            //    ProcessDirectory();
            //}

            FolderPath = folderPath;
            ProcessDirectory();
        }

        /// <summary>
        /// Populates FilePaths with all the files inside the directory then removes ones that have incorrect extensions.
        /// </summary>
        private void ProcessDirectory()
        {
            FilePaths = Directory.GetFiles(FolderPath).ToList();
            for (int i = FilePaths.Count - 1; i > -1; i--)
            {
                if (Path.GetExtension(FilePaths[i]) != ".webm")
                {
                    FilePaths.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Checks if there are any files left for processing.
        /// </summary>
        /// <returns> True - there are files left; False - directory has no suitable files. </returns>
        public bool AreThereFilesLeft(int currentIndex)
        {
            if (currentIndex >= FilePaths.Count)
            {
                return false;
            }
            return true;
        }
    }

}
