using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            listview.View = View.Details;

        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="listbox"></param>
        private void LoadDisk(ComboBox combobox,ListBox listbox)
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

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDisk(comboDiskList, lstMsg);
        }

        private void btnClearMsg_Click(object sender, EventArgs e)
        {
            lstMsg.Items.Clear();
        }

    }
}
