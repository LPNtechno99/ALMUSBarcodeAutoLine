namespace Almus_BacodeProgram
{
    partial class ErrorAlarmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_NG = new System.Windows.Forms.Timer(this.components);
            this.button_NG_Display = new System.Windows.Forms.Button();
            this.textBox_NG_Reason = new System.Windows.Forms.TextBox();
            this.textBox_OriginCode = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ReportNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_NG
            // 
            this.timer_NG.Enabled = true;
            this.timer_NG.Interval = 200;
            this.timer_NG.Tick += new System.EventHandler(this.timer_NG_Tick);
            // 
            // button_NG_Display
            // 
            this.button_NG_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NG_Display.BackColor = System.Drawing.Color.White;
            this.button_NG_Display.Font = new System.Drawing.Font("Corbel", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NG_Display.Location = new System.Drawing.Point(12, 12);
            this.button_NG_Display.Name = "button_NG_Display";
            this.button_NG_Display.Size = new System.Drawing.Size(1176, 223);
            this.button_NG_Display.TabIndex = 1;
            this.button_NG_Display.Text = "NG";
            this.button_NG_Display.UseVisualStyleBackColor = false;
            // 
            // textBox_NG_Reason
            // 
            this.textBox_NG_Reason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NG_Reason.BackColor = System.Drawing.Color.White;
            this.textBox_NG_Reason.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NG_Reason.Location = new System.Drawing.Point(12, 277);
            this.textBox_NG_Reason.Name = "textBox_NG_Reason";
            this.textBox_NG_Reason.Size = new System.Drawing.Size(1176, 66);
            this.textBox_NG_Reason.TabIndex = 2;
            // 
            // textBox_OriginCode
            // 
            this.textBox_OriginCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OriginCode.BackColor = System.Drawing.Color.White;
            this.textBox_OriginCode.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OriginCode.Location = new System.Drawing.Point(12, 376);
            this.textBox_OriginCode.Name = "textBox_OriginCode";
            this.textBox_OriginCode.ReadOnly = true;
            this.textBox_OriginCode.Size = new System.Drawing.Size(1176, 66);
            this.textBox_OriginCode.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Password.BackColor = System.Drawing.Color.White;
            this.textBox_Password.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(12, 479);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(1176, 66);
            this.textBox_Password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "NG Reason";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Origin Code";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // button_ReportNG
            // 
            this.button_ReportNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_ReportNG.BackColor = System.Drawing.Color.Black;
            this.button_ReportNG.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReportNG.ForeColor = System.Drawing.Color.White;
            this.button_ReportNG.Location = new System.Drawing.Point(12, 558);
            this.button_ReportNG.Name = "button_ReportNG";
            this.button_ReportNG.Size = new System.Drawing.Size(1175, 61);
            this.button_ReportNG.TabIndex = 8;
            this.button_ReportNG.Text = "Report NG";
            this.button_ReportNG.UseVisualStyleBackColor = false;
            this.button_ReportNG.Click += new System.EventHandler(this.button_ReportNG_Click);
            // 
            // ErrorAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 641);
            this.Controls.Add(this.button_ReportNG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_OriginCode);
            this.Controls.Add(this.textBox_NG_Reason);
            this.Controls.Add(this.button_NG_Display);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErrorAlarmForm";
            this.Text = "ErrorAlarmForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_NG;
        private System.Windows.Forms.Button button_NG_Display;
        private System.Windows.Forms.TextBox textBox_NG_Reason;
        private System.Windows.Forms.TextBox textBox_OriginCode;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ReportNG;
    }
}