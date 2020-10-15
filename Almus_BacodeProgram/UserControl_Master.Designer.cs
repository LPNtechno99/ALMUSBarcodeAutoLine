namespace Almus_BacodeProgram
{
    partial class UserControl_Master
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_MasterCode = new System.Windows.Forms.TabPage();
            this.button_MasterDelete = new System.Windows.Forms.Button();
            this.button_MasterReigster = new System.Windows.Forms.Button();
            this.textBox_MasterCode = new System.Windows.Forms.TextBox();
            this.textBox_MasterCodeView = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_BoxCode = new System.Windows.Forms.TabPage();
            this.button_BoxDelete = new System.Windows.Forms.Button();
            this.button_BoxRegister = new System.Windows.Forms.Button();
            this.textBox_BoxCode = new System.Windows.Forms.TextBox();
            this.textBox_BoxCodeView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_LotCode = new System.Windows.Forms.TabPage();
            this.button_LotDelete = new System.Windows.Forms.Button();
            this.button_LotRegister = new System.Windows.Forms.Button();
            this.textBox_LotCode = new System.Windows.Forms.TextBox();
            this.textBox_LotCodeView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_MasterCode.SuspendLayout();
            this.tabPage_BoxCode.SuspendLayout();
            this.tabPage_LotCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(185, 722);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_MasterCode);
            this.tabControl.Controls.Add(this.tabPage_BoxCode);
            this.tabControl.Controls.Add(this.tabPage_LotCode);
            this.tabControl.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(194, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(856, 726);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_MasterCode
            // 
            this.tabPage_MasterCode.Controls.Add(this.button_MasterDelete);
            this.tabPage_MasterCode.Controls.Add(this.button_MasterReigster);
            this.tabPage_MasterCode.Controls.Add(this.textBox_MasterCode);
            this.tabPage_MasterCode.Controls.Add(this.textBox_MasterCodeView);
            this.tabPage_MasterCode.Controls.Add(this.label2);
            this.tabPage_MasterCode.Controls.Add(this.label1);
            this.tabPage_MasterCode.Location = new System.Drawing.Point(4, 42);
            this.tabPage_MasterCode.Name = "tabPage_MasterCode";
            this.tabPage_MasterCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MasterCode.Size = new System.Drawing.Size(848, 680);
            this.tabPage_MasterCode.TabIndex = 0;
            this.tabPage_MasterCode.Text = "Master Code";
            this.tabPage_MasterCode.UseVisualStyleBackColor = true;
            // 
            // button_MasterDelete
            // 
            this.button_MasterDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_MasterDelete.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MasterDelete.Location = new System.Drawing.Point(642, 593);
            this.button_MasterDelete.Name = "button_MasterDelete";
            this.button_MasterDelete.Size = new System.Drawing.Size(200, 75);
            this.button_MasterDelete.TabIndex = 11;
            this.button_MasterDelete.Text = "Delete";
            this.button_MasterDelete.UseVisualStyleBackColor = false;
            this.button_MasterDelete.Click += new System.EventHandler(this.button_MasterDelete_Click);
            // 
            // button_MasterReigster
            // 
            this.button_MasterReigster.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_MasterReigster.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MasterReigster.Location = new System.Drawing.Point(436, 593);
            this.button_MasterReigster.Name = "button_MasterReigster";
            this.button_MasterReigster.Size = new System.Drawing.Size(200, 75);
            this.button_MasterReigster.TabIndex = 10;
            this.button_MasterReigster.Text = "Register";
            this.button_MasterReigster.UseVisualStyleBackColor = false;
            this.button_MasterReigster.Click += new System.EventHandler(this.button_MasterReigster_Click);
            // 
            // textBox_MasterCode
            // 
            this.textBox_MasterCode.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MasterCode.Location = new System.Drawing.Point(6, 345);
            this.textBox_MasterCode.Name = "textBox_MasterCode";
            this.textBox_MasterCode.Size = new System.Drawing.Size(836, 86);
            this.textBox_MasterCode.TabIndex = 9;
            this.textBox_MasterCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_MasterCode_KeyUp);
            // 
            // textBox_MasterCodeView
            // 
            this.textBox_MasterCodeView.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_MasterCodeView.Enabled = false;
            this.textBox_MasterCodeView.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MasterCodeView.ForeColor = System.Drawing.Color.Black;
            this.textBox_MasterCodeView.Location = new System.Drawing.Point(3, 98);
            this.textBox_MasterCodeView.Name = "textBox_MasterCodeView";
            this.textBox_MasterCodeView.ReadOnly = true;
            this.textBox_MasterCodeView.Size = new System.Drawing.Size(839, 86);
            this.textBox_MasterCodeView.TabIndex = 8;
            this.textBox_MasterCodeView.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Register :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "View :";
            // 
            // tabPage_BoxCode
            // 
            this.tabPage_BoxCode.Controls.Add(this.button_BoxDelete);
            this.tabPage_BoxCode.Controls.Add(this.button_BoxRegister);
            this.tabPage_BoxCode.Controls.Add(this.textBox_BoxCode);
            this.tabPage_BoxCode.Controls.Add(this.textBox_BoxCodeView);
            this.tabPage_BoxCode.Controls.Add(this.label3);
            this.tabPage_BoxCode.Controls.Add(this.label4);
            this.tabPage_BoxCode.Location = new System.Drawing.Point(4, 42);
            this.tabPage_BoxCode.Name = "tabPage_BoxCode";
            this.tabPage_BoxCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BoxCode.Size = new System.Drawing.Size(848, 680);
            this.tabPage_BoxCode.TabIndex = 1;
            this.tabPage_BoxCode.Text = "Box Code";
            this.tabPage_BoxCode.UseVisualStyleBackColor = true;
            // 
            // button_BoxDelete
            // 
            this.button_BoxDelete.BackColor = System.Drawing.Color.Honeydew;
            this.button_BoxDelete.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BoxDelete.Location = new System.Drawing.Point(642, 593);
            this.button_BoxDelete.Name = "button_BoxDelete";
            this.button_BoxDelete.Size = new System.Drawing.Size(200, 75);
            this.button_BoxDelete.TabIndex = 11;
            this.button_BoxDelete.Text = "Delete";
            this.button_BoxDelete.UseVisualStyleBackColor = false;
            this.button_BoxDelete.Click += new System.EventHandler(this.button_BoxDelete_Click);
            // 
            // button_BoxRegister
            // 
            this.button_BoxRegister.BackColor = System.Drawing.Color.Honeydew;
            this.button_BoxRegister.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BoxRegister.Location = new System.Drawing.Point(436, 593);
            this.button_BoxRegister.Name = "button_BoxRegister";
            this.button_BoxRegister.Size = new System.Drawing.Size(200, 75);
            this.button_BoxRegister.TabIndex = 10;
            this.button_BoxRegister.Text = "Register";
            this.button_BoxRegister.UseVisualStyleBackColor = false;
            this.button_BoxRegister.Click += new System.EventHandler(this.button_BoxRegister_Click);
            // 
            // textBox_BoxCode
            // 
            this.textBox_BoxCode.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BoxCode.Location = new System.Drawing.Point(6, 345);
            this.textBox_BoxCode.Name = "textBox_BoxCode";
            this.textBox_BoxCode.Size = new System.Drawing.Size(836, 86);
            this.textBox_BoxCode.TabIndex = 9;
            this.textBox_BoxCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_BoxCode_KeyUp);
            // 
            // textBox_BoxCodeView
            // 
            this.textBox_BoxCodeView.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_BoxCodeView.Enabled = false;
            this.textBox_BoxCodeView.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BoxCodeView.ForeColor = System.Drawing.Color.Black;
            this.textBox_BoxCodeView.Location = new System.Drawing.Point(3, 98);
            this.textBox_BoxCodeView.Name = "textBox_BoxCodeView";
            this.textBox_BoxCodeView.ReadOnly = true;
            this.textBox_BoxCodeView.Size = new System.Drawing.Size(839, 86);
            this.textBox_BoxCodeView.TabIndex = 8;
            this.textBox_BoxCodeView.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Register :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "View :";
            // 
            // tabPage_LotCode
            // 
            this.tabPage_LotCode.Controls.Add(this.button_LotDelete);
            this.tabPage_LotCode.Controls.Add(this.button_LotRegister);
            this.tabPage_LotCode.Controls.Add(this.textBox_LotCode);
            this.tabPage_LotCode.Controls.Add(this.textBox_LotCodeView);
            this.tabPage_LotCode.Controls.Add(this.label5);
            this.tabPage_LotCode.Controls.Add(this.label6);
            this.tabPage_LotCode.Location = new System.Drawing.Point(4, 42);
            this.tabPage_LotCode.Name = "tabPage_LotCode";
            this.tabPage_LotCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LotCode.Size = new System.Drawing.Size(848, 680);
            this.tabPage_LotCode.TabIndex = 2;
            this.tabPage_LotCode.Text = "Lot Code";
            this.tabPage_LotCode.UseVisualStyleBackColor = true;
            // 
            // button_LotDelete
            // 
            this.button_LotDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.button_LotDelete.Location = new System.Drawing.Point(642, 593);
            this.button_LotDelete.Name = "button_LotDelete";
            this.button_LotDelete.Size = new System.Drawing.Size(200, 75);
            this.button_LotDelete.TabIndex = 11;
            this.button_LotDelete.Text = "Delete";
            this.button_LotDelete.UseVisualStyleBackColor = false;
            this.button_LotDelete.Click += new System.EventHandler(this.button_LotDelete_Click);
            // 
            // button_LotRegister
            // 
            this.button_LotRegister.BackColor = System.Drawing.Color.AliceBlue;
            this.button_LotRegister.Location = new System.Drawing.Point(436, 593);
            this.button_LotRegister.Name = "button_LotRegister";
            this.button_LotRegister.Size = new System.Drawing.Size(200, 75);
            this.button_LotRegister.TabIndex = 10;
            this.button_LotRegister.Text = "Register";
            this.button_LotRegister.UseVisualStyleBackColor = false;
            this.button_LotRegister.Click += new System.EventHandler(this.button_LotRegister_Click);
            // 
            // textBox_LotCode
            // 
            this.textBox_LotCode.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LotCode.Location = new System.Drawing.Point(6, 345);
            this.textBox_LotCode.Name = "textBox_LotCode";
            this.textBox_LotCode.Size = new System.Drawing.Size(836, 86);
            this.textBox_LotCode.TabIndex = 9;
            this.textBox_LotCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_LotCode_KeyUp);
            // 
            // textBox_LotCodeView
            // 
            this.textBox_LotCodeView.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox_LotCodeView.Enabled = false;
            this.textBox_LotCodeView.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LotCodeView.ForeColor = System.Drawing.Color.Black;
            this.textBox_LotCodeView.Location = new System.Drawing.Point(3, 98);
            this.textBox_LotCodeView.Name = "textBox_LotCodeView";
            this.textBox_LotCodeView.ReadOnly = true;
            this.textBox_LotCodeView.Size = new System.Drawing.Size(839, 86);
            this.textBox_LotCodeView.TabIndex = 8;
            this.textBox_LotCodeView.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Register :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 45);
            this.label6.TabIndex = 6;
            this.label6.Text = "View :";
            // 
            // UserControl_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_Master";
            this.Size = new System.Drawing.Size(1050, 738);
            this.Load += new System.EventHandler(this.UserControl_Master_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Master_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_MasterCode.ResumeLayout(false);
            this.tabPage_MasterCode.PerformLayout();
            this.tabPage_BoxCode.ResumeLayout(false);
            this.tabPage_BoxCode.PerformLayout();
            this.tabPage_LotCode.ResumeLayout(false);
            this.tabPage_LotCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_MasterCode;
        private System.Windows.Forms.TabPage tabPage_BoxCode;
        private System.Windows.Forms.TabPage tabPage_LotCode;
        private System.Windows.Forms.Button button_BoxDelete;
        private System.Windows.Forms.Button button_BoxRegister;
        private System.Windows.Forms.TextBox textBox_BoxCode;
        private System.Windows.Forms.TextBox textBox_BoxCodeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_LotDelete;
        private System.Windows.Forms.Button button_LotRegister;
        private System.Windows.Forms.TextBox textBox_LotCode;
        private System.Windows.Forms.TextBox textBox_LotCodeView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_MasterDelete;
        private System.Windows.Forms.Button button_MasterReigster;
        private System.Windows.Forms.TextBox textBox_MasterCode;
        private System.Windows.Forms.TextBox textBox_MasterCodeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
