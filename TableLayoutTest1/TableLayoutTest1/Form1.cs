using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayoutTest1
{
    public partial class Form1 : Form
    {
        List<Label> lblNames = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = 0;
            string labelName = "lbl" + row.ToString();

            //TableLayoutPanel tlp1 = new TableLayoutPanel();
            tlp1.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            tlp1.Controls.Add(new Label() { Text = labelName, Anchor = AnchorStyles.Left, AutoSize = true, Name = labelName }, 1, 0);
            //lblNames.Add(labelName);

            row++;
            labelName = "lbl" + row.ToString();
            tlp1.Controls.Add(new Label() { Text = labelName, Anchor = AnchorStyles.Left, AutoSize = true, Name = labelName }, 1, 1);

            tlp1.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 0, 1);
            //tlp1.RowCount++;
            tlp1.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 0, 2);

            TableLayoutPanel tlp2 = new TableLayoutPanel();
            tlp2.Controls.Add(new Label() { Text = "Type2:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            tlp2.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 0, 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
