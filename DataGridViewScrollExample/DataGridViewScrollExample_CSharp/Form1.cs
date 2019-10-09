using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewScrollExample_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper hScrollHelper;
        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;
        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView1, GunaHScrollBar1, true);
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView1, GunaVScrollBar1, true);
            Random r = new Random();
            for (int i = 0; i <= 40; i++)
            {
                DataGridView1.Rows.Add(new object[] { i, r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000) });
            }
            hScrollHelper.UpdateScrollBar();
            vScrollHelper.UpdateScrollBar();
        }

        private void DataGridView1_Resize(object sender, EventArgs e)
        {
            if (hScrollHelper != null) hScrollHelper.UpdateScrollBar();
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }
    }
}
