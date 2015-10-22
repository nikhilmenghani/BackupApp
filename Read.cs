using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupApp
{
    public class Read
    {
        public List<string> filePathsList;

        private List<string> getFilePathsList(string path)
        {
            filePathsList = new List<string>();
            getFiles(path);
            return filePathsList;
        }

        //this will return list of all file objects
        public List<MyFile> getAllFilesList(string path, int time, int type)
        {
            List<MyFile> list = new List<MyFile>();
            foreach (string file in getFilePathsList(path))
            {
                list.Add(new MyFile(file, time, type));
            }
            return list;
        }

        //this will return list of all modified file objects
        public List<MyFile> getModifiedFilesList(string path, int time, int type)
        {
            List<MyFile> list = new List<MyFile>();
            foreach (string file in getFilePathsList(path))
            {
                MyFile myFile = new MyFile(file, time, type);
                if (myFile.isModified)
                {
                    list.Add(myFile);
                }
            }
            return list;
        }

        private void getFiles(string path)
        {
            if (Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (var item in directories)
                {
                    getFiles(item);
                }
                foreach (var item in Directory.GetFiles(path))
                {
                    filePathsList.Add(item);
                }
            }
            else if (File.Exists(path))
            {
                filePathsList.Add(path);
            }
        }
    }
}
