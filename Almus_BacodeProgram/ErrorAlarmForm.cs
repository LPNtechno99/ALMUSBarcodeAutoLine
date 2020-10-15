using BarcodeSqliteLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almus_BacodeProgram
{
    public partial class ErrorAlarmForm : Form
    {
        BarcodeTestResult_CRUD testResult_CRUD;
        BarcodeTestResultInfo errorInfo = null;
        SQLiteConnection conn = null;
        string connStr = null;

        bool isTest = false;
        bool ngFlag = false;

        public ErrorAlarmForm(BarcodeTestResultInfo info, bool isTest)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            InitializeFactor(info);
            this.isTest = isTest;
        }

        private void InitializeFactor(BarcodeTestResultInfo info)
        {
            string currentFolder = Environment.CurrentDirectory;
            string path = Path.Combine(currentFolder, "BarcodeDatabase.sqlite");
            connStr = "Data Source=" + path + ";" + "version=3;";
            errorInfo = info;
            if(isTest == true)
            {
                this.textBox_OriginCode.Text = errorInfo.Origin_Item;
            }
            else
            {
                this.textBox_OriginCode.Text = "Scan Lot/Box Error";
            }
        }

        private void timer_NG_Tick(object sender, EventArgs e)
        {
            if (ngFlag != true)
            {
                this.button_NG_Display.BackColor = Color.Red;
                this.button_NG_Display.ForeColor = Color.Yellow;
                ngFlag = !ngFlag;
            }
            else
            {
                this.button_NG_Display.BackColor = Color.Yellow;
                this.button_NG_Display.ForeColor = Color.Red;
                ngFlag = !ngFlag;
            }
        }

        private void button_ReportNG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox_NG_Reason.Text))
            {
                MessageBox.Show(this, "Must Write down NG reason!", "[Error]", MessageBoxButtons.OK);
                return;
            }
            else if (this.textBox_Password.Text != "admin")
            {
                MessageBox.Show(this, "Do not match Password!", "[Error]", MessageBoxButtons.OK);
                return;
            }

            if(isTest == true)
            {
                errorInfo.Reason = this.textBox_NG_Reason.Text;

                using (conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    testResult_CRUD = new BarcodeTestResult_CRUD(conn);
                    testResult_CRUD.Insert(errorInfo);
                    conn.Close();
                }
            }
            else
            {
                errorInfo.Time = DateTime.Now;
                errorInfo.Reason = this.textBox_NG_Reason.Text;
                errorInfo.Reason += " + (Scan Box/Lot Error)";

                using (conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    testResult_CRUD = new BarcodeTestResult_CRUD(conn);
                    testResult_CRUD.Insert(errorInfo);
                    conn.Close();
                }
            }

            this.Dispose();
        }
    }
}