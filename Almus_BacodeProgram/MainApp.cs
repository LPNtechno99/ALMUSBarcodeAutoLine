using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Almus_BacodeProgram
{
    public partial class MainApp : Form
    {
        
        IUserControl userControlAdmin;
        IUserControl userControlMaster;
        IUserControl userControlScanning;
        IUserControl userControlConfig;
        IUserControl userControlFunction;
        IUserControl userControlViewDB;

        public MainApp()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.TreeView_Menu.ExpandAll();

            this.userControlAdmin = new UserControl_Admin();
            this.userControlMaster = new UserControl_Master();
            this.userControlScanning = new UserControl_Scanning();
            this.userControlConfig = new UserControl_SettingConfig();
            this.userControlFunction = new UserControl_SettingFunction();
            this.userControlViewDB = new UserControl_ViewDB();

            this.Panel_ControlRight.Controls.Clear();
            this.Panel_ControlRight.Controls.Add(userControlConfig as UserControl);
        }

        private void TreeView_Menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            
            switch (nodeKey)
            {
                case "nodeAdminMode":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlAdmin as UserControl);
                        break;
                    }
                case "nodeManageMaster":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlMaster as UserControl);
                        break;
                    }
                case "nodeScanning":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlScanning as UserControl);
                        break;
                    }
                case "nodeSettingConfigs":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlConfig as UserControl);
                        break;
                    }
                case "nodeSettingFunction":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlFunction as UserControl);
                        break;
                    }
                case "nodeViewDb":
                    {
                        this.Panel_ControlRight.Controls.Clear();
                        this.Panel_ControlRight.Controls.Add(userControlViewDB as UserControl);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}