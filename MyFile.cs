using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupApp
{
    public class MyFile
    {
        public bool isModified = false;
        public string path;
        public string extension;
        public string name;
        DateTime referenceTime;

        public MyFile(string path, int modifiedAfterTime, int modifiedTimeType)
        {
            this.name = Path.GetFileName(path);
            this.extension = Path.GetExtension(path);
            this.path = path;
            switch (modifiedTimeType)
            {
                //positive means file is modified after reference time.
                //Note: Current time is always greater than any other past time
                case Time.Type_Seconds:
                    referenceTime = System.DateTime.Now.AddSeconds(-modifiedAfterTime);
                    this.isModified = ((((new FileInfo(path)).LastWriteTime) - referenceTime).TotalSeconds > 0) ? true : false;
                    break;
                case Time.Type_Minutes:
                    referenceTime = System.DateTime.Now.AddMinutes(-modifiedAfterTime);
                    this.isModified = ((((new FileInfo(path)).LastWriteTime) - referenceTime).TotalMinutes > 0) ? true : false;
                    break;
                case Time.Type_Hours:
                    referenceTime = System.DateTime.Now.AddHours(-modifiedAfterTime);
                    this.isModified = ((((new FileInfo(path)).LastWriteTime) - referenceTime).TotalHours > 0) ? true : false;
                    break;
                case Time.Type_Days:
                    referenceTime = System.DateTime.Now.AddDays(-modifiedAfterTime);
                    this.isModified = ((((new FileInfo(path)).LastWriteTime) - referenceTime).TotalDays > 0) ? true : false;
                    break;
                default:
                    break;
            }
        }
    }
}
