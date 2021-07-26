using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Edward;

namespace GetLineSpeed
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region 參數

        public static string WebService = "";
        public static string UploadInterval = "10";
        public static string IniFilePath =Application.StartupPath +@"/Config.ini";
        public static string PLCConfig = Application.StartupPath + @"/PLC.Json";
        public List<PLC> PLCList = new List<PLC>();

        public enum PLCTYPE
        {
            Q03UDE,
            Q03EDV,
            FX5U
        }

        public enum IniSection
        {
            SysConfig
        }

        public  class PLC
        {
            public string PLCIP { set; get; }
            public string Line { set; get; }
            public PLCTYPE PLCType { set; get; }
            public string Address { set; get; }
        }


        #endregion


        #region 自定義函數


        /// <summary>
        /// 加載默認的PLC信息
        /// </summary>
        private void LoadDefaultPLC()
        {

            PLC E1A = new PLC();
            E1A.Line = "E1A";
            E1A.PLCIP = "172.30.170.11";
            GetPLCDefaultAddress(ref E1A);
            E1A.PLCType = PLCTYPE.Q03UDE;
            PLCList.Add(E1A);

            PLC E1B = new PLC();
            E1B.Line = "E1B";
            E1B.PLCIP = "172.30.170.20";
            GetPLCDefaultAddress(ref E1B);
            E1B.PLCType = PLCTYPE.Q03UDE;
            PLCList.Add(E1B);

            PLC E2A = new PLC();
            E2A.Line = "E2A";
            E2A.PLCIP = "172.30.172.11";
            GetPLCDefaultAddress(ref E2A);
            E2A.PLCType = PLCTYPE.Q03UDE;
            PLCList.Add(E2A);

            PLC E2B = new PLC();
            E2B.Line = "E2B";
            E2B.PLCIP = "172.30.172.20";
            GetPLCDefaultAddress(ref E2B);
            E2B.PLCType = PLCTYPE.Q03UDE;
            PLCList.Add(E2B);

            PLC E3B = new PLC();
            E3B.Line = "E3B";
            E3B.PLCIP = "172.30.174.11";
            GetPLCDefaultAddress(ref E3B);
            E3B.PLCType = PLCTYPE.Q03UDE;
            PLCList.Add(E3B);

            if (!File.Exists(PLCConfig))
            {
                string Json1 = JsonConvert.SerializeObject(PLCList);
                StreamWriter sw = new StreamWriter(PLCConfig, true, Encoding.UTF8);
                sw.Write(Json1);
                sw.Close();
            }
        }

        /// <summary>
        /// 獲取默認的PLC 綫速地址
        /// </summary>
        /// <param name="plc"></param>
        public void GetPLCDefaultAddress(ref PLC plc)
        {
            switch (plc.PLCType)
            {
                case PLCTYPE.Q03UDE:
                    plc.Address = "D6090";
                    break;
                case PLCTYPE.Q03EDV :
                    plc.Address = "D6090";
                    break;
                case PLCTYPE.FX5U :
                    plc.Address = "D0";
                    break;
                default:
                    plc.Address = "D0";
                    break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadPLCList()
        {

            StreamReader sr = new StreamReader(PLCConfig, Encoding.UTF8);
            string result1 = sr.ReadToEnd();
            sr.Close();
            JsonSerializerSettings jsetting = new JsonSerializerSettings();
            jsetting.NullValueHandling = NullValueHandling.Ignore;
            jsetting.Formatting = Formatting.None;
            jsetting.MissingMemberHandling = MissingMemberHandling.Ignore;
            PLCList = (List<PLC>)Newtonsoft.Json.JsonConvert.DeserializeObject(result1, typeof(List<PLC>), jsetting);


            cbLine.Items.Clear();
            cbPLCIP.Items.Clear();
            
            //
            foreach (var item in PLCList)
            {
                cbLine.Items.Add(item.Line);
                cbPLCIP.Items.Add(item.PLCIP);
            }
            cbLine.SelectedIndex = -1;
            cbPLCIP.SelectedIndex = -1;
            cbPLCModel.SelectedIndex = -1;
        }




        /// <summary>
        /// 加載UI
        /// </summary>
        private void LoadUI()
        {

            //
            txtWebService.Text = WebService;
            txtInterval.Text = UploadInterval;
           

        }



        /// <summary>
        /// create ini file
        /// </summary>
        /// <param name="inifilepath">ini file path </param>
        public static void createIniFile(string inifilepath)
        {
            IniFile.CreateIniFile(inifilepath);
            //File.SetAttributes(inifilepath, FileAttributes.Hidden);

            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "WebService", WebService, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UploadInterval", UploadInterval, inifilepath);
 


        }


        /// <summary>
        /// read ini file value 
        /// </summary>
        /// <param name="inifilepath">ini file path</param>
        public static void readIniValue(string inifilepath)
        {

            WebService = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "WebService", inifilepath);
            UploadInterval = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UploadInterval", inifilepath);

        }


        /// <summary>
        /// 
        /// </summary>
        private void CtrlStart()
        {
            txtWebService.Enabled = false;
            txtInterval.Enabled = false;
            cbLine.Enabled = false;
            cbPLCIP.Enabled = false;
            cbPLCModel.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CtrlStop()
        {
            txtWebService.Enabled = true;
            txtInterval.Enabled = true;
            cbLine.Enabled = true;
            cbPLCIP.Enabled = true;
            cbPLCModel.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="plc"></param>
        /// <returns></returns>
        private bool OpenPLC(PLC plc)
        {

            switch (plc.PLCType)
            {
                case PLCTYPE.Q03UDE:
                    axActPLC.ActUnitType = 0x002C;
                    axActPLC.ActProtocolType = 0x008;
                    axActPLC.ActNetworkNumber = 0;
                    axActPLC.ActStationNumber = 255;
                    axActPLC.ActUnitNumber = 0;
                    axActPLC.ActConnectUnitNumber = 0;
                    axActPLC.ActIONumber = 0x03FF;
                    axActPLC.ActCpuType = 0x00D1;
                    axActPLC.ActPortNumber = 0;
                    axActPLC.ActBaudRate = 0;
                    axActPLC.ActDataBits = 0x0000;
                    axActPLC.ActParity = 0x0000;
                    axActPLC.ActStopBits = 0x0000;
                    axActPLC.ActControl = 0x0000;
                    axActPLC.ActHostAddress = plc.PLCIP;
                    axActPLC.ActCpuTimeOut = 0;
                    axActPLC.ActSumCheck = 0x0000;
                    axActPLC.ActDestinationPortNumber = 0x138E;

                    break;
                case PLCTYPE.Q03EDV:
                    axActPLC.ActUnitType = 0x002C;
                    axActPLC.ActProtocolType = 0x008;
                    axActPLC.ActNetworkNumber = 0;
                    axActPLC.ActStationNumber = 255;
                    axActPLC.ActUnitNumber = 0;
                    axActPLC.ActConnectUnitNumber = 0;
                    axActPLC.ActIONumber = 0x03FF;
                    axActPLC.ActCpuType = 0x0090;
                    axActPLC.ActPortNumber = 0;
                    axActPLC.ActBaudRate = 0;
                    axActPLC.ActDataBits = 0x0000;
                    axActPLC.ActParity = 0x0000;
                    axActPLC.ActStopBits = 0x0000;
                    axActPLC.ActControl = 0x0000;
                    axActPLC.ActHostAddress = plc.PLCIP;
                    axActPLC.ActCpuTimeOut = 0;
                    axActPLC.ActSumCheck = 0x0000;
                    axActPLC.ActDestinationPortNumber = 0x138E;

                    break;
                case PLCTYPE.FX5U:
                    axActPLC.ActUnitType = 0x2001;
                    axActPLC.ActProtocolType = 0x005;
                    axActPLC.ActNetworkNumber = 0;
                    axActPLC.ActStationNumber = 255;
                    axActPLC.ActUnitNumber = 0;
                    axActPLC.ActConnectUnitNumber = 0;
                    axActPLC.ActIONumber = 0x03FF;
                    axActPLC.ActCpuType = 0x0210;
                    axActPLC.ActPortNumber = 0;
                    axActPLC.ActBaudRate = 0;
                    axActPLC.ActDataBits = 0x0000;
                    axActPLC.ActParity = 0x0000;
                    axActPLC.ActStopBits = 0x0000;
                    axActPLC.ActControl = 0x0000;
                    axActPLC.ActHostAddress = plc.PLCIP;
                    axActPLC.ActCpuTimeOut = 0;
                    axActPLC.ActSumCheck = 0x0000;
                    axActPLC.ActDestinationPortNumber = 0x15BA;
                    break;
                default:
                    break;
            }

            
            int  iReturn  =-1;
            iReturn = axActPLC.Open();
            if (iReturn == 0)
                return true;
            else
                return false;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="plc"></param>
        private void ClosePLC(PLC plc)
        {

        }
        #endregion

        #region 窗體

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists(IniFilePath))
                createIniFile(IniFilePath);
            readIniValue(IniFilePath); //
            if (!File.Exists (PLCConfig ))
                LoadDefaultPLC();
            ReadPLCList();
            LoadUI();
            CtrlStop();

        }

        private void cbPLCIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string it = cbPLCIP.Text.Trim();
            foreach (var item in PLCList)
            {
                if (it == item.PLCIP)
                {
                    cbLine.Text = item.Line;
                    cbPLCModel.SelectedIndex = (int)item.PLCType;
                    break;
                }
            }
        }

        private void cbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string it = cbLine.Text.Trim();
            foreach (var item in PLCList)
            {
                if (it == item.Line)
                {
                    cbPLCIP.Text = item.PLCIP;
                    cbPLCModel.SelectedIndex = (int)item.PLCType;
                    break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbLine.SelectedIndex = -1;
            cbPLCModel.SelectedIndex = -1;
            cbPLCIP.SelectedIndex = -1;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            CtrlStart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CtrlStop();
        }


        private void txtWebService_TextChanged(object sender, EventArgs e)
        {
            WebService = txtWebService.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "WebService", WebService, IniFilePath);
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            UploadInterval = txtInterval.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UploadInterval", UploadInterval, IniFilePath);

        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPLCIP.Text))
            {
                MessageBox.Show("PLCIP is empty,pls check and retry.", "PLCIP EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cbLine.Text))
            {
                MessageBox.Show("Line is empty,pls check and retry.", "LINE EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPLCModel.SelectedIndex == -1)
            {
                MessageBox.Show("PLCModel is empty,pls check and retry.", "PLCMODEL EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckPLCIPIsExist (cbPLCIP.Text.Trim ()))
               return;
            if (CheckLineIsExist(cbLine.Text.Trim()))
               return;

            PLC plc = new PLC();
            plc.PLCIP = cbPLCIP.Text.Trim();
            plc.Line = cbLine.Text.Trim();
            plc.PLCType = (PLCTYPE) cbPLCModel.SelectedIndex;
            GetPLCDefaultAddress(ref plc);
            PLCList.Add(plc);
            if (File.Exists(PLCConfig))
                File.Delete(PLCConfig);
            string Json1 = JsonConvert.SerializeObject(PLCList);
            StreamWriter sw = new StreamWriter(PLCConfig, true, Encoding.UTF8);
            sw.Write(Json1);
            sw.Close();
            MessageBox.Show("添加成功");
            ReadPLCList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="plcip"></param>
        /// <returns></returns>
        private bool CheckPLCIPIsExist(string plcip)
        {

            foreach (var item in PLCList)
            {
                if (plcip == item.PLCIP)
                {
                    MessageBox.Show(plcip + " is already exist,pls check and retry.", "PLCIP EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }


            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool CheckLineIsExist(string line)
        {
            foreach (var item in PLCList)
            {
                if (line == item.PLCIP)
                {
                    MessageBox.Show(line + " is already exist,pls check and retry.", "LINE EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPLCIP.Text))
            {
                MessageBox.Show("PLCIP is empty,pls check and retry.", "PLCIP EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cbLine.Text))
            {
                MessageBox.Show("Line is empty,pls check and retry.", "LINE EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PLC plc = new PLC();
            plc.PLCIP = cbPLCIP.Text.Trim();
            plc.Line = cbLine.Text.Trim();
            plc.PLCType = (PLCTYPE)cbPLCModel.SelectedIndex;
            GetPLCDefaultAddress(ref plc);

            for (int i = 0; i < PLCList.Count; i++)
            {

                if (plc.PLCIP == PLCList[i].PLCIP)
                {
                    PLCList.RemoveAt(i);
                    break;
                }
                

            }

            //foreach (var item in PLCList)
            //{
            //    if (item == plc)
            //        if (PLCList.Remove(item))
            //            MessageBox.Show("remove ok");
            //        else
            //            MessageBox.Show("Remove ng");
            //}
             


            if (File.Exists(PLCConfig))
                File.Delete(PLCConfig);
            string Json1 = JsonConvert.SerializeObject(PLCList);
            StreamWriter sw = new StreamWriter(PLCConfig, true, Encoding.UTF8);
            sw.Write(Json1);
            sw.Close();
            ReadPLCList();
            MessageBox.Show("刪除成功");
          
            
        }





   
    }
}
