// #define USE_USB_HID
#define RS232_COMM

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using BarcodeSqliteLib;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

using PLC_CommLib;

namespace Almus_BacodeProgram
{
    public partial class UserControl_Scanning : UserControl, IUserControl
    {
        ErrorAlarmForm errorAlarmForm;

        BarcodeTestResult_CRUD testResult_CRUD;
        BarcodeTestResultInfo testResultInfo = new BarcodeTestResultInfo();

        BarcodeReferenceCode_CRUD code_CRUD;
        SQLiteConnection conn = null;
        string connStr = null;

        DataSet master_ds = new DataSet();
        DataSet box_ds = new DataSet();
        DataSet lot_ds = new DataSet();

        LineCommInfo commInfo = null; // COMM line config.
        CommPLC commLib = null; // PLC contr library.

        FunctionSetting function = new FunctionSetting();
        string jsonFunctionSettingFilePath = Path.Combine(Environment.CurrentDirectory, "functionSetting.json");
        string jsonFilePath = Path.Combine(Environment.CurrentDirectory, "testResultConf.json");
        string jsonRs232ConnectionFilePath = Path.Combine(Environment.CurrentDirectory, "rs232_connectionInfo.json");

        StringBuilder scannedCode = new StringBuilder();
        string masterCode = "";
        int masterIndex = 0;
        string boxCode = "";
        int boxIndex = 0;
        string lotCode = "";
        int lotIndex = 0;

        int sample_1Box = 0; //DB
        int tray_1Box = 0; //DB
        int sample_Tray = 0; //DB

        int currentTestCount = 0; //DB
        int currentLotNumber = 1; //TEST
        int currentSeqQty = 0;

        int sumOfPassCount = 0; // DISP
        int sumOfLot = 1; //DB
        int sumOfTestCount = 0; //
        int passCount = 0; //TEST
        int failCount = 0;

        public UserControl_Scanning()
        {
            InitializeComponent();
            InitializeDatabaseConfig();
        }
        private void InitializeDatabaseConfig()
        {
            string currentFolder = Environment.CurrentDirectory;
            string path = Path.Combine(currentFolder, "BarcodeDatabase.sqlite");
            connStr = "Data Source=" + path + ";" + "version=3;";

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                code_CRUD = new BarcodeReferenceCode_CRUD(conn);
                master_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                box_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                lot_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
            }
        }

        private void FocusTimer_Tick(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Scanned;
        }

#if (RS232_COMM)

        // TODO: add functions.

