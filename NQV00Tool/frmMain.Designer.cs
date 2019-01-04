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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstviewFiles = new System.Windows.Forms.ListView();
            this.comboDiskList = new System.Windows.Forms.ComboBox();
            this.comboDiskFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboDiskList);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboDiskFormat);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "格式化";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "写入时间";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(12, 20);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(661, 172);
            this.lstMsg.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstviewFiles);
            this.groupBox3.Location = new System.Drawing.Point(190, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件列表";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstMsg);
            this.groupBox4.Location = new System.Drawing.Point(6, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 202);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息列表";
            // 
            // lstviewFiles
            // 
            this.lstviewFiles.Location = new System.Drawing.Point(11, 20);
            this.lstviewFiles.Name = "lstviewFiles";
            this.lstviewFiles.Size = new System.Drawing.Size(478, 191);
            this.lstviewFiles.TabIndex = 0;
            this.lstviewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // comboDiskList
            // 
            this.comboDiskList.FormattingEnabled = true;
            this.comboDiskList.Location = new System.Drawing.Point(92, 23);
            this.comboDiskList.Name = "comboDiskList";
            this.comboDiskList.Size = new System.Drawing.Size(82, 20);
            this.comboDiskList.TabIndex = 1;
            // 
            // comboDiskFormat
            // 
            this.comboDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiskFormat.FormattingEnabled = true;
            this.comboDiskFormat.Items.AddRange(new object[] {
            "FAT32",
            "exFAT"});
            this.comboDiskFormat.Location = new System.Drawing.Point(84, 29);
            this.comboDiskFormat.Name = "comboDiskFormat";
            this.comboDiskFormat.Size = new System.Drawing.Size(82, 20);
            this.comboDiskFormat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "磁盘格式:";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "手动加载";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;

    }
}

