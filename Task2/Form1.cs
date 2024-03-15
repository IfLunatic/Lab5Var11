using System;
using System.IO;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderRadioButton.Checked)
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    DialogResult result = dialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    {
                        folderPathTextBox.Text = dialog.SelectedPath;
                        DisplayFolderInfo(dialog.SelectedPath);
                    }
                }
            }
            else if (fileRadioButton.Checked)
            {
                using (var dialog = new OpenFileDialog())
                {
                    DialogResult result = dialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                    {
                        folderPathTextBox.Text = dialog.FileName;
                        DisplayFileInfo(dialog.FileName);
                    }
                }
            }
        }

        private void DisplayFolderInfo(string folderPath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

                string folderName = directoryInfo.Name;
                long folderSize = GetDirectorySize(directoryInfo);
                DateTime lastModified = directoryInfo.LastWriteTime;

                folderInfoLabel.Text = $"Folder name: {folderName}\nSize: {folderSize} bytes\nLast modified: {lastModified}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving folder information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayFileInfo(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                string fileName = fileInfo.Name;
                long fileSize = fileInfo.Length;
                DateTime lastModified = fileInfo.LastWriteTime;

                folderInfoLabel.Text = $"File name: {fileName}\nSize: {fileSize} bytes\nLast edited by: {lastModified}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving file information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long GetDirectorySize(DirectoryInfo directoryInfo)
        {
            long size = 0;

            // Get the files in the directory
            FileInfo[] files = directoryInfo.GetFiles();

            // Calculate the total size of files in the directory
            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            // Recursively get the size of subdirectories
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                size += GetDirectorySize(subDirectory);
            }

            return size;
        }
    }
}