        private void Line_A_Test_Callback(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                textBox_Scanned.Text = "";
                textBox_Scanned.Text = sender as string;

                if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                {
                    if (this.currentLotNumber > this.tray_1Box)
                    {
                        if (textBox_Scanned.Text == boxCode)
                        {
                            textBox_Scanned.Text = "Complete Box";
                            Interlocked.Exchange(ref sumOfPassCount, 0);
                            Interlocked.Exchange(ref failCount, 0);
                            Interlocked.Increment(ref sumOfLot);
                            Interlocked.Exchange(ref currentLotNumber, 1);
                            Interlocked.Exchange(ref currentSeqQty, 0);

                            this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";
                            this.label_TrayNumber.Text = this.currentLotNumber.ToString();
                            this.label_TestCount.Text = this.currentSeqQty.ToString();

                            return;
                        }
                        else
                        {
                            textBox_Scanned.Text = "Scan Box Code !";
                            
                            return;
                        }
                    }

                    if (this.passCount >= this.sample_Tray) // lot + 1
                    {
                        // CHECK LOT CODE
                        if (textBox_Scanned.Text == lotCode)
                        {
                            Interlocked.Exchange(ref passCount, 0);
                            Interlocked.Increment(ref currentLotNumber);
                            Interlocked.Increment(ref sumOfLot);
                            textBox_Scanned.Text = "";
                            this.label_TrayNumber.Text = this.currentLotNumber.ToString();

                            if (this.currentLotNumber > this.tray_1Box)
                            {
                                Interlocked.Decrement(ref sumOfLot);
                                this.label_TrayNumber.Text = (this.tray_1Box).ToString();
                                textBox_Scanned.Text = "Scan Box Code !";
                            }
                            return;
                        }
                        else
                        {
                            textBox_Scanned.Text = "Scan Lot Code !";
                            return;
                        }
                    }
                }

                Interlocked.Increment(ref currentSeqQty);
                Interlocked.Increment(ref currentTestCount);

                if (this.function.COUNT_SETUP == false)
                {
                    this.label_TestCount.Text = this.currentSeqQty.ToString();
                }

                testResultInfo.Time = DateTime.Now;
                testResultInfo.Origin_Item = masterCode;
                testResultInfo.Compared_Item = textBox_Scanned.Text;
                testResultInfo.Sample_1Box = this.sample_1Box;
                testResultInfo.Sample_Tray = this.sample_Tray;
                testResultInfo.TrayNumber = this.sumOfLot;
                testResultInfo.TestCount = this.currentTestCount;

                if (textBox_Scanned.Text == masterCode)
                {
                    testResultInfo.Result = true;
                    testResultInfo.Reason = "TEST OK";

                    Interlocked.Increment(ref sumOfPassCount);
                    Interlocked.Increment(ref passCount);

                    commLib.PLC_A_line_tranfer_data("A_PASS");
                }
                else
                {
                    testResultInfo.Result = false;
                    Interlocked.Increment(ref failCount);
                    commLib.PLC_A_line_tranfer_data("A_FAIL");
                }

                this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";

                if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                {
                    if (this.passCount >= this.sample_Tray)
                    {
                        textBox_Scanned.Text = "Scan Lot Code !";
                    }
                }
            }));
        }
        private void Line_B_Test_Callback(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                textBox_Scanned.Text = "";
                textBox_Scanned.Text = sender as string;

                if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                {
                    if (this.currentLotNumber > this.tray_1Box)
                    {
                        if (textBox_Scanned.Text == boxCode)
                        {
                            textBox_Scanned.Text = "Complete Box";
                            Interlocked.Exchange(ref sumOfPassCount, 0);
                            Interlocked.Exchange(ref failCount, 0);
                            Interlocked.Increment(ref sumOfLot);
                            Interlocked.Exchange(ref currentLotNumber, 1);
                            Interlocked.Exchange(ref currentSeqQty, 0);

                            this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";
                            this.label_TrayNumber.Text = this.currentLotNumber.ToString();
                            this.label_TestCount.Text = this.currentSeqQty.ToString();

                            return;
                        }
                        else
                        {
                            textBox_Scanned.Text = "Scan Box Code !";
                            return;
                        }
                    }

                    if (this.passCount >= this.sample_Tray) // lot + 1
                    {
                        // CHECK LOT CODE
                        if (textBox_Scanned.Text == lotCode)
                        {
                            Interlocked.Exchange(ref passCount, 0);
                            Interlocked.Increment(ref currentLotNumber);
                            Interlocked.Increment(ref sumOfLot);
                            textBox_Scanned.Text = "";
                            this.label_TrayNumber.Text = this.currentLotNumber.ToString();

                            if (this.currentLotNumber > this.tray_1Box)
                            {
                                Interlocked.Decrement(ref sumOfLot);
                                this.label_TrayNumber.Text = (this.tray_1Box).ToString();
                                textBox_Scanned.Text = "Scan Box Code !";
                            }
                            return;
                        }
                        else
                        {
                            textBox_Scanned.Text = "Scan Lot Code !";
                            return;
                        }
                    }
                }

                Interlocked.Increment(ref currentSeqQty);
                Interlocked.Increment(ref currentTestCount);

                if (this.function.COUNT_SETUP == false)
                {
                    this.label_TestCount.Text = this.currentSeqQty.ToString();
                }

                testResultInfo.Time = DateTime.Now;
                testResultInfo.Origin_Item = masterCode;
                testResultInfo.Compared_Item = textBox_Scanned.Text;
                testResultInfo.Sample_1Box = this.sample_1Box;
                testResultInfo.Sample_Tray = this.sample_Tray;
                testResultInfo.TrayNumber = this.sumOfLot;
                testResultInfo.TestCount = this.currentTestCount;

                if (textBox_Scanned.Text == masterCode)
                {
                    testResultInfo.Result = true;
                    testResultInfo.Reason = "TEST OK";

                    Interlocked.Increment(ref sumOfPassCount);
                    Interlocked.Increment(ref passCount);

                    commLib.PLC_B_line_tranfer_data("B_PASS");
                }
                else
                {
                    testResultInfo.Result = false;
                    Interlocked.Increment(ref failCount);
                    commLib.PLC_B_line_tranfer_data("B_FAIL");
                }

                this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";

                if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                {
                    if (this.passCount >= this.sample_Tray)
                    {
                        textBox_Scanned.Text = "Scan Lot Code !";
                    }
                }
            }));
        }

