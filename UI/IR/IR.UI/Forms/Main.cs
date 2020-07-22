using IR.UI.Common;
using MyComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IR.UI.Forms
{
    public partial class Main : FRM
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApplicationHelpers.RunCommand(@"D:\main.py","2","36","Mahdi");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSave_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBoxSave_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                btnOk.Text = "Search";
            else
                btnOk.Text = "Save";
        }
    }
}
