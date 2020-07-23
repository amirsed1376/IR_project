namespace IR.UI.Forms
{
    partial class UMessageBox
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
            this.PicAlert = new System.Windows.Forms.PictureBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PanelSym = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.settingChange = true;
            this.label1.Size = new System.Drawing.Size(362, 70);
            this.label1.TabIndex = 4;
            // 
            // PicAlert
            // 
            this.PicAlert.Image = global::IR.UI.Properties.Resources.no_success_icon3;
            this.PicAlert.Location = new System.Drawing.Point(360, 4);
            this.PicAlert.Name = "PicAlert";
            this.PicAlert.Size = new System.Drawing.Size(46, 42);
            this.PicAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAlert.TabIndex = 5;
            this.PicAlert.TabStop = false;
            this.PicAlert.Visible = false;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(173)))), ((int)(((byte)(73)))));
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Behnam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(160, 80);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(107, 34);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "تایید";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Behnam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(160, 80);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 34);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "تایید";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PanelSym
            // 
            this.PanelSym.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSym.Location = new System.Drawing.Point(417, 0);
            this.PanelSym.Name = "PanelSym";
            this.PanelSym.Size = new System.Drawing.Size(10, 120);
            this.PanelSym.TabIndex = 7;
            // 
            // UMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(427, 120);
            this.Controls.Add(this.PanelSym);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.PicAlert);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UMessageBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UMessageBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyComponent.Lbl label1;
        private System.Windows.Forms.PictureBox PicAlert;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PanelSym;
    }
}