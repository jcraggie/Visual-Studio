using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // added by JCR

namespace CSfileCopierJCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

private void FillDirectoryTree(TreeView tvw, bool isSource)
{
    tvw.Nodes.Clear();
    string[] strDrives = Environment.GetLogicalDrives();
    foreach (string rootDirectoryName in strDrives)
    {
        try
        {
            DirectoryInfo dir = new DirectoryInfo(rootDirectoryName);
            dir.GetDirectories();
        }
        catch
        { }
        Application.DoEvents();
      }
}
