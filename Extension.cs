using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupApp
{
    public static class Extension
    {
        #region Directory Operation

        public static string getLastFolderString()
        {
            string day = System.DateTime.Now.Day.ToString();
            string month = System.DateTime.Now.ToString("MMM");
            string year = System.DateTime.Now.Year.ToString();
            string hour = System.DateTime.Now.Hour.ToString();
            string minute = System.DateTime.Now.Minute.ToString();
            string second = System.DateTime.Now.Second.ToString();
            return "Last_Backup_" + day + "_" + month + "_" + year + "_" + hour + "_" + minute + "_" + second;
        }

        #endregion

        #region Time Operation

        public static int getTimeType(string type)
        {
            switch (type)
            {
                case "Year(s)":
                    return Time.Type_Years;
                case "Month(s)":
                    return Time.Type_Months;
                case "Day(s)":
                    return Time.Type_Days;
                case "Hour(s)":
                    return Time.Type_Hours;
                case "Minute(s)":
                    return Time.Type_Minutes;
                case "Second(s)":
                    return Time.Type_Seconds;
            }
            return Time.Type_Minutes;
        }

        #endregion
    }
}