#endif

        private void textBox_Scanned_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    textBox_Scanned.Text = scannedCode.ToString();
                    scannedCode.Clear();

                    if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                    {
                        if (this.currentLotNumber > this.tray_1Box)
                        {
                            if (textBox_Scanned.Text == boxCode)
                            {
                                textBox_Scanned.Text = "Complete Box";

                                Interlocked.Exchange(ref sumOfPassCount, 0);
                                Interlocked.Exchange(ref failCount, 0);
                                Interlocked.Increment(ref sumOfLot);
                                Interlocked.Exchange(ref currentLotNumber, 1);
                                Interlocked.Exchange(ref currentSeqQty, 0);

                                this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";
                                this.label_TrayNumber.Text = this.currentLotNumber.ToString();
                                this.label_TestCount.Text = this.currentSeqQty.ToString();
                                return;
                            }
                            else
                            {
                                // Phoung want
                                //errorAlarmForm = new ErrorAlarmForm(testResultInfo, false);
                                //errorAlarmForm.Show(this);
                                textBox_Scanned.Text = "Scan Box Code !";
                                return;
                            }
                        }

                        if (this.passCount >= this.sample_Tray) // lot + 1
                        {
                            // CHECK LOT CODE
                            if (textBox_Scanned.Text == lotCode)
                            {
                                Interlocked.Exchange(ref passCount, 0);
                                Interlocked.Increment(ref currentLotNumber);
                                Interlocked.Increment(ref sumOfLot);

                                textBox_Scanned.Text = "";
                                this.label_TrayNumber.Text = this.currentLotNumber.ToString();

                                if (this.currentLotNumber > this.tray_1Box)
                                {
                                    Interlocked.Decrement(ref sumOfLot);
                                    this.label_TrayNumber.Text = (this.tray_1Box).ToString();
                                    textBox_Scanned.Text = "Scan Box Code !";
                                }
                                return;
                            }
                            else
                            {
                                // Phoung want
                                //errorAlarmForm = new ErrorAlarmForm(testResultInfo, false);
                                //errorAlarmForm.Show(this);
                                textBox_Scanned.Text = "Scan Lot Code !";
                                return;
                            }
                        }
                    }

                    Interlocked.Increment(ref currentSeqQty);
                    Interlocked.Increment(ref currentTestCount);

                    if (this.function.COUNT_SETUP == false)
                    {
                        this.label_TestCount.Text = this.currentSeqQty.ToString();
                    }

#if (USE_USB_HID)

                    testResultInfo.Time = DateTime.Now;
                    testResultInfo.Origin_Item = masterCode;
                    testResultInfo.Compared_Item = textBox_Scanned.Text;
                    testResultInfo.Sample_1Box = this.sample_1Box;
                    testResultInfo.Sample_Tray = this.sample_Tray;
                    testResultInfo.TrayNumber = this.sumOfLot;
                    testResultInfo.TestCount = this.currentTestCount;

                    if (textBox_Scanned.Text == masterCode)
                    {
                        testResultInfo.Result = true;
                        testResultInfo.Reason = "TEST OK";

                        button_PassFail.Text = "OK";
                        sumOfPassCount++;
                        passCount++;

                        using (conn = new SQLiteConnection(connStr))
                        {
                            conn.Open();
                            testResult_CRUD = new BarcodeTestResult_CRUD(conn);
                            testResult_CRUD.Insert(testResultInfo);
                        }
                    }
                    else
                    {
                        // FIXME : delete control failCount
                        testResultInfo.Result = false;
                        errorAlarmForm = new ErrorAlarmForm(testResultInfo, true);
                        errorAlarmForm.Show(this);
                        failCount++;
                        button_PassFail.Text = "NG";
                    }

