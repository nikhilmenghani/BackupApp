using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupApp
{
    public class Write
    {
        string sourcePath = "";
        string destPath = "";

        public Write(string sPath, string dPath)
        {
            this.sourcePath = sPath;
            this.destPath = dPath;
        }

        public void createFile(string path)
        {
            string fname = path.Substring(sourcePath.Length + 1);
            string tempDirectoryName = "Temp_" + Extension.getLastFolderString() + Path.DirectorySeparatorChar + fname;
            try
            {
                File.Copy(Path.Combine(sourcePath, fname), Path.Combine(destPath, tempDirectoryName), true);
            }
            catch (DirectoryNotFoundException e)
            {
                buildDirectory(Path.Combine(destPath, tempDirectoryName));
                createFile(path);
                Console.WriteLine(e.Message);
            }
        }

        public void renameDirectories()
        {
            try
            {
                removePrefix("Last_");
                removePrefix("Temp_");
            }
            catch (IOException ex)
            {
                ex.Message.ToString();
                deleteDirectory("Temp_");
                System.Windows.Forms.MessageBox.Show("Unable to proceed, leave the working directory!");
            }
        }

        private void deleteDirectory(string prefix)
        {
            
            string[] directories = Directory.GetDirectories(destPath);
            if (directories.Length != 0)
            {
                foreach (string directory in directories)
                {
                    string path = (destPath + Path.DirectorySeparatorChar + prefix).Replace("\\\\", "\\");
                    if (directory.StartsWith(path))
                    {
                        Directory.Delete(directory, true);
                    }
                }
            }
        }

        private void removePrefix(string prefix)
        {
            string [] directories = Directory.GetDirectories(destPath);
            if (directories.Length != 0)
            {
                foreach (string directory in directories)
                {
                    string path = (destPath + Path.DirectorySeparatorChar + prefix).Replace("\\\\", "\\");
                    if (directory.StartsWith(path))
                    {
                        Directory.Move(directory, directory.Replace(prefix,""));
                    }
                }
            }
        }

        private void buildDirectory(string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }
    }
}
