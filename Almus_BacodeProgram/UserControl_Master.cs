using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarcodeSqliteLib;
using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json;

namespace Almus_BacodeProgram
{
    public partial class UserControl_Master : UserControl, IUserControl
    {
        DataSet ds;

        BarcodeReferenceCode_CRUD codeCURD;
        SQLiteConnection conn = null;
        string connStr = null;

        StringBuilder scannedCode = new StringBuilder();

        FunctionSetting function = new FunctionSetting();
        string jsonFunctionSettingFilePath = Path.Combine(Environment.CurrentDirectory, "functionSetting.json");

        public UserControl_Master()
        {
            InitializeComponent();
            InitializeDatabaseConfig();
            DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
        }

        private void InitializeDatabaseConfig()
        {
            string currentFolder = Environment.CurrentDirectory;
            string path = Path.Combine(currentFolder, "BarcodeDatabase.sqlite");
            connStr = "Data Source=" + path + ";" + "version=3;";

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                codeCURD = new BarcodeReferenceCode_CRUD(conn);
                ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                conn.Close();
            }
        }

        private void DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table table)
        {
            dataGridView.ReadOnly = true;
            switch (table)
            {
                case BarcodeReferenceCode_CRUD.Table.MASTER_CODE:
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
                    dataGridView.RowHeadersVisible = false;
                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "MasterCodeTable";
                    //dataGridView.RowHeadersWidth = 20;
                    dataGridView.Columns[0].Width = 40;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case BarcodeReferenceCode_CRUD.Table.BOX_CODE:
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.GreenYellow;
                    dataGridView.RowHeadersVisible = false;
                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "BoxCodeTable";
                    //dataGridView.RowHeadersWidth = 20;
                    dataGridView.Columns[0].Width = 40;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case BarcodeReferenceCode_CRUD.Table.LOT_CODE:
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
                    dataGridView.RowHeadersVisible = false;
                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = ds;
                    dataGridView.DataMember = "LotCodeTable";
                    //dataGridView.RowHeadersWidth = 20;
                    dataGridView.Columns[0].Width = 40;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
            }
            //dataGridView.RowHeadersVisible = false;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: //master
                    using (conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();
                        codeCURD = new BarcodeReferenceCode_CRUD(conn);
                        ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                        conn.Close();
                    }
                    DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                    break;

                case 1: //box
                    using (conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();
                        codeCURD = new BarcodeReferenceCode_CRUD(conn);
                        ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                        conn.Close();
                    }
                    DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                    break;
                    
                case 2: //lot
                    using (conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();
                        codeCURD = new BarcodeReferenceCode_CRUD(conn);
                        ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
                        conn.Close();
                    }
                    DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
                    break;

                default:
                    break;
            }
        }

        private void button_MasterReigster_Click(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_MasterCode;
            MessageBox.Show(this, "Capture Master Code", "[Operation]", MessageBoxButtons.OK);
        }

        private void button_MasterDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentCell.RowIndex;
            var id = dataGridView[0, index];
            var code = dataGridView[1, index];
            
            BarcodeMasterCodeInfo item = new BarcodeMasterCodeInfo();

            item.ID = (int)id.Value;
            item.MasterCode = (string)code.Value;

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                codeCURD = new BarcodeReferenceCode_CRUD(conn);
                codeCURD.Delete(item);
                ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                conn.Close();
            }

            DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
        }

        private void button_BoxRegister_Click(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_BoxCode;
            MessageBox.Show(this, "Capture Box Code", "[Operation]", MessageBoxButtons.OK);
        }

        private void button_BoxDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentCell.RowIndex;
            var id = dataGridView[0, index];
            var code = dataGridView[1, index];

            BarcodeBoxCodeInfo item = new BarcodeBoxCodeInfo();

            item.ID = (int)id.Value;
            item.BoxCode = (string)code.Value;

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                codeCURD = new BarcodeReferenceCode_CRUD(conn);
                codeCURD.Delete(item);
                ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                conn.Close();
            }

            DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
        }

        private void button_LotRegister_Click(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_LotCode;
            MessageBox.Show(this, "Capture Lot Code", "[Operation]", MessageBoxButtons.OK);
        }

        private void button_LotDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentCell.RowIndex;
            var id = dataGridView[0, index];
            var code = dataGridView[1, index];

            BarcodeLotCodeInfo item = new BarcodeLotCodeInfo();

            item.ID = (int)id.Value;
            item.LotCode = (string)code.Value;

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                codeCURD = new BarcodeReferenceCode_CRUD(conn);
                codeCURD.Delete(item);
                ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
                conn.Close();
            }

            DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
        }

        private void textBox_MasterCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_MasterCode.Text = "";
                textBox_MasterCode.Text = scannedCode.ToString();
                scannedCode.Clear();
               
                using (conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    codeCURD = new BarcodeReferenceCode_CRUD(conn);

                    BarcodeMasterCodeInfo item = new BarcodeMasterCodeInfo();
                    var id = codeCURD.GetMaxID(BarcodeReferenceCode_CRUD.Table.MASTER_CODE) + 1;
                    item.ID = id;
                    item.MasterCode = textBox_MasterCode.Text;

                    codeCURD.Insert(item);

                    ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
                    conn.Close();
                }

                DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.MASTER_CODE);
            }
            else
            {
                textBox_MasterCode.Text = "";
                scannedCode.Append(KeyToUni.KeyCodeToUnicode(e.KeyCode).ToUpper());
            }
        }

        private void textBox_BoxCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_BoxCode.Text = "";
                textBox_BoxCode.Text = scannedCode.ToString();
                scannedCode.Clear();

                using (conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    codeCURD = new BarcodeReferenceCode_CRUD(conn);

                    BarcodeBoxCodeInfo item = new BarcodeBoxCodeInfo();
                    var id = codeCURD.GetMaxID(BarcodeReferenceCode_CRUD.Table.BOX_CODE) + 1;
                    item.ID = id;
                    item.BoxCode = textBox_BoxCode.Text;

                    codeCURD.Insert(item);

                    ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
                    conn.Close();
                }

                DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.BOX_CODE);
            }
            else
            {
                textBox_BoxCode.Text = "";
                scannedCode.Append(KeyToUni.KeyCodeToUnicode(e.KeyCode).ToUpper());
            }
        }

        private void textBox_LotCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_LotCode.Text = "";
                textBox_LotCode.Text = scannedCode.ToString();
                scannedCode.Clear();

                using (conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    codeCURD = new BarcodeReferenceCode_CRUD(conn);

                    BarcodeLotCodeInfo item = new BarcodeLotCodeInfo();
                    var id = codeCURD.GetMaxID(BarcodeReferenceCode_CRUD.Table.LOT_CODE) + 1;
                    item.ID = id;
                    item.LotCode = textBox_LotCode.Text;

                    codeCURD.Insert(item);

                    ds = codeCURD.SelectAll_Dataset(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
                    conn.Close();
                }

                DataGridViewRefreshBinding(BarcodeReferenceCode_CRUD.Table.LOT_CODE);
            }
            else
            {
                textBox_LotCode.Text = "";
                scannedCode.Append(KeyToUni.KeyCodeToUnicode(e.KeyCode).ToUpper());
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            DataGridViewCell codeItem = null;

            switch (tabControl.SelectedIndex)
            {
                case 0: //master
                    try
                    {
                        index = dataGridView.CurrentCell.RowIndex;
                        codeItem = dataGridView[1, index];
                        textBox_MasterCodeView.Text = (string)codeItem.Value;
                    }
                    catch
                    {
                        textBox_MasterCodeView.Text = "";
                        break;
                    }

                    break;

                case 1: //box
                    try
                    {
                        index = dataGridView.CurrentCell.RowIndex;
                        codeItem = dataGridView[1, index];
                        textBox_BoxCodeView.Text = (string)codeItem.Value;
                    }
                    catch
                    {
                        textBox_BoxCodeView.Text = "";
                        break;
                    }

                    break;

                case 2: //lot
                    try
                    {
                        index = dataGridView.CurrentCell.RowIndex;
                        codeItem = dataGridView[1, index];
                        textBox_LotCodeView.Text = (string)codeItem.Value;
                    }
                    catch
                    {
                        textBox_LotCodeView.Text = "";
                        break;
                    }

                    break;

                default:
                    break;
            }
        }

        private void UserControl_Master_Load(object sender, EventArgs e)
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
        }

        private void UserControl_Master_VisibleChanged(object sender, EventArgs e)
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
        }
    }
}
