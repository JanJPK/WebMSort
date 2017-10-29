using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace WebMSort
{
    public partial class FormMain : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        public SourceFolder SourceFolder { get; set; }
        public bool FFmpegFound;

        public FormMain()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (Properties.Settings.Default.FFmpegPath != null &&
                File.Exists(Properties.Settings.Default.FFmpegPath + "\\ffmpeg.exe"))
            {
                FFbase.FFmpegDir = Properties.Settings.Default.FFmpegPath;
                FFmpegFound = true;
            }
            else
            {
                FFmpegFound = false;
            }

            InitializeComponent();
            textBoxNoSoundFilename.Text = Properties.Settings.Default.NSFilename;
            textBoxSoundFilename.Text = Properties.Settings.Default.SFilename;
            textBoxNoSoundFolderName.Text = Properties.Settings.Default.NSFolderName;
            textBoxSoundFolderName.Text = Properties.Settings.Default.SFolderName;

            // RenamingMode = true  => Renaming.
            // RenamingMode = false => Sorting.
            if (Properties.Settings.Default.RenamingMode)
            {
                radioButtonRenaming.Checked = true;
            }
            else
            {
                radioButtonSorting.Checked = true;
            }
        }

        /// <summary>
        /// Browsing for source folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select directory";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            if (Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                SourceFolder = new SourceFolder(folderBrowserDialog.SelectedPath);
            }
            else
            {
                MessageBox.Show("Incorrect directory.");
            }
        }

        /// <summary>
        /// Locating FFmpeg bin folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFFmpegDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select FFmpeg bin folder";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            if (Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                if (File.Exists(folderBrowserDialog.SelectedPath + "\\ffmpeg.exe"))
                {
                    FFbase.FFmpegDir = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.FFmpegPath = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    FFmpegFound = true;
                }
                else
                {
                    MessageBox.Show("No ffmpeg.exe present in directory.");
                    FFmpegFound = false;
                }  
            }
            else
            {
                MessageBox.Show("Incorrect directory.");
            }
        }

        /// <summary>
        /// Begins renaming/sorting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            if (FFmpegFound)
            {
                if (SourceFolder != null && SourceFolder.FilePaths.Count > 0)
                {
                    if (radioButtonRenaming.Checked)
                    {
                        RenameFiles();
                    }
                    else
                    {
                        SortFolder();
                    }
                    SourceFolder.ProcessDirectory();
                }
                else
                {
                    MessageBox.Show("Source folder is empty or not chosen.");
                }
            }
            else
            {
                MessageBox.Show("FFmpeg not found.");
            }
        }

        /// <summary>
        /// Renames the files - inserts string of choice in front of filename.
        /// </summary>
        private void RenameFiles()
        {
            foreach (string path in SourceFolder.FilePaths)
            {
                IMediaInfo videoInfo = new MediaInfo(path);
                string newPath;
                if (videoInfo.Properties.AudioFormat == null)
                {
                    newPath = path.Replace(Path.GetFileName(path), Properties.Settings.Default.NSFilename + Path.GetFileName(path));
                }
                else
                {
                    newPath = path.Replace(Path.GetFileName(path), Properties.Settings.Default.SFilename + Path.GetFileName(path));
                }

                if (!File.Exists(newPath))
                {
                    File.Move(path, newPath);
                }
            }
        }

        /// <summary>
        /// Sorts the files - moves them into two different directories.
        /// </summary>
        private void SortFolder()
        {
            string nsFolder = SourceFolder.FolderPath + "\\" + Properties.Settings.Default.NSFolderName;
            string sFolder = SourceFolder.FolderPath + "\\" + Properties.Settings.Default.SFolderName;
            Directory.CreateDirectory(nsFolder);
            Directory.CreateDirectory(sFolder);

            foreach (string path in SourceFolder.FilePaths)
            {
                IMediaInfo videoInfo = new MediaInfo(path);
                if (videoInfo.Properties.AudioFormat == null)
                {
                    File.Move(path, nsFolder + "\\" + Path.GetFileName(path));
                }
                else
                {
                    File.Move(path, sFolder + "\\" + Path.GetFileName(path));
                }
            }
        }

        /// <summary>
        /// Saving file/directory names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            if (textBoxNoSoundFilename.Text != null)
            {
                Properties.Settings.Default.NSFilename = textBoxNoSoundFilename.Text;
            }
            if (textBoxSoundFilename.Text != null)
            {
                Properties.Settings.Default.SFilename = textBoxSoundFilename.Text;
            }
            if (textBoxNoSoundFolderName.Text != null)
            {
                Properties.Settings.Default.NSFolderName = textBoxNoSoundFolderName.Text;
            }
            if (textBoxSoundFolderName.Text != null)
            {
                Properties.Settings.Default.SFolderName = textBoxSoundFolderName.Text;
            }
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Checking if Properties.Settings mode should be changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonRenaming_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRenaming.Checked)
            {
                Properties.Settings.Default.RenamingMode = true;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Checking if Properties.Settings mode should be changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSorting_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRenaming.Checked)
            {
                Properties.Settings.Default.RenamingMode = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
