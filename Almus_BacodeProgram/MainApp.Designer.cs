namespace Almus_BacodeProgram
{
    partial class MainApp
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Scan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("View DB");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Manage Master");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Operation", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Setting Function");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Setting Configs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Admin Mode");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Option", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TreeView_Menu = new System.Windows.Forms.TreeView();
            this.Panel_ControlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TreeView_Menu);
            this.panel2.Location = new System.Drawing.Point(13, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 725);
            this.panel2.TabIndex = 1;
            // 
            // TreeView_Menu
            // 
            this.TreeView_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeView_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView_Menu.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView_Menu.Location = new System.Drawing.Point(0, 0);
            this.TreeView_Menu.Name = "TreeView_Menu";
            treeNode1.Name = "nodeScanning";
            treeNode1.Text = "Scan";
            treeNode2.Name = "nodeViewDb";
            treeNode2.Text = "View DB";
            treeNode3.Name = "nodeManageMaster";
            treeNode3.Text = "Manage Master";
            treeNode4.Name = "노드0";
            treeNode4.Text = "Operation";
            treeNode5.Name = "nodeSettingFunction";
            treeNode5.Text = "Setting Function";
            treeNode6.Name = "nodeSettingConfigs";
            treeNode6.Text = "Setting Configs";
            treeNode7.Name = "nodeAdminMode";
            treeNode7.Text = "Admin Mode";
            treeNode8.Name = "노드2";
            treeNode8.Text = "Option";
            this.TreeView_Menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.TreeView_Menu.Size = new System.Drawing.Size(160, 725);
            this.TreeView_Menu.TabIndex = 0;
            this.TreeView_Menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Menu_AfterSelect);
            // 
            // Panel_ControlRight
            // 
            this.Panel_ControlRight.Location = new System.Drawing.Point(183, 41);
            this.Panel_ControlRight.Name = "Panel_ControlRight";
            this.Panel_ControlRight.Size = new System.Drawing.Size(1050, 738);
            this.Panel_ControlRight.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Almus_BacodeProgram.Properties.Resources.POSI_COLOR_LOGO_400;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 36);
            this.panel1.TabIndex = 0;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 782);
            this.Controls.Add(this.Panel_ControlRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.Text = "ALMUS BARCODE SCANNER PROGRAM V 2.0.0 ( Contact : redmk1025@almusglobal.com )";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_ControlRight;
        private System.Windows.Forms.TreeView TreeView_Menu;
    }
}

