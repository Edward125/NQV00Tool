using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NQV00Tool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        #region MyRegion

        public const int WM_DEVICECHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;
        public const int DBT_CONFIGCHANGED = 0x0018;
        public const int DBT_CUSTOMEVENT = 0x8006;
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;
        public const int DBT_DEVNODES_CHANGED = 0x0007;
        public const int DBT_QUERYCHANGECONFIG = 0x0017;
        public const int DBT_USERDEFINED = 0xFFFF;


        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        case DBT_DEVICEARRIVAL://U盘插入
                            LoadDisk(comboDiskList, lstMsg);
                            break;
                        case DBT_CONFIGCHANGECANCELED:
                            break;
                        case DBT_CONFIGCHANGED:
                            break;
                        case DBT_CUSTOMEVENT:
                            break;
                        case DBT_DEVICEQUERYREMOVE:
                            break;
                        case DBT_DEVICEQUERYREMOVEFAILED:
                            break;
                        case DBT_DEVICEREMOVECOMPLETE: //U盘卸载
                            LoadDisk(comboDiskList, lstMsg);
                            break;
                        case DBT_DEVICEREMOVEPENDING:
                            break;
                        case DBT_DEVICETYPESPECIFIC:
                            break;
                        case DBT_DEVNODES_CHANGED:
                            break;
                        case DBT_QUERYCHANGECONFIG:
                            break;
                        case DBT_USERDEFINED:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {


            }
            base.WndProc(ref m);
        }


        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }


        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            comboDiskFormat.SelectedIndex = 0;
            InitListview(lstviewFiles);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        private void InitListview(ListView listview)
        {
            listview.Clear();
            listview.View = View.Details;
            listview.MultiSelect = false;
            listview.AutoArrange = true;
            listview.GridLines = true;
            listview.FullRowSelect = true;
            listview.Columns.Add("序号", 40, HorizontalAlignment.Center);
            listview.Columns.Add("文件名", 350, HorizontalAlignment.Center);
            listview.Columns.Add("大小", 90, HorizontalAlignment.Center);
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="listbox"></param>
        private void LoadDisk(ComboBox combobox, ListBox listbox)
        {
            DriveInfo[] s = DriveInfo.GetDrives();
            combobox.Items.Clear();
            foreach (DriveInfo drive in s)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    updateMessage(listbox, "侦测到可移动磁盘,盘符:" + drive.Name);
                    combobox.Items.Add(drive.Name);
                }
            }
            if (combobox.Items.Count > 0)
                combobox.SelectedIndex = 0;

        }



        #region 更新信息
        /// <summary>
        /// 更新信息到listbox中
        /// </summary>
        /// <param name="listbox">listbox name</param>
        /// <param name="message">message</param>
        public static void updateMessage(ListBox listbox, string message)
        {
            if (listbox.Items.Count > 100)
                listbox.Items.RemoveAt(0);

            string item = string.Empty;
            //listbox.Items.Add("");
            item = DateTime.Now.ToString("HH:mm:ss") + " " + @message;
            listbox.Items.Add(item);
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }
        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="filescount"></param>
        /// <param name="fileextension"></param>
        /// <param name="oldname"></param>
        /// <param name="newname"></param>
        /// <param name="filefolder"></param>
        private void AddItem2ListView(ListView listview, int fileindex, string filename, long filesize)
        {
            //listview.Items.Clear();
            listview.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
            ListViewItem lt = new ListViewItem();
            lt = listview.Items.Add(fileindex.ToString());
            lt.SubItems.Add(filename);
            lt.SubItems.Add(filesize.ToString());
            listview.EndUpdate();//结束数据处理，UI界面一次性绘制。


        }



        private void button3_Click(object sender, EventArgs e)
        {
            LoadDisk(comboDiskList, lstMsg);
        }

        private void btnClearMsg_Click(object sender, EventArgs e)
        {
            lstMsg.Items.Clear();
        }

        private void comboDiskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Disk = comboDiskList.Text.Trim();
            string folder = txtFolder.Text.Trim();
            string FileFolder = string.Empty;
            lstviewFiles.Items.Clear();

            if (string.IsNullOrEmpty(Disk))
                return;
            if (!Disk.EndsWith(@"\"))
                Disk = Disk + @"\";
            FileFolder = Disk + folder;

            DirectoryInfo di = new DirectoryInfo(FileFolder);
            if (!di.Exists)
            {
                updateMessage(lstMsg, FileFolder + "不存在,请重新确认.");
                return;
            }
            else
            {
                FileInfo[] fis = di.GetFiles();
                int fileindex = 0;
                foreach (FileInfo fi in fis)
                {
                    fileindex++;
                    AddItem2ListView(lstviewFiles, fileindex, fi.Name, fi.Length);

                }
            }


            //播放第一个视频
            if (lstviewFiles.Items.Count > 0)
            {
                string file = FileFolder + @"\" + lstviewFiles.Items[0].SubItems[1].Text;
                string vlc = @".\VLC\vlc.exe";
                updateMessage(lstMsg, "播放" + file);
                Thread t = new Thread(new ParameterizedThreadStart(PlayVideo));
                t.Start(vlc + " " + file);


            }


        }



        private void PlayVideo(object file)
        {
            Process pp = new Process();
            string strInput = file.ToString();
            //设置要启动的应用程序
            pp.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            pp.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            pp.StartInfo.RedirectStandardInput = true;
            //输出信息
            pp.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            pp.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            //p.StartInfo.CreateNoWindow = true;
            pp.StartInfo.CreateNoWindow = true;
            //启动程序
            pp.Start();
            //向cmd窗口发送输入信息
            pp.StandardInput.WriteLine(strInput);
            pp.StandardInput.AutoFlush = true;
            ////获取输出信息
            //string strOuput = pp.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            pp.WaitForExit();
            pp.Close();
        }

        private void lstviewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstviewFiles.Items.Count > 0)
            {
                if (string.IsNullOrEmpty(lstviewFiles.SelectedItems[0].SubItems[1].Text))
                    return;
                string file = comboDiskList.Text.Trim() + @"\" + txtFolder.Text.Trim() + @"\" + lstviewFiles.SelectedItems[0].SubItems[1].Text;
                string vlc = @".\VLC\vlc.exe";
                updateMessage(lstMsg, "播放" + file);
                Thread t = new Thread(new ParameterizedThreadStart(PlayVideo));
                t.Start(vlc + " " + file);
            }
        }



        /// <summary>
        /// 格式化设备
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        private bool FormatDisk(string disk, string format)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process process = Process.Start(processStartInfo);
            if (process != null)
            {
                process.StandardInput.WriteLine(@"FORMAT " + disk + " /y /FS:" + format + " /Q");
                process.StandardInput.Close();
                string outputString = process.StandardOutput.ReadToEnd();

                foreach (string  item in outputString.Split ('\r'))
                {
                    if (!string.IsNullOrEmpty (item .Trim ()))
                       updateMessage(lstMsg, item.Trim());
                }


                if (outputString.Contains("已完成"))
                    return true;
                else
                    return false;
            }
            return false;
        }

        private void btnFormatDisk_Click(object sender, EventArgs e)
        {

            string disk = comboDiskList.Text.Trim();

            if (string.IsNullOrEmpty(disk))
                return;
            else
            {
                if (!Directory.Exists(disk))
                {
                    updateMessage(lstMsg, disk + "不存在,请重新确认.");
                    return;
                }
            }

            if (disk.EndsWith(@"\"))
                disk = disk.Replace(@"\", "");

            if (FormatDisk(disk, comboDiskFormat.Text))
                updateMessage(lstMsg, "格式化" + comboDiskList.Text + "为" + comboDiskFormat.Text + "成功.");
            else
                updateMessage(lstMsg, "格式化" + comboDiskList.Text + "为" + comboDiskFormat.Text + "失败.");
            
        }
    }
}
