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
                            DriveInfo[] s = DriveInfo.GetDrives();
                            comboDiskList.Items.Clear();
                            foreach (DriveInfo drive in s)
                            {
                                if (drive.DriveType == DriveType.Removable)
                                {
                                    // updateMessage(lb_StateInfo, "U盘已插入，盘符为:" + drive.Name.ToString());
                                    //this.btn_EcjetSD.Enabled = true;
                                    //this.btn_UpdataFile.Enabled = true;
                                    ////Thread.Sleep(1000);
                                    //DestinFolder = drive.Name.ToString();
                                    comboDiskList.Items.Add(drive.Name);
                                    break;
                                }
                            }
                            if (comboDiskList.Items.Count > 0)
                                comboDiskList.SelectedIndex = 0;
         
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
                            //if (bCheckDevice)
                            //{
                            //    updateMessage(lb_StateInfo, "U盘已卸载！");
                            //}
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


    }
}
