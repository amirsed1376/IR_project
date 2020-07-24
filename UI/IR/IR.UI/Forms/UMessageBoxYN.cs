using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IR.UI.Forms
{
    public partial class UMessageBoxYN : Form
    {
        public UMessageBoxYN(string lbl,int ChkSt,string StrChk)
        {
            InitializeComponent();
            this.KeyPreview = true;
            label1.Text = lbl;
            StringChk = StrChk;
            ChkState = ChkSt;
            lblCheck.Text = StrChk;

            this.KeyPreview = true;
        }

        int ChkState = 0;
        string StringChk = "";

        private void UMessageBoxYN_Load(object sender, EventArgs e)
        {
            if(ChkState == 0)
            {
                lblCheck.Visible = false;
            }
            else
            {
                label1.Visible = false;
                BtnYes.Enabled = false;
                lblCheck.Visible = true;

                lblCheck.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void lblCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lblCheck.Checked)
            {
                BtnYes.Enabled = true;
            }
            else
                BtnYes.Enabled = false;
        }

        private void UMessageBoxYN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void lblCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(lblCheck.Checked)
                    lblCheck.Checked = false;
                else
                    lblCheck.Checked = true;
            }
        }
    }
}
