using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupApp
{
    public class Operation
    {

        #region Global

        //this will prepare a comma separated string of non redundant extensions
        public string getExtensionString(List<MyFile> fileList)
        {
            List<string> extnList = getMyFilesExtension(fileList);
            string str = "";
            foreach (string item in extnList)
            {
                str += item + ",";
            }
            return str.Substring(0, str.Length - 1);
        }

        //this will be the final list of files that is to be backed up
        public List<MyFile> getFilteredMyFilesList(List<MyFile> filesList, string extensions)
        {
            List<string> extnList = getExtensionList(extensions);
            List<MyFile> filteredList = new List<MyFile>();
            foreach (MyFile myFile in filesList)
            {
                if (extnList.Contains(myFile.extension))
                {
                    filteredList.Add(myFile);
                }
            }
            return filteredList;
        }

        #endregion

        #region Local

        //this prepares a list from comma separated values of extensions
        private List<string> getExtensionList(string extensions)
        {
            List<string> extnList = new List<string>();
            foreach (string item in extensions.Split(','))
            {
                extnList.Add(item);
            }
            return extnList;
        }

        //this will return list of non redundant extensions
        private List<string> getMyFilesExtension(List<MyFile> fileList)
        {
            List<string> extnList = new List<string>();
            foreach (MyFile file in fileList)
            {
                if (!extnList.Contains(file.extension))
                {
                    extnList.Add(file.extension);
                }
            }
            return extnList;
        }

        #endregion
    }
}
