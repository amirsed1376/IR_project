using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Acc_Plus.UI
{
    public partial class UMessageBox : Form
    {
        public UMessageBox(string label,int State_Msg)
        {
            InitializeComponent();
            label1.Text = label;
            State_Msg2 = State_Msg;
            this.KeyPreview = true;
            //label1.Location = new Point((this.Width - 177) - (label1.Size.Width / 2), 15);
        }

        int State_Msg2 = 0;

        private void UMessageBox_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.TopLeft;
            if (State_Msg2 == 2)
            {
         
                PanelSym.BackColor = Color.FromArgb(211, 29, 2);
                BtnAccept.Visible = false;
                BtnCancel.Visible = true;
                PicAlert.Visible = true;
                PicAlert.Image = IR.UI.Properties.Resources.no_success_icon3;
            }
            else
            {
                PanelSym.BackColor = Color.FromArgb(65, 173, 73);
                BtnCancel.Visible = false;
                BtnAccept.Visible = true;
                PicAlert.Visible = true;
                PicAlert.Image = IR.UI.Properties.Resources.Tick_Mark_Dark_512;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
