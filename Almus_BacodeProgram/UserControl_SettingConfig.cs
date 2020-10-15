using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using BarcodeSqliteLib;
using System.IO;
using PLC_CommLib;

namespace Almus_BacodeProgram
{
    public partial class UserControl_SettingConfig : UserControl, IUserControl
    {
        BarcodeTestResultInfo trInfo = new BarcodeTestResultInfo();
        string jsonFilePath = Path.Combine(Environment.CurrentDirectory, "testResultConf.json");

        FunctionSetting function = new FunctionSetting();
        string jsonFunctionSettingFilePath = Path.Combine(Environment.CurrentDirectory, "functionSetting.json");

        public LineCommInfo connectInfo = new LineCommInfo();
        string jsonRs232ConnectionFilePath = Path.Combine(Environment.CurrentDirectory, "rs232_connectionInfo.json");

        public UserControl_SettingConfig()
        {
            InitializeComponent();

            comboBox_A_Line.DataSource = CommPLC.SerialComm.GetSerialPorts();
            comboBox_B_Line.DataSource = CommPLC.SerialComm.GetSerialPorts();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.trInfo.Factory_Name = textBox_FactoryName.Text;
            this.trInfo.Line_Num = Int32.Parse(textBox_LineNum.Text);
            this.trInfo.Worker_Name = textBox_WorkerName.Text;

            string jsonSerializedData = JsonConvert.SerializeObject(trInfo, Formatting.Indented);

            using (FileStream fs = new FileStream(this.jsonFilePath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(jsonSerializedData);
                    bw.Flush();
                    bw.Close();
                }
                fs.Close();
            }

            connectInfo.connectInfoToA = comboBox_A_Line.Text;
            connectInfo.connectInfoToB = comboBox_B_Line.Text;

            connectInfo.UpdateConnectionConfig(connectInfo);

            MessageBox.Show(this, "Complete Save Data", "[Option]", MessageBoxButtons.OK);
        }



        private void UserControl_SettingConfig_Load(object sender, EventArgs e)
        {
            InitializeControlAddedEvent();
        }

        private void UserControl_SettingConfig_VisibleChanged(object sender, EventArgs e)
        {
            InitializeControlAddedEvent();
        }

        private void InitializeControlAddedEvent()
        {
            FileInfo existFunctionFileCheck = new FileInfo(this.jsonFunctionSettingFilePath);

            if (existFunctionFileCheck.Exists == true)
            {
                using (FileStream fs = new FileStream(this.jsonFunctionSettingFilePath, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        string jsonDeSerializedData = br.ReadString();
                        this.function = JsonConvert.DeserializeObject<FunctionSetting>(jsonDeSerializedData);
                        br.Close();
                    }
                    fs.Close();
                }
            }

            if (function.INSPECTION_INFO != false)
            {
                button_Save.Enabled = false;
                textBox_FactoryName.Enabled = false;
                textBox_FactoryName.Text = "";
                textBox_LineNum.Enabled = false;
                textBox_LineNum.Text = "0";
                textBox_WorkerName.Enabled = false;
                textBox_WorkerName.Text = "";

                return;
            }
            else
            {
                button_Save.Enabled = true;
                textBox_FactoryName.Enabled = true;
                textBox_LineNum.Enabled = true;
                textBox_WorkerName.Enabled = true;
            }

            FileInfo existCheck = new FileInfo(this.jsonFilePath);

            if (existCheck.Exists == true)
            {
                using (FileStream fs = new FileStream(this.jsonFilePath, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        string jsonDeSerializedData = br.ReadString();
                        this.trInfo = JsonConvert.DeserializeObject<BarcodeTestResultInfo>(jsonDeSerializedData);
                        br.Close();
                    }
                    fs.Close();
                }

                textBox_FactoryName.Text = trInfo.Factory_Name;
                textBox_LineNum.Text = trInfo.Line_Num.ToString();
                textBox_WorkerName.Text = trInfo.Worker_Name;
            }
            connectInfo.DownloadConnectionConfig(ref connectInfo);
            comboBox_A_Line.Text = connectInfo.connectInfoToA;
            comboBox_B_Line.Text = connectInfo.connectInfoToB;
        }
    }

    public class LineCommInfo
    {
        string jsonRs232ConnectionFilePath = Path.Combine(Environment.CurrentDirectory, "rs232_connectionInfo.json");
        public string connectInfoToA = "";
        public string connectInfoToB = "";

        public LineCommInfo()
        {
            FileInfo existConnectionInfoFileCheck = new FileInfo(this.jsonRs232ConnectionFilePath);

            if (existConnectionInfoFileCheck.Exists == true)
            {
                return;
            }
            else
            {
                this.UpdateConnectionConfig(null);
            }
        }

        public void UpdateConnectionConfig(LineCommInfo config)
        {
            string jsonSerializedData = JsonConvert.SerializeObject(config, Formatting.Indented);

            using (FileStream fs = new FileStream(this.jsonRs232ConnectionFilePath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(jsonSerializedData);
                    bw.Flush();
                    bw.Close();
                }

                fs.Close();
            }
        }

        public void DownloadConnectionConfig(ref LineCommInfo config)
        {
            using (FileStream fs = new FileStream(this.jsonRs232ConnectionFilePath, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    string jsonDeSerializedData = br.ReadString();
                    config = JsonConvert.DeserializeObject<LineCommInfo>(jsonDeSerializedData);
                    br.Close();
                }

                fs.Close();
            }
        }
    }
}
