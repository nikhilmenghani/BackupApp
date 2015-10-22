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

namespace BackupApp
{
    public partial class MyForm : Form
    {
        public String sourcePath = "";//@"E:\Dir";
        public String destPath = @"C:\Dirbackup";
        public int time = 60;
        public int type = Time.Type_Minutes;
        Operation o = new Operation();
        Read r = new Read();
        public MyForm()
        {
            InitializeComponent();
        }

        private int getTimeType()
        {
            string type = "";
            if (!cbTimeUnit.Text.Equals(""))
            {
                type = cbTimeUnit.SelectedItem.ToString();
            }
            else
            {
                type = cbTimeUnit.Text;
            }
            return Extension.getTimeType(type);
        }

        private void browseInputDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                if (!txtTime.Text.Equals(""))
                {
                    time = Convert.ToInt32(txtTime.Text);
                }
                type = getTimeType();
                string file = folderBrowserDialog.SelectedPath;
                txtDirectoryFromBackup.Text = file;
                this.sourcePath = file;
                List<MyFile> modifiedFilesList = r.getModifiedFilesList(sourcePath, time, type);
                if (modifiedFilesList.Count > 0)
                {
                    string extensionString = o.getExtensionString(modifiedFilesList);
                    txtExtensions.Text = extensionString;
                }
                else
                {
                    txtExtensions.Text = "";
                }

            }
        }

        private void startBackup_Click(object sender, EventArgs e)
        {
            if (!txtTime.Text.Equals(""))
            {
                time = Convert.ToInt32(txtTime.Text);
            }
            type = getTimeType();
            Read r = new Read();
            Operation o = new Operation();
            Write w = new Write(sourcePath, destPath);
            foreach (MyFile file in o.getFilteredMyFilesList(r.getModifiedFilesList(sourcePath, time, type), txtExtensions.Text))
            {
                w.createFile(file.path);
            }
            try
            {
                w.renameDirectories();
            }
            catch (DirectoryNotFoundException dnfe)
            {
                dnfe.Message.ToString();
            }
            MessageBox.Show("Operation Completed");
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void loadExtension_Click(object sender, EventArgs e)
        {
            if (!txtTime.Text.Equals(""))
            {
                time = Convert.ToInt32(txtTime.Text);
            }
            type = getTimeType();
            string file = folderBrowserDialog.SelectedPath;
            txtDirectoryFromBackup.Enabled = false;
            txtDirectoryFromBackup.Text = file;
            this.sourcePath = file;
            List<MyFile> modifiedFilesList = r.getModifiedFilesList(sourcePath, time, type);
            if (modifiedFilesList.Count > 0)
            {
                string extensionString = o.getExtensionString(modifiedFilesList);
                txtExtensions.Text = extensionString;
            }
            else
            {
                txtExtensions.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseOutputDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = folderBrowserDialog.SelectedPath;
                txtDirectoryToBackup.Text = file;
                this.destPath = file;
            }
        }
    }
}
