namespace Almus_BacodeProgram
{
    partial class UserControl_SettingConfig
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
            this.textBox_WorkerName = new System.Windows.Forms.TextBox();
            this.textBox_LineNum = new System.Windows.Forms.TextBox();
            this.textBox_FactoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_B_Line = new System.Windows.Forms.ComboBox();
            this.comboBox_A_Line = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBox_WorkerName);
            this.groupBox1.Controls.Add(this.textBox_LineNum);
            this.groupBox1.Controls.Add(this.textBox_FactoryName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting Inspection Infomation";
            // 
            // textBox_WorkerName
            // 
            this.textBox_WorkerName.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WorkerName.Location = new System.Drawing.Point(358, 246);
            this.textBox_WorkerName.Name = "textBox_WorkerName";
            this.textBox_WorkerName.Size = new System.Drawing.Size(667, 53);
            this.textBox_WorkerName.TabIndex = 5;
            // 
            // textBox_LineNum
            // 
            this.textBox_LineNum.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LineNum.Location = new System.Drawing.Point(358, 147);
            this.textBox_LineNum.Name = "textBox_LineNum";
            this.textBox_LineNum.Size = new System.Drawing.Size(667, 53);
            this.textBox_LineNum.TabIndex = 4;
            // 
            // textBox_FactoryName
            // 
            this.textBox_FactoryName.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FactoryName.Location = new System.Drawing.Point(358, 51);
            this.textBox_FactoryName.Name = "textBox_FactoryName";
            this.textBox_FactoryName.Size = new System.Drawing.Size(667, 53);
            this.textBox_FactoryName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Worker Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Line Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factory Name :";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.White;
            this.button_Save.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(834, 648);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(213, 82);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.comboBox_B_Line);
            this.groupBox2.Controls.Add(this.comboBox_A_Line);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting Inspection Infomation";
            // 
            // comboBox_B_Line
            // 
            this.comboBox_B_Line.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_B_Line.FormattingEnabled = true;
            this.comboBox_B_Line.Location = new System.Drawing.Point(358, 177);
            this.comboBox_B_Line.Name = "comboBox_B_Line";
            this.comboBox_B_Line.Size = new System.Drawing.Size(667, 53);
            this.comboBox_B_Line.TabIndex = 9;
            // 
            // comboBox_A_Line
            // 
            this.comboBox_A_Line.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_A_Line.FormattingEnabled = true;
            this.comboBox_A_Line.Location = new System.Drawing.Point(358, 66);
            this.comboBox_A_Line.Name = "comboBox_A_Line";
            this.comboBox_A_Line.Size = new System.Drawing.Size(667, 53);
            this.comboBox_A_Line.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "B Line Comm Port :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "A Line Comm Port :";
            // 
            // UserControl_SettingConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_SettingConfig";
            this.Size = new System.Drawing.Size(1050, 738);
            this.Load += new System.EventHandler(this.UserControl_SettingConfig_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl_SettingConfig_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_FactoryName;
        private System.Windows.Forms.TextBox textBox_WorkerName;
        private System.Windows.Forms.TextBox textBox_LineNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_B_Line;
        private System.Windows.Forms.ComboBox comboBox_A_Line;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
