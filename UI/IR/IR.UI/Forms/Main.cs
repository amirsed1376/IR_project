using IR.UI.Common;
using MyComponent;
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

using System.Threading;
using System.Diagnostics;

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
            if (string.IsNullOrWhiteSpace(tbxElasticURL.Text))
            {
                (new UI.Forms.UMessageBox("لطفا ابتدا URl الستیک را وارد کنید", 2)).ShowDialog();
                tabControl1.SelectedTab = tabControl1.TabPages[2];
                tbxElasticURL.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxCSV.Text))
            {
                (new UI.Forms.UMessageBox("لطفا ابتدا مسیر فایل SCV را انتخاب کنید", 2)).ShowDialog();
                tabControl1.SelectedTab = tabControl1.TabPages[2];
                tbxCSV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxJsonPath.Text))
            {
                (new UI.Forms.UMessageBox("لطفا ابتدا مسیر فایل Json را انتخاب کنید", 2)).ShowDialog();
                tabControl1.SelectedTab = tabControl1.TabPages[2];
                tbxJsonPath.Focus();
                return;
            }
            //ApplicationHelpers.RunCommand("\'" + Path.Combine(Directory.GetCurrentDirectory(), "Scripts", "main.py") + "\'", "\'2\'",
            //    $"\'{tbxElasticURL.Text}\'", $"\'{tbxJsonPath.Text}\'", $"\'{tbxCSV.Text}\'");

            ApplicationHelpers.RunExeFile("2", tbxElasticURL.Text, tbxJsonPath.Text, tbxCSV.Text);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxElasticURL.Text))
            {
                (new UI.Forms.UMessageBox("لطفا ابتدا URl الستیک را وارد کنید", 2)).ShowDialog();
                tabControl1.SelectedTab = tabControl1.TabPages[2];
                tbxElasticURL.Focus();
                return;
            }
            //ApplicationHelpers.RunCommand("\'" + Path.Combine(Directory.GetCurrentDirectory(), "Scripts", "main.py") + "\'", "\'1\'",
            //    $"\'{tbxElasticURL.Text}\'");

            //ApplicationHelpers.RunCommand("\'" + Path.Combine(Directory.GetCurrentDirectory(), "Scripts", "main.py")+"\'" );
            //ApplicationHelpers.RunCommand2("\'" + Path.Combine(Directory.GetCurrentDirectory(), "Scripts", "main.py") + "\'");

            ApplicationHelpers.RunExeFile("1", tbxElasticURL.Text);
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
            { 
                btnOk.Text = "Search";
                btnOk.Visible = true;
            }
            else if (tabControl1.SelectedIndex == 1)
            { 
                btnOk.Text = "Save";
                btnOk.Visible = true;
            }
            else
            {
                btnOk.Visible = false;
            }

        }

        private void btnSelectJson_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxJsonPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSelectCSV_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxCSV.Text = openFileDialog1.FileName;
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(tbxAlpha.Text))
                {
                    (new UI.Forms.UMessageBox("لطفا ابتدا مقدار آلفا را وارد کنید", 2)).ShowDialog();
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                    tbxAlpha.Focus();
                    return;
                }

                //ApplicationHelpers.RunCommand("\'" + Path.Combine(Directory.GetCurrentDirectory(), "Scripts", "main.py") + "\'", "\'3\'",
                //    $"\'{tbxElasticURL.Text}\'", $"\'{tbxAlpha.Text}\'");

                ApplicationHelpers.RunExeFile("3", tbxElasticURL.Text, tbxAlpha.Text);
            }
        }
    }
}
