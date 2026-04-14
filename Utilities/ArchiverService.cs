using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace Gazar.Utilities
{
    public class ArchiverService
    {
        // Create a ZIP archive from a directory
        public void CreateArchive(string sourceDirectory, string destinationZipFile)
        {
            if (Directory.Exists(sourceDirectory))
            {
                ZipFile.CreateFromDirectory(sourceDirectory, destinationZipFile);
            }
            else
            {
                throw new DirectoryNotFoundException($"Source directory '{sourceDirectory}' not found.");
            }
        }

        // Extract a ZIP archive to a directory
        public void ExtractArchive(string zipFilePath, string destinationDirectory)
        {
            if (File.Exists(zipFilePath))
            {
                ZipFile.ExtractToDirectory(zipFilePath, destinationDirectory);
            }
            else
            {
                throw new FileNotFoundException($"ZIP file '{zipFilePath}' not found.");
            }
        }

        // List contents of a ZIP archive
        public List<string> ListArchiveContents(string zipFilePath)
        {
            List<string> entries = new List<string>();
            if (File.Exists(zipFilePath))
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        entries.Add(entry.FullName);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException($"ZIP file '{zipFilePath}' not found.");
            }
            return entries;
        }
    }
}