namespace IR.UI.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.lbl1 = new MyComponent.Lbl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new MyComponent.Btn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl7 = new MyComponent.Lbl();
            this.tbxDate = new MyComponent.Tbx();
            this.lbl8 = new MyComponent.Lbl();
            this.tbxWeightDate = new MyComponent.Tbx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl5 = new MyComponent.Lbl();
            this.tbxTitleSummary = new MyComponent.Tbx();
            this.lbl6 = new MyComponent.Lbl();
            this.tbxWeightSummary = new MyComponent.Tbx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new MyComponent.Lbl();
            this.tbxTitleText = new MyComponent.Tbx();
            this.lbl4 = new MyComponent.Lbl();
            this.tbxTitleWeight = new MyComponent.Tbx();
            this.chbxUsePageRank = new MyComponent.Chbx();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxAlpha = new MyComponent.Tbx();
            this.lbl2 = new MyComponent.Lbl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbxElasticURL = new MyComponent.Tbx();
            this.tbxJsonPath = new MyComponent.Tbx();
            this.tbxCSV = new MyComponent.Tbx();
            this.lbl11 = new MyComponent.Lbl();
            this.lbl10 = new MyComponent.Lbl();
            this.lbl9 = new MyComponent.Lbl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectJson = new MyComponent.Btn();
            this.btnSelectCSV = new MyComponent.Btn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.pictureBoxDelete);
            this.panel1.Controls.Add(this.pictureBoxSave);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 60);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::IR.UI.Properties.Resources.Del_p1;
            this.pictureBoxDelete.Location = new System.Drawing.Point(60, 12);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(30, 35);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 2;
            this.pictureBoxDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxDelete, "Delete from elastic");
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBoxDelete.MouseEnter += new System.EventHandler(this.pictureBoxSave_MouseEnter);
            this.pictureBoxDelete.MouseLeave += new System.EventHandler(this.pictureBoxSave_MouseLeave);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = global::IR.UI.Properties.Resources.Save_P2;
            this.pictureBoxSave.Location = new System.Drawing.Point(14, 12);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(30, 35);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave.TabIndex = 1;
            this.pictureBoxSave.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxSave, "Save json and data to elastic");
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxSave.MouseEnter += new System.EventHandler(this.pictureBoxSave_MouseEnter);
            this.pictureBoxSave.MouseLeave += new System.EventHandler(this.pictureBoxSave_MouseLeave);
            // 
            // lbl1
            // 
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl1.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl1.Location = new System.Drawing.Point(-399, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl1.settingChange = true;
            this.lbl1.Size = new System.Drawing.Size(818, 60);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "پروژه درس بازیابی اطلاعات - ترم 3982";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 55);
            this.panel2.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(162)))), ((int)(((byte)(55)))));
            this.btnOk.BeepSounds = true;
            this.btnOk.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(9, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.PaintCurves = true;
            this.btnOk.PaintNo = false;
            this.btnOk.PaintOthers = false;
            this.btnOk.PaintYes = true;
            this.btnOk.settingChange = true;
            this.btnOk.Size = new System.Drawing.Size(164, 40);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Search";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(419, 453);
            this.panel3.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Behnam", 11F);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 443);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chbxUsePageRank);
            this.tabPage1.Font = new System.Drawing.Font("Behnam", 11F);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl7);
            this.groupBox3.Controls.Add(this.tbxDate);
            this.groupBox3.Controls.Add(this.lbl8);
            this.groupBox3.Controls.Add(this.tbxWeightDate);
            this.groupBox3.Location = new System.Drawing.Point(11, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 114);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Publication Date";
            // 
            // lbl7
            // 
            this.lbl7.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl7.Location = new System.Drawing.Point(-8, 29);
            this.lbl7.Name = "lbl7";
            this.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl7.settingChange = true;
            this.lbl7.Size = new System.Drawing.Size(86, 25);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = "YYYY/MM :";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDate
            // 
            this.tbxDate.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxDate.Location = new System.Drawing.Point(84, 26);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.settingChange = true;
            this.tbxDate.Size = new System.Drawing.Size(288, 30);
            this.tbxDate.TabIndex = 3;
            // 
            // lbl8
            // 
            this.lbl8.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl8.Location = new System.Drawing.Point(-4, 70);
            this.lbl8.Name = "lbl8";
            this.lbl8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl8.settingChange = true;
            this.lbl8.Size = new System.Drawing.Size(82, 25);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "Weight : ";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxWeightDate
            // 
            this.tbxWeightDate.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxWeightDate.Location = new System.Drawing.Point(84, 70);
            this.tbxWeightDate.Name = "tbxWeightDate";
            this.tbxWeightDate.settingChange = true;
            this.tbxWeightDate.Size = new System.Drawing.Size(63, 30);
            this.tbxWeightDate.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl5);
            this.groupBox2.Controls.Add(this.tbxTitleSummary);
            this.groupBox2.Controls.Add(this.lbl6);
            this.groupBox2.Controls.Add(this.tbxWeightSummary);
            this.groupBox2.Location = new System.Drawing.Point(11, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 114);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl5.Location = new System.Drawing.Point(16, 29);
            this.lbl5.Name = "lbl5";
            this.lbl5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl5.settingChange = true;
            this.lbl5.Size = new System.Drawing.Size(62, 25);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "Text : ";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTitleSummary
            // 
            this.tbxTitleSummary.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxTitleSummary.Location = new System.Drawing.Point(84, 26);
            this.tbxTitleSummary.Name = "tbxTitleSummary";
            this.tbxTitleSummary.settingChange = true;
            this.tbxTitleSummary.Size = new System.Drawing.Size(288, 30);
            this.tbxTitleSummary.TabIndex = 3;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl6.Location = new System.Drawing.Point(-4, 70);
            this.lbl6.Name = "lbl6";
            this.lbl6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl6.settingChange = true;
            this.lbl6.Size = new System.Drawing.Size(82, 25);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "Weight : ";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxWeightSummary
            // 
            this.tbxWeightSummary.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxWeightSummary.Location = new System.Drawing.Point(84, 70);
            this.tbxWeightSummary.Name = "tbxWeightSummary";
            this.tbxWeightSummary.settingChange = true;
            this.tbxWeightSummary.Size = new System.Drawing.Size(63, 30);
            this.tbxWeightSummary.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.tbxTitleText);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.tbxTitleWeight);
            this.groupBox1.Location = new System.Drawing.Point(11, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 114);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl3.Location = new System.Drawing.Point(16, 29);
            this.lbl3.Name = "lbl3";
            this.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl3.settingChange = true;
            this.lbl3.Size = new System.Drawing.Size(62, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Text : ";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTitleText
            // 
            this.tbxTitleText.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxTitleText.Location = new System.Drawing.Point(84, 26);
            this.tbxTitleText.Name = "tbxTitleText";
            this.tbxTitleText.settingChange = true;
            this.tbxTitleText.Size = new System.Drawing.Size(288, 30);
            this.tbxTitleText.TabIndex = 3;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Behnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl4.Location = new System.Drawing.Point(-4, 70);
            this.lbl4.Name = "lbl4";
            this.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl4.settingChange = true;
            this.lbl4.Size = new System.Drawing.Size(82, 25);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Weight : ";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTitleWeight
            // 
            this.tbxTitleWeight.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxTitleWeight.Location = new System.Drawing.Point(84, 70);
            this.tbxTitleWeight.Name = "tbxTitleWeight";
            this.tbxTitleWeight.settingChange = true;
            this.tbxTitleWeight.Size = new System.Drawing.Size(63, 30);
            this.tbxTitleWeight.TabIndex = 5;
            // 
            // chbxUsePageRank
            // 
            this.chbxUsePageRank.Font = new System.Drawing.Font("Behnam", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbxUsePageRank.Location = new System.Drawing.Point(12, 6);
            this.chbxUsePageRank.Name = "chbxUsePageRank";
            this.chbxUsePageRank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbxUsePageRank.settingChange = true;
            this.chbxUsePageRank.Size = new System.Drawing.Size(195, 39);
            this.chbxUsePageRank.TabIndex = 0;
            this.chbxUsePageRank.Text = "Use Page Rank ?";
            this.chbxUsePageRank.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxAlpha);
            this.tabPage2.Controls.Add(this.lbl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page Rank";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxAlpha
            // 
            this.tbxAlpha.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxAlpha.Location = new System.Drawing.Point(132, 68);
            this.tbxAlpha.Name = "tbxAlpha";
            this.tbxAlpha.settingChange = true;
            this.tbxAlpha.Size = new System.Drawing.Size(131, 30);
            this.tbxAlpha.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl2.Location = new System.Drawing.Point(86, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.settingChange = true;
            this.lbl2.Size = new System.Drawing.Size(40, 25);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "α = ";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSelectCSV);
            this.tabPage3.Controls.Add(this.btnSelectJson);
            this.tabPage3.Controls.Add(this.tbxCSV);
            this.tabPage3.Controls.Add(this.lbl11);
            this.tabPage3.Controls.Add(this.tbxJsonPath);
            this.tabPage3.Controls.Add(this.lbl10);
            this.tabPage3.Controls.Add(this.tbxElasticURL);
            this.tabPage3.Controls.Add(this.lbl9);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(401, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Declare Path";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxElasticURL
            // 
            this.tbxElasticURL.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxElasticURL.Location = new System.Drawing.Point(151, 48);
            this.tbxElasticURL.Name = "tbxElasticURL";
            this.tbxElasticURL.settingChange = true;
            this.tbxElasticURL.Size = new System.Drawing.Size(203, 30);
            this.tbxElasticURL.TabIndex = 3;
            this.tbxElasticURL.Text = "http://localhost:9200/";
            // 
            // tbxJsonPath
            // 
            this.tbxJsonPath.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxJsonPath.Location = new System.Drawing.Point(150, 106);
            this.tbxJsonPath.Name = "tbxJsonPath";
            this.tbxJsonPath.settingChange = true;
            this.tbxJsonPath.Size = new System.Drawing.Size(204, 30);
            this.tbxJsonPath.TabIndex = 3;
            // 
            // tbxCSV
            // 
            this.tbxCSV.Font = new System.Drawing.Font("BenyaminNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbxCSV.Location = new System.Drawing.Point(150, 164);
            this.tbxCSV.Name = "tbxCSV";
            this.tbxCSV.settingChange = true;
            this.tbxCSV.Size = new System.Drawing.Size(204, 30);
            this.tbxCSV.TabIndex = 3;
            // 
            // lbl11
            // 
            this.lbl11.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl11.Location = new System.Drawing.Point(5, 167);
            this.lbl11.Name = "lbl11";
            this.lbl11.settingChange = true;
            this.lbl11.Size = new System.Drawing.Size(139, 25);
            this.lbl11.TabIndex = 2;
            this.lbl11.Text = "Meta Data CSV :";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl10
            // 
            this.lbl10.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl10.Location = new System.Drawing.Point(10, 109);
            this.lbl10.Name = "lbl10";
            this.lbl10.settingChange = true;
            this.lbl10.Size = new System.Drawing.Size(134, 25);
            this.lbl10.TabIndex = 2;
            this.lbl10.Text = "Jsons  Path :";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl9
            // 
            this.lbl9.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl9.Location = new System.Drawing.Point(41, 51);
            this.lbl9.Name = "lbl9";
            this.lbl9.settingChange = true;
            this.lbl9.Size = new System.Drawing.Size(103, 25);
            this.lbl9.TabIndex = 2;
            this.lbl9.Text = "Elastic URL :";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectJson
            // 
            this.btnSelectJson.BeepSounds = true;
            this.btnSelectJson.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.btnSelectJson.Location = new System.Drawing.Point(360, 106);
            this.btnSelectJson.Name = "btnSelectJson";
            this.btnSelectJson.PaintCurves = false;
            this.btnSelectJson.PaintNo = false;
            this.btnSelectJson.PaintOthers = false;
            this.btnSelectJson.PaintYes = false;
            this.btnSelectJson.settingChange = true;
            this.btnSelectJson.Size = new System.Drawing.Size(38, 30);
            this.btnSelectJson.TabIndex = 4;
            this.btnSelectJson.Text = "...";
            this.btnSelectJson.UseVisualStyleBackColor = true;
            this.btnSelectJson.Click += new System.EventHandler(this.btnSelectJson_Click);
            // 
            // btnSelectCSV
            // 
            this.btnSelectCSV.BeepSounds = true;
            this.btnSelectCSV.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.btnSelectCSV.Location = new System.Drawing.Point(360, 164);
            this.btnSelectCSV.Name = "btnSelectCSV";
            this.btnSelectCSV.PaintCurves = false;
            this.btnSelectCSV.PaintNo = false;
            this.btnSelectCSV.PaintOthers = false;
            this.btnSelectCSV.PaintYes = false;
            this.btnSelectCSV.settingChange = true;
            this.btnSelectCSV.Size = new System.Drawing.Size(38, 30);
            this.btnSelectCSV.TabIndex = 5;
            this.btnSelectCSV.Text = "...";
            this.btnSelectCSV.UseVisualStyleBackColor = true;
            this.btnSelectCSV.Click += new System.EventHandler(this.btnSelectCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyComponent.Lbl lbl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private MyComponent.Btn btnOk;
        private MyComponent.Tbx tbxAlpha;
        private MyComponent.Lbl lbl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MyComponent.Lbl lbl7;
        private MyComponent.Tbx tbxDate;
        private MyComponent.Lbl lbl8;
        private MyComponent.Tbx tbxWeightDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private MyComponent.Lbl lbl5;
        private MyComponent.Tbx tbxTitleSummary;
        private MyComponent.Lbl lbl6;
        private MyComponent.Tbx tbxWeightSummary;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyComponent.Lbl lbl3;
        private MyComponent.Tbx tbxTitleText;
        private MyComponent.Lbl lbl4;
        private MyComponent.Tbx tbxTitleWeight;
        private MyComponent.Chbx chbxUsePageRank;
        private System.Windows.Forms.TabPage tabPage3;
        private MyComponent.Btn btnSelectCSV;
        private MyComponent.Btn btnSelectJson;
        private MyComponent.Tbx tbxCSV;
        private MyComponent.Lbl lbl11;
        private MyComponent.Tbx tbxJsonPath;
        private MyComponent.Lbl lbl10;
        private MyComponent.Tbx tbxElasticURL;
        private MyComponent.Lbl lbl9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}