﻿using System;
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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 開新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 form = new form1();
            form.Show();
        }
    }
}
