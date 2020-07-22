namespace Acc_Plus.UI
{
    partial class UMessageBoxYN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new MyComponent.Lbl();
            this.lblCheck = new MyComponent.Chbx();
            this.BtnYes = new MyComponent.Btn();
            this.BtnCancel = new MyComponent.Btn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.settingChange = true;
            this.label1.Size = new System.Drawing.Size(422, 38);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Behnam", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.lblCheck.Location = new System.Drawing.Point(12, 9);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCheck.settingChange = true;
            this.lblCheck.Size = new System.Drawing.Size(416, 36);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.UseVisualStyleBackColor = true;
            this.lblCheck.CheckedChanged += new System.EventHandler(this.lblCheck_CheckedChanged);
            this.lblCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblCheck_KeyDown);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.White;
            this.BtnYes.BeepSounds = true;
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYes.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.BtnYes.Image = global::IR.UI.Properties.Resources.tik3;
            this.BtnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYes.Location = new System.Drawing.Point(252, 66);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.PaintCurves = false;
            this.BtnYes.PaintNo = false;
            this.BtnYes.PaintOthers = false;
            this.BtnYes.PaintYes = false;
            this.BtnYes.settingChange = true;
            this.BtnYes.Size = new System.Drawing.Size(89, 34);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "    تایید";
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.BeepSounds = true;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.BtnCancel.Image = global::IR.UI.Properties.Resources.delete2;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(145, 66);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.PaintCurves = false;
            this.BtnCancel.PaintNo = false;
            this.BtnCancel.PaintOthers = false;
            this.BtnCancel.PaintYes = false;
            this.BtnCancel.settingChange = true;
            this.BtnCancel.Size = new System.Drawing.Size(89, 34);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "     انصراف";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnYes);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 120);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IR.UI.Properties.Resources.Qus_P3;
            this.pictureBox1.Location = new System.Drawing.Point(437, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UMessageBoxYN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 130);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UMessageBoxYN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UMessageBoxYN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UMessageBoxYN_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyComponent.Btn BtnCancel;
        private MyComponent.Btn BtnYes;
        private MyComponent.Lbl label1;
        private MyComponent.Chbx lblCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}