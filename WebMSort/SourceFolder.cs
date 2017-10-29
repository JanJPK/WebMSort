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
    public class SourceFolder
    {
        /// <summary>
        /// List of all the files.
        /// </summary>
        public List<string> FilePaths { get; set; }

        public string FolderPath { get; set; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="FolderPath"> Directory path.</param>
        public SourceFolder(string folderPath)
        {
            FolderPath = folderPath;
            ProcessDirectory();
        }

        /// <summary>
        /// Populates FilePaths with all the files inside the directory then removes ones that have incorrect extensions.
        /// </summary>
        public void ProcessDirectory()
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
    }
}
