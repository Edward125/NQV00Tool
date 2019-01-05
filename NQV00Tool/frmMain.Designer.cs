namespace NQV00Tool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDiskList = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstviewFiles = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDiskFormat = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFormatDisk = new System.Windows.Forms.Button();
            this.btnClearMsg = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.btnManual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboDiskList);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(23, 105);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(158, 30);
            this.btnManual.TabIndex = 1;
            this.btnManual.Text = "手动加载";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "磁盘列表:";
            // 
            // comboDiskList
            // 
            this.comboDiskList.FormattingEnabled = true;
            this.comboDiskList.Location = new System.Drawing.Point(92, 23);
            this.comboDiskList.Name = "comboDiskList";
            this.comboDiskList.Size = new System.Drawing.Size(82, 20);
            this.comboDiskList.TabIndex = 1;
            this.comboDiskList.SelectedIndexChanged += new System.EventHandler(this.comboDiskList_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstMsg);
            this.groupBox4.Location = new System.Drawing.Point(192, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 181);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息列表";
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.HorizontalScrollbar = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(12, 20);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(469, 148);
            this.lstMsg.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstviewFiles);
            this.groupBox3.Location = new System.Drawing.Point(190, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件列表";
            // 
            // lstviewFiles
            // 
            this.lstviewFiles.Location = new System.Drawing.Point(11, 17);
            this.lstviewFiles.Name = "lstviewFiles";
            this.lstviewFiles.Size = new System.Drawing.Size(478, 125);
            this.lstviewFiles.TabIndex = 0;
            this.lstviewFiles.UseCompatibleStateImageBehavior = false;
            this.lstviewFiles.DoubleClick += new System.EventHandler(this.lstviewFiles_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearMsg);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboDiskFormat);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnFormatDisk);
            this.groupBox2.Location = new System.Drawing.Point(6, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能列表";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "磁盘格式:";
            // 
            // comboDiskFormat
            // 
            this.comboDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiskFormat.FormattingEnabled = true;
            this.comboDiskFormat.Items.AddRange(new object[] {
            "FAT32",
            "exFAT"});
            this.comboDiskFormat.Location = new System.Drawing.Point(84, 21);
            this.comboDiskFormat.Name = "comboDiskFormat";
            this.comboDiskFormat.Size = new System.Drawing.Size(82, 20);
            this.comboDiskFormat.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "写入时间";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFormatDisk
            // 
            this.btnFormatDisk.Location = new System.Drawing.Point(18, 56);
            this.btnFormatDisk.Name = "btnFormatDisk";
            this.btnFormatDisk.Size = new System.Drawing.Size(151, 30);
            this.btnFormatDisk.TabIndex = 2;
            this.btnFormatDisk.Text = "格式化";
            this.btnFormatDisk.UseVisualStyleBackColor = true;
            this.btnFormatDisk.Click += new System.EventHandler(this.btnFormatDisk_Click);
            // 
            // btnClearMsg
            // 
            this.btnClearMsg.Location = new System.Drawing.Point(17, 148);
            this.btnClearMsg.Name = "btnClearMsg";
            this.btnClearMsg.Size = new System.Drawing.Size(151, 30);
            this.btnClearMsg.TabIndex = 6;
            this.btnClearMsg.Text = "清除列表信息";
            this.btnClearMsg.UseVisualStyleBackColor = true;
            this.btnClearMsg.Click += new System.EventHandler(this.btnClearMsg_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(22, 76);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(162, 21);
            this.txtFolder.TabIndex = 7;
            this.txtFolder.Text = "DCIM\\100MEDIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "文件夹路径:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboDiskList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstviewFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboDiskFormat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFormatDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnClearMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolder;

    }
}

