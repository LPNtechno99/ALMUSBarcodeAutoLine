namespace Almus_BacodeProgram
{
    partial class UserControl_ViewDB
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
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBox_MasterCodeQuery = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MasterCode = new System.Windows.Forms.TextBox();
            this.button_ExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog_excel = new System.Windows.Forms.SaveFileDialog();
            this.progressBar_excel = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(145, 10);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(196, 23);
            this.dateTimePicker_StartTime.TabIndex = 0;
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(470, 10);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(197, 23);
            this.dateTimePicker_EndTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time :";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.LightYellow;
            this.button_Search.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(888, 8);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(159, 38);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 74);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1041, 661);
            this.dataGridView.TabIndex = 5;
            // 
            // checkBox_MasterCodeQuery
            // 
            this.checkBox_MasterCodeQuery.AutoSize = true;
            this.checkBox_MasterCodeQuery.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_MasterCodeQuery.Location = new System.Drawing.Point(18, 44);
            this.checkBox_MasterCodeQuery.Name = "checkBox_MasterCodeQuery";
            this.checkBox_MasterCodeQuery.Size = new System.Drawing.Size(15, 14);
            this.checkBox_MasterCodeQuery.TabIndex = 6;
            this.checkBox_MasterCodeQuery.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master Code :";
            // 
            // textBox_MasterCode
            // 
            this.textBox_MasterCode.Location = new System.Drawing.Point(144, 39);
            this.textBox_MasterCode.Name = "textBox_MasterCode";
            this.textBox_MasterCode.Size = new System.Drawing.Size(197, 23);
            this.textBox_MasterCode.TabIndex = 8;
            // 
            // button_ExportExcel
            // 
            this.button_ExportExcel.BackColor = System.Drawing.Color.LightYellow;
            this.button_ExportExcel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportExcel.Location = new System.Drawing.Point(723, 8);
            this.button_ExportExcel.Name = "button_ExportExcel";
            this.button_ExportExcel.Size = new System.Drawing.Size(159, 38);
            this.button_ExportExcel.TabIndex = 9;
            this.button_ExportExcel.Text = "Export Excel";
            this.button_ExportExcel.UseVisualStyleBackColor = false;
            this.button_ExportExcel.Click += new System.EventHandler(this.button_ExportExcel_Click);
            // 
            // saveFileDialog_excel
            // 
            this.saveFileDialog_excel.Filter = "excel file (*.xlsx)|*.xlsx";
            // 
            // progressBar_excel
            // 
            this.progressBar_excel.Location = new System.Drawing.Point(723, 48);
            this.progressBar_excel.Name = "progressBar_excel";
            this.progressBar_excel.Size = new System.Drawing.Size(324, 22);
            this.progressBar_excel.TabIndex = 10;
            // 
            // UserControl_ViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.progressBar_excel);
            this.Controls.Add(this.button_ExportExcel);
            this.Controls.Add(this.textBox_MasterCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_MasterCodeQuery);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_ViewDB";
            this.Size = new System.Drawing.Size(1050, 738);
            this.Load += new System.EventHandler(this.UserControl_ViewDB_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl_ViewDB_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBox_MasterCodeQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MasterCode;
        private System.Windows.Forms.Button button_ExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_excel;
        private System.Windows.Forms.ProgressBar progressBar_excel;
    }
}
