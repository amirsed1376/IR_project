using IR.UI.Common;
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
    public partial class Loading_Gif : Form
    {
        public Loading_Gif()
        {
            InitializeComponent();

          
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ApplicationHelpers.FLGLoging)
            {

                timer1.Stop();
                this.Close();
            }
        }

        private void Loading_Gif_Load(object sender, EventArgs e)
        {

        }
    }
}

