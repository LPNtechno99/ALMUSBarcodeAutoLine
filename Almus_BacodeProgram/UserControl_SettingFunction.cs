using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Almus_BacodeProgram
{
    public partial class UserControl_SettingFunction : UserControl, IUserControl
    {
        FunctionSetting function = new FunctionSetting();
        string jsonFunctionSettingFilePath = Path.Combine(Environment.CurrentDirectory, "functionSetting.json");

        public UserControl_SettingFunction()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.function.BOX_LOT_CODE = this.checkBox_BoxCode_LotCode.Checked;
            this.function.INSPECTION_INFO = this.checkBox_Inspection_Info.Checked;
            this.function.COUNT_SETUP = this.checkBox_CountSetting.Checked;
            this.function.DATABASE = this.checkBox_DatabaseQuery.Checked;

            string jsonSerializedData = JsonConvert.SerializeObject(function, Formatting.Indented);

            using (FileStream fs = new FileStream(this.jsonFunctionSettingFilePath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(jsonSerializedData);
                    bw.Flush();
                    bw.Close();
                }
                fs.Close();
            }
            MessageBox.Show(this, "Complete Save Data", "[Option]", MessageBoxButtons.OK);
        }

        private void UserControl_SettingFunction_Load(object sender, EventArgs e)
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

                this.checkBox_BoxCode_LotCode.Checked = this.function.BOX_LOT_CODE;
                this.checkBox_Inspection_Info.Checked = this.function.INSPECTION_INFO;
                this.checkBox_CountSetting.Checked = this.function.COUNT_SETUP;
                this.checkBox_DatabaseQuery.Checked = this.function.DATABASE;
            }
        }
    }
}