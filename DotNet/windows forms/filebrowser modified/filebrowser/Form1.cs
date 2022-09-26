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

namespace filebrowser
{
    public partial class Form1 : Form
    {
        List<string> listFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    foreach (string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);
                    }
                }
            }
        }
    }
}
