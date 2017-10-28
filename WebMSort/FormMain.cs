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

        public FormMain()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            InitializeComponent();
        }

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

            folderBrowserDialog.Description = "Select directory";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            if (Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                FFbase.FFmpegDir = folderBrowserDialog.SelectedPath;
            }
            else
            {
                MessageBox.Show("Incorrect directory.");
            }

            string dupa = SourceFolder.FilePaths[0];
            IMediaInfo videoInfo = new MediaInfo(dupa);

            bool audio;
            if (videoInfo.Properties.AudioFormat == "null")
            {
                audio = false;
            }
            else
            {
                audio = true;
            }
        }
    }
}
