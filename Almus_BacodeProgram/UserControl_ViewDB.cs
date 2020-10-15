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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Threading;

namespace Almus_BacodeProgram
{
    public partial class UserControl_ViewDB : UserControl, IUserControl
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now;

        BarcodeTestResult_CRUD testResult_CRUD;
        SQLiteConnection conn = null;
        string connStr = null;

        DataSet testResult_ds;

        FunctionSetting function = new FunctionSetting();
        string jsonFunctionSettingFilePath = Path.Combine(Environment.CurrentDirectory, "functionSetting.json");

        public UserControl_ViewDB()
        {
            InitializeComponent();
            //InitializeDatabaseConfig();
            this.saveFileDialog_excel.InitialDirectory = Environment.CurrentDirectory;
            this.saveFileDialog_excel.Title = "Export Database to Excel";
            this.saveFileDialog_excel.Filter = "Excel (*.xlsx)|*.xlsx";
        }

        private void InitializeDatabaseConfig()
        {
            string currentFolder = Environment.CurrentDirectory;
            string path = Path.Combine(currentFolder, "BarcodeDatabase.sqlite");
            connStr = "Data Source=" + path + ";" + "version=3;";

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                testResult_CRUD = new BarcodeTestResult_CRUD(conn);
                testResult_ds = testResult_CRUD.SelectByTodayTime(DateTime.Now);
            }
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 9, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView.DefaultCellStyle.Font = new Font("Corbel", 9);
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = testResult_ds;
            dataGridView.DataMember = "BarcodeTestResultTable";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[0].Width = 120;
            dataGridView.Columns[5].Width = 35; //LineNum
            dataGridView.Columns[6].Width = 45; //Result
            dataGridView.Columns[8].Width = 80; //Sample_1Box
            dataGridView.Columns[9].Width = 80; //Sample_Tray
            dataGridView.Columns[10].Width = 80; //TrayNumber
            dataGridView.Columns[11].Width = 70; //TestCount
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            startTime = dateTimePicker_StartTime.Value;
            endTime = dateTimePicker_EndTime.Value;

            using (conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                testResult_CRUD = new BarcodeTestResult_CRUD(conn);

                if(checkBox_MasterCodeQuery.Checked == true)
                {
                    if (startTime.Date == endTime.Date)
                    {
                        testResult_ds = testResult_CRUD.SelectByTodayTime(startTime, textBox_MasterCode.Text);
                    }
                    else
                    {
                        testResult_ds = testResult_CRUD.SelectByQueryTime(startTime, endTime, textBox_MasterCode.Text);
                    }
                }
                else
                {
                    if (startTime.Date == endTime.Date)
                    {
                        testResult_ds = testResult_CRUD.SelectByTodayTime(startTime);
                    }
                    else
                    {
                        testResult_ds = testResult_CRUD.SelectByQueryTime(startTime, endTime);
                    }
                }
            }

            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = testResult_ds;
            dataGridView.DataMember = "BarcodeTestResultTable";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[0].Width = 120;
            dataGridView.Columns[5].Width = 35; //LineNum
            dataGridView.Columns[6].Width = 45; //Result
            dataGridView.Columns[8].Width = 80; //Sample_1Box
            dataGridView.Columns[9].Width = 80; //Sample_Tray
            dataGridView.Columns[10].Width = 80; //TrayNumber
            dataGridView.Columns[11].Width = 70; //TestCount
        }

        private void UserControl_ViewDB_Load(object sender, EventArgs e)
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

            if (this.function.DATABASE == false)
            {
                dateTimePicker_StartTime.Enabled = true;
                dateTimePicker_EndTime.Enabled = true;
                button_Search.Enabled = true;

                InitializeDatabaseConfig();
            }
            else
            {
                dateTimePicker_StartTime.Enabled = false;
                dateTimePicker_EndTime.Enabled = false;
                button_Search.Enabled = false;
            }
        }

        private void UserControl_ViewDB_VisibleChanged(object sender, EventArgs e)
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

            if(this.function.DATABASE == false)
            {
                dateTimePicker_StartTime.Enabled = true;
                dateTimePicker_EndTime.Enabled = true;
                button_Search.Enabled = true;

                InitializeDatabaseConfig();
            }
            else
            {
                dateTimePicker_StartTime.Enabled = false;
                dateTimePicker_EndTime.Enabled = false;
                button_Search.Enabled = false;
            }
        }

        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            this.progressBar_excel.Value = 0;

            if (this.saveFileDialog_excel.ShowDialog() == DialogResult.OK)  
            {
                string fileName = this.saveFileDialog_excel.FileName.ToString();

                if (!string.IsNullOrEmpty(fileName))
                {
                    Task.Factory.StartNew(new Action(delegate ()
                    {
                        Excel.Application ap = new Excel.Application();
                        Excel.Workbook excelWorkBook = ap.Workbooks.Add();
                        Excel.Worksheet ws = excelWorkBook.Sheets.Add();

                        this.Invoke(new Action(delegate ()
                        {
                            this.progressBar_excel.Value = 10;
                        }));

                        DataTable dt = testResult_ds.Tables["BarcodeTestResultTable"];
                        ws.Name = dt.TableName;
                        int columHeaderIndex = 0;

                        for (columHeaderIndex = 1; columHeaderIndex <= dt.Columns.Count; columHeaderIndex++)
                        {
                            ws.Cells[1, columHeaderIndex] = dt.Columns[columHeaderIndex - 1].ColumnName;
                        }

                        this.Invoke(new Action(delegate ()
                        {
                            this.progressBar_excel.Value = 20;
                        }));

                        for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                        {
                            for (int columIndex = 0; columIndex < dt.Columns.Count; columIndex++)
                            {
                                ws.Cells[rowIndex + 2, columIndex + 1] = dt.Rows[rowIndex].ItemArray[columIndex].ToString();
                            }

                            this.Invoke(new Action(delegate ()
                            {
                                this.progressBar_excel.Value = 20 + ((60/ dt.Rows.Count) * dt.Rows.Count);
                            }));
                        }

                        ws.Columns.AutoFit();

                        excelWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlOpenXMLWorkbook);

                        this.Invoke(new Action(delegate ()
                        {
                            this.progressBar_excel.Value = 100;
                        }));

                        Thread.Sleep(1000);

                        this.Invoke(new Action(delegate ()
                        {
                            this.progressBar_excel.Value = 0;
                        }));

                        try
                        {
                            excelWorkBook.Close();
                            ap.Quit();
                        }
                        finally
                        {
                            ReleaseExcelObject(ws);
                            ReleaseExcelObject(excelWorkBook);
                            ReleaseExcelObject(ap);
                        }
                    }));
                }
            }
        }

        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
