using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 開新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void 分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (ToolStripMenuItem.Enabled==true)
            {
                pos2.Text = "60";
            }

        }

        private void TS1_Click(object sender, EventArgs e)
        {
            if (TS1.Enabled == true)
            {
                pos2.Text = "120";
            }

        }

        private void TS2_Click(object sender, EventArgs e)
        {
            if (TS2.Enabled == true)
            {
                pos2.Text = "300";
            }
        }

        private void TS3_Click(object sender, EventArgs e)
        {
            if (TS1.Enabled == true)
            {
                pos2.Text = "600";
            }
        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LTS1.Enabled == true)
            {
              
            }
        }
    }
}
