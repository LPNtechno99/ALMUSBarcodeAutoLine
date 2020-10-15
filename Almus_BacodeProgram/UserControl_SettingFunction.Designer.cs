namespace Almus_BacodeProgram
{
    partial class UserControl_SettingFunction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_BoxCode_LotCode = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Inspection_Info = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_CountSetting = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_DatabaseQuery = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_BoxCode_LotCode);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Code Function";
            // 
            // checkBox_BoxCode_LotCode
            // 
            this.checkBox_BoxCode_LotCode.AutoSize = true;
            this.checkBox_BoxCode_LotCode.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BoxCode_LotCode.Location = new System.Drawing.Point(67, 61);
            this.checkBox_BoxCode_LotCode.Name = "checkBox_BoxCode_LotCode";
            this.checkBox_BoxCode_LotCode.Size = new System.Drawing.Size(502, 37);
            this.checkBox_BoxCode_LotCode.TabIndex = 0;
            this.checkBox_BoxCode_LotCode.Text = "Except BoxCode and  Lot Code Function";
            this.checkBox_BoxCode_LotCode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Inspection_Info);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inspection Infomation Function";
            // 
            // checkBox_Inspection_Info
            // 
            this.checkBox_Inspection_Info.AutoSize = true;
            this.checkBox_Inspection_Info.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Inspection_Info.Location = new System.Drawing.Point(67, 61);
            this.checkBox_Inspection_Info.Name = "checkBox_Inspection_Info";
            this.checkBox_Inspection_Info.Size = new System.Drawing.Size(504, 37);
            this.checkBox_Inspection_Info.TabIndex = 1;
            this.checkBox_Inspection_Info.Text = "Except Register Inspection Info Function";
            this.checkBox_Inspection_Info.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_CountSetting);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1044, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Count Setting Function";
            // 
            // checkBox_CountSetting
            // 
            this.checkBox_CountSetting.AutoSize = true;
            this.checkBox_CountSetting.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CountSetting.Location = new System.Drawing.Point(67, 62);
            this.checkBox_CountSetting.Name = "checkBox_CountSetting";
            this.checkBox_CountSetting.Size = new System.Drawing.Size(391, 37);
            this.checkBox_CountSetting.TabIndex = 2;
            this.checkBox_CountSetting.Text = "Except Count Setting Function";
            this.checkBox_CountSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_DatabaseQuery);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 497);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1044, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Function";
            // 
            // checkBox_DatabaseQuery
            // 
            this.checkBox_DatabaseQuery.AutoSize = true;
            this.checkBox_DatabaseQuery.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DatabaseQuery.Location = new System.Drawing.Point(67, 59);
            this.checkBox_DatabaseQuery.Name = "checkBox_DatabaseQuery";
            this.checkBox_DatabaseQuery.Size = new System.Drawing.Size(444, 40);
            this.checkBox_DatabaseQuery.TabIndex = 3;
            this.checkBox_DatabaseQuery.Text = "Except Database Query Function";
            this.checkBox_DatabaseQuery.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.White;
            this.button_Save.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(834, 653);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(213, 82);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // UserControl_SettingFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_SettingFunction";
            this.Size = new System.Drawing.Size(1050, 738);
            this.Load += new System.EventHandler(this.UserControl_SettingFunction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_BoxCode_LotCode;
        private System.Windows.Forms.CheckBox checkBox_Inspection_Info;
        private System.Windows.Forms.CheckBox checkBox_CountSetting;
        private System.Windows.Forms.CheckBox checkBox_DatabaseQuery;
    }
}
