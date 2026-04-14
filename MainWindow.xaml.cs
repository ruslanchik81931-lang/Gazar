using System;
using System.IO;
using System.IO.Compression;
using System.Windows;
using Microsoft.Win32;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CompressFiles(string[] files, string zipPath)
        {
            using (FileStream zipFileStream = new FileStream(zipPath, FileMode.Create))
            {
                using (ZipArchive zipArchive = new ZipArchive(zipFileStream, ZipArchiveMode.Create))
                {
                    foreach (string file in files)
                    {
                        zipArchive.CreateEntryFromFile(file, Path.GetFileName(file));
                    }
                }
            }
        }

        private void ExtractFiles(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private void SelectFilesToCompress()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                string zipPath = "compressed.zip"; // Define path for the compressed file
                CompressFiles(openFileDialog.FileNames, zipPath);
                MessageBox.Show("Files compressed successfully.");
            }
        }

        private void SelectZipToExtract()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip files (*.zip)|*.zip";
            if (openFileDialog.ShowDialog() == true)
            {
                string extractPath = "extracted"; // Define path for extraction
                ExtractFiles(openFileDialog.FileName, extractPath);
                MessageBox.Show("Files extracted successfully.");
            }
        }
    }
}