namespace Almus_BacodeProgram
{
    partial class UserControl_Scanning
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Scanned = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BoxCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_LotCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Master = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_TrayNumber = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_TestCount = new System.Windows.Forms.Label();
            this.button_PassFail = new System.Windows.Forms.Button();
            this.FocusTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_SAMPLEperBOX = new System.Windows.Forms.TextBox();
            this.textBox_TRAYperBox = new System.Windows.Forms.TextBox();
            this.textBox_SAMPLEperTray = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Scanned);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BoxCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_LotCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Master);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Infomation";
            // 
            // textBox_Scanned
            // 
            this.textBox_Scanned.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_Scanned.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Scanned.Location = new System.Drawing.Point(174, 207);
            this.textBox_Scanned.Name = "textBox_Scanned";
            this.textBox_Scanned.Size = new System.Drawing.Size(864, 50);
            this.textBox_Scanned.TabIndex = 8;
            this.textBox_Scanned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Scanned_KeyDown);
            this.textBox_Scanned.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Scanned_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Scan Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Box Code";
            // 
            // comboBox_BoxCode
            // 
            this.comboBox_BoxCode.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_BoxCode.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BoxCode.FormattingEnabled = true;
            this.comboBox_BoxCode.Location = new System.Drawing.Point(174, 84);
            this.comboBox_BoxCode.Name = "comboBox_BoxCode";
            this.comboBox_BoxCode.Size = new System.Drawing.Size(864, 50);
            this.comboBox_BoxCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lot Code";
            // 
            // comboBox_LotCode
            // 
            this.comboBox_LotCode.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox_LotCode.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LotCode.FormattingEnabled = true;
            this.comboBox_LotCode.Location = new System.Drawing.Point(174, 144);
            this.comboBox_LotCode.Name = "comboBox_LotCode";
            this.comboBox_LotCode.Size = new System.Drawing.Size(864, 50);
            this.comboBox_LotCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master";
            // 
            // comboBox_Master
            // 
            this.comboBox_Master.BackColor = System.Drawing.Color.LightSalmon;
            this.comboBox_Master.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Master.FormattingEnabled = true;
            this.comboBox_Master.Location = new System.Drawing.Point(174, 22);
            this.comboBox_Master.Name = "comboBox_Master";
            this.comboBox_Master.Size = new System.Drawing.Size(864, 50);
            this.comboBox_Master.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.button_PassFail);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count Infomation";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_TrayNumber);
            this.groupBox6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(27, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 287);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tray Number";
            // 
            // label_TrayNumber
            // 
            this.label_TrayNumber.AutoSize = true;
            this.label_TrayNumber.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrayNumber.Location = new System.Drawing.Point(88, 103);
            this.label_TrayNumber.Name = "label_TrayNumber";
            this.label_TrayNumber.Size = new System.Drawing.Size(66, 78);
            this.label_TrayNumber.TabIndex = 1;
            this.label_TrayNumber.Text = "0";
            this.label_TrayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_TestCount);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(356, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 287);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Count";
            // 
            // label_TestCount
            // 
            this.label_TestCount.AutoSize = true;
            this.label_TestCount.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TestCount.Location = new System.Drawing.Point(100, 103);
            this.label_TestCount.Name = "label_TestCount";
            this.label_TestCount.Size = new System.Drawing.Size(66, 78);
            this.label_TestCount.TabIndex = 0;
            this.label_TestCount.Text = "0";
            this.label_TestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_PassFail
            // 
            this.button_PassFail.BackColor = System.Drawing.Color.Honeydew;
            this.button_PassFail.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PassFail.Location = new System.Drawing.Point(687, 44);
            this.button_PassFail.Name = "button_PassFail";
            this.button_PassFail.Size = new System.Drawing.Size(351, 285);
            this.button_PassFail.TabIndex = 0;
            this.button_PassFail.Text = "PASS (0) / FAIL (0)";
            this.button_PassFail.UseVisualStyleBackColor = false;
            // 
            // FocusTimer
            // 
            this.FocusTimer.Interval = 400;
            this.FocusTimer.Tick += new System.EventHandler(this.FocusTimer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_SAMPLEperBOX);
            this.groupBox3.Controls.Add(this.textBox_TRAYperBox);
            this.groupBox3.Controls.Add(this.textBox_SAMPLEperTray);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_Start);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1044, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inspection Count Setting";
            // 
            // textBox_SAMPLEperBOX
            // 
            this.textBox_SAMPLEperBOX.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SAMPLEperBOX.Location = new System.Drawing.Point(163, 51);
            this.textBox_SAMPLEperBOX.Name = "textBox_SAMPLEperBOX";
            this.textBox_SAMPLEperBOX.ReadOnly = true;
            this.textBox_SAMPLEperBOX.Size = new System.Drawing.Size(117, 31);
            this.textBox_SAMPLEperBOX.TabIndex = 6;
            this.textBox_SAMPLEperBOX.TabStop = false;
            // 
            // textBox_TRAYperBox
            // 
            this.textBox_TRAYperBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TRAYperBox.Location = new System.Drawing.Point(401, 51);
            this.textBox_TRAYperBox.Name = "textBox_TRAYperBox";
            this.textBox_TRAYperBox.Size = new System.Drawing.Size(135, 31);
            this.textBox_TRAYperBox.TabIndex = 5;
            // 
            // textBox_SAMPLEperTray
            // 
            this.textBox_SAMPLEperTray.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SAMPLEperTray.Location = new System.Drawing.Point(687, 51);
            this.textBox_SAMPLEperTray.Name = "textBox_SAMPLEperTray";
            this.textBox_SAMPLEperTray.Size = new System.Drawing.Size(137, 31);
            this.textBox_SAMPLEperTray.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sample / Tray :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tray / Box :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sample / 1Box :";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.LimeGreen;
            this.button_Start.Location = new System.Drawing.Point(830, 15);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(208, 97);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // UserControl_Scanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_Scanning";
            this.Size = new System.Drawing.Size(1050, 738);
            this.Load += new System.EventHandler(this.UserControl_Scanning_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Scanning_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Scanned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_BoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_LotCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Master;
        private System.Windows.Forms.Timer FocusTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_PassFail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SAMPLEperBOX;
        private System.Windows.Forms.TextBox textBox_TRAYperBox;
        private System.Windows.Forms.TextBox textBox_SAMPLEperTray;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_TrayNumber;
        private System.Windows.Forms.Label label_TestCount;
    }
}