#endif

                    this.button_PassFail.Text = "PASS (" + (this.sumOfPassCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";

                    if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                    {
                        if (this.passCount >= this.sample_Tray)
                        {
                            textBox_Scanned.Text = "Scan Lot Code !";
                        }
                    }

                }));

                this.textBox_Scanned.KeyUp -= this.textBox_Scanned_KeyUp;
                Stopwatch delay = new Stopwatch();
                delay.Start();

                while (true)
                {
                    if (delay.ElapsedMilliseconds > 300)
                    {
                        delay.Stop();
                        break;
                    }
                }

                this.textBox_Scanned.KeyUp += this.textBox_Scanned_KeyUp;
            }
            else
            {
                scannedCode.Append(KeyToUni.KeyCodeToUnicode(e.KeyCode).ToUpper());
            }
        }

        private void textBox_Scanned_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_Scanned.Text = "";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                masterCode = comboBox_Master.Text;
                boxCode = comboBox_BoxCode.Text;
                lotCode = comboBox_LotCode.Text;

                masterIndex = comboBox_Master.SelectedIndex;
                boxIndex = comboBox_BoxCode.SelectedIndex;
                lotIndex = comboBox_LotCode.SelectedIndex;

                try
                {
                    this.tray_1Box = Int32.Parse(textBox_TRAYperBox.Text);
                    this.sample_Tray = Int32.Parse(textBox_SAMPLEperTray.Text);
                }
                catch
                {
                    if (function.BOX_LOT_CODE == false && function.COUNT_SETUP == false)
                    {
                        MessageBox.Show(this, "Must write down \"Box Qty\" and \"Lot Qty\" Number!", "[Error]", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.sample_1Box = this.tray_1Box * this.sample_Tray;
                textBox_SAMPLEperBOX.Text = this.sample_1Box.ToString();

                Interlocked.Exchange(ref currentLotNumber, 1);
                Interlocked.Exchange(ref sumOfLot, 1);
                Interlocked.Exchange(ref currentSeqQty, 0);
                Interlocked.Exchange(ref currentTestCount, 0);
                Interlocked.Exchange(ref failCount, 0);
                Interlocked.Exchange(ref passCount, 0);
                Interlocked.Exchange(ref sumOfPassCount, 0);

                //currentLotNumber = 1;
                //sumOfLot = 1;
                //currentSeqQty = 0;
                //currentTestCount = 0;
                //failCount = 0;
                //passCount = 0;
                //sumOfPassCount = 0;

                if (function.COUNT_SETUP == false)
                {
                    this.label_TrayNumber.Text = this.sumOfLot.ToString();
                    this.label_TestCount.Text = this.currentSeqQty.ToString();
                }
                else
                {
                    this.label_TrayNumber.Text = "";
                    this.label_TestCount.Text = "";
                }

                this.button_PassFail.Text = "PASS (" + (this.passCount).ToString() + ") / FAIL (" + (this.failCount).ToString() + ")";

                comboBox_Master.DropDownStyle = ComboBoxStyle.Simple;

                if (function.BOX_LOT_CODE == false)
                {
                    comboBox_BoxCode.Enabled = true;
                    comboBox_LotCode.Enabled = true;
                    comboBox_BoxCode.DropDownStyle = ComboBoxStyle.Simple;
                    comboBox_LotCode.DropDownStyle = ComboBoxStyle.Simple;
                }
                else
                {
                    comboBox_BoxCode.Text = "";
                    comboBox_LotCode.Text = "";
                    comboBox_BoxCode.Enabled = false;
                    comboBox_LotCode.Enabled = false;
                }
#if (RS232_COMM)

                if (commLib == null)
                {
                    commLib = new CommPLC(commInfo.connectInfoToA, commInfo.connectInfoToB);

                    commLib.DATA_RECEIVED_A_LINE += Line_A_Test_Callback;
                    commLib.DATA_RECEIVED_B_LINE += Line_B_Test_Callback;

                }
#endif
                button_Start.BackColor = Color.Tomato;
                button_Start.Text = "Stop";

                textBox_Scanned.Text = "";

                FocusTimer.Enabled = true;
                FocusTimer.Start();
            }
            else
            {
                masterCode = "";
                boxCode = "";
                lotCode = "";
                
                masterIndex = 0;
                boxIndex = 0;
                lotIndex = 0;


                Interlocked.Exchange(ref currentLotNumber, 1);
                Interlocked.Exchange(ref sumOfLot, 1);
                Interlocked.Exchange(ref currentSeqQty, 0);
                Interlocked.Exchange(ref currentTestCount, 0);
                Interlocked.Exchange(ref failCount, 0);
                Interlocked.Exchange(ref passCount, 0);
                Interlocked.Exchange(ref sumOfPassCount, 0);

                //currentLotNumber = 1;
                //sumOfLot = 1;
                //currentSeqQty = 0;

                textBox_SAMPLEperBOX.Text = "";
                textBox_TRAYperBox.Text = "";
                textBox_SAMPLEperTray.Text = "";
                this.label_TrayNumber.Text = "0";

                comboBox_Master.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox_BoxCode.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox_LotCode.DropDownStyle = ComboBoxStyle.DropDown;

                button_Start.BackColor = Color.LimeGreen;
                button_Start.Text = "Start";

#if (RS232_COMM)

                if (commLib != null)
                {
                    commLib.DATA_RECEIVED_A_LINE -= Line_A_Test_Callback;
                    commLib.DATA_RECEIVED_B_LINE -= Line_B_Test_Callback;

                    commLib.Dispose();
                    commLib = null;
                }
#endif

                FocusTimer.Enabled = false;
                FocusTimer.Stop();
            }

        }

        private void UserControl_Scanning_VisibleChanged(object sender, EventArgs e)
        {
            InitializeControlAddedEvent();
        }

        private void UserControl_Scanning_Load(object sender, EventArgs e)
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

            FileInfo existCheck = new FileInfo(this.jsonFilePath);

            if (existCheck.Exists == true)
            {
                using (FileStream fs = new FileStream(this.jsonFilePath, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        string jsondeSerializedData = br.ReadString();
                        this.testResultInfo = JsonConvert.DeserializeObject<BarcodeTestResultInfo>(jsondeSerializedData);
                        br.Close();
                    }
                    fs.Close();
                }

                if (this.testResultInfo.Factory_Name == "" || this.testResultInfo.Worker_Name == "" )
                {
                    this.testResultInfo.Factory_Name = "None";
                    this.testResultInfo.Worker_Name = "None";
                    this.testResultInfo.Line_Num = 0;
                }
            }
            else
            {
                this.testResultInfo.Factory_Name = "None";
                this.testResultInfo.Worker_Name = "None";
                this.testResultInfo.Line_Num = 0;
            }

#if (RS232_COMM)

            FileInfo existCommConfigCheck = new FileInfo(this.jsonRs232ConnectionFilePath);

            if (existCommConfigCheck.Exists == true)
            {
                using (FileStream fs = new FileStream(this.jsonRs232ConnectionFilePath, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        string jsondeSerializedData = br.ReadString();
                        commInfo = JsonConvert.DeserializeObject<LineCommInfo>(jsondeSerializedData);
                        br.Close();

                    }
                    fs.Close();
                }
            }
            else
            {
                throw new Exception("Need RS232 Line set-up");
            }
#endif
            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                code_CRUD = new BarcodeReferenceCode_CRUD(conn);
                master_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                box_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                lot_ds = code_CRUD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
            }

            comboBox_Master.DataSource = master_ds.Tables["MasterCodeTable"];
            comboBox_Master.DisplayMember = "MasterCode";

            try
            {
                comboBox_Master.SelectedIndex = masterIndex;
            }
            catch
            {

            }

            comboBox_BoxCode.DataSource = box_ds.Tables["BoxCodeTable"];
            comboBox_BoxCode.DisplayMember = "BoxCode";

            try
            {
                if (function.BOX_LOT_CODE == false)
                {
                    comboBox_BoxCode.Enabled = true;
                    comboBox_BoxCode.SelectedIndex = boxIndex;
                }
                else
                {
                    comboBox_BoxCode.Enabled = false;
                    comboBox_BoxCode.Text = "";
                }

            }
            catch
            {

            }

            comboBox_LotCode.DataSource = lot_ds.Tables["LotCodeTable"];
            comboBox_LotCode.DisplayMember = "LotCode";

            try
            {
                if (function.BOX_LOT_CODE == false)
                {
                    comboBox_LotCode.Enabled = true;
                    comboBox_LotCode.SelectedIndex = lotIndex;
                }
                else
                {
                    comboBox_LotCode.Enabled = false;
                    comboBox_LotCode.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}

