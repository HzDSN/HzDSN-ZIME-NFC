namespace 读卡器YLE_280U功能演示
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnYLE280_Open = new System.Windows.Forms.Button();
            this.btnYLE280_Reset = new System.Windows.Forms.Button();
            this.btnYLE280_Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbComPortNo = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBuzzer = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkRedLed = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_GetUID = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYLE280_Open
            // 
            this.btnYLE280_Open.Location = new System.Drawing.Point(262, 21);
            this.btnYLE280_Open.Name = "btnYLE280_Open";
            this.btnYLE280_Open.Size = new System.Drawing.Size(87, 23);
            this.btnYLE280_Open.TabIndex = 0;
            this.btnYLE280_Open.Text = "串口打开";
            this.btnYLE280_Open.UseVisualStyleBackColor = true;
            this.btnYLE280_Open.Click += new System.EventHandler(this.btnYLE280_Open_Click);
            // 
            // btnYLE280_Reset
            // 
            this.btnYLE280_Reset.Location = new System.Drawing.Point(469, 21);
            this.btnYLE280_Reset.Name = "btnYLE280_Reset";
            this.btnYLE280_Reset.Size = new System.Drawing.Size(86, 23);
            this.btnYLE280_Reset.TabIndex = 0;
            this.btnYLE280_Reset.Text = "串口重置";
            this.btnYLE280_Reset.UseVisualStyleBackColor = true;
            this.btnYLE280_Reset.Click += new System.EventHandler(this.btnYLE280_Reset_Click);
            // 
            // btnYLE280_Close
            // 
            this.btnYLE280_Close.Location = new System.Drawing.Point(361, 21);
            this.btnYLE280_Close.Name = "btnYLE280_Close";
            this.btnYLE280_Close.Size = new System.Drawing.Size(91, 23);
            this.btnYLE280_Close.TabIndex = 0;
            this.btnYLE280_Close.Text = "串口关闭";
            this.btnYLE280_Close.UseVisualStyleBackColor = true;
            this.btnYLE280_Close.Click += new System.EventHandler(this.btnYLE280_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "COM端口号（0=死找）";
            // 
            // cbComPortNo
            // 
            this.cbComPortNo.FormattingEnabled = true;
            this.cbComPortNo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbComPortNo.Location = new System.Drawing.Point(138, 21);
            this.cbComPortNo.Name = "cbComPortNo";
            this.cbComPortNo.Size = new System.Drawing.Size(57, 20);
            this.cbComPortNo.TabIndex = 6;
            this.cbComPortNo.Text = "0";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 12;
            this.lbInfo.Location = new System.Drawing.Point(12, 210);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(531, 148);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.SelectedIndexChanged += new System.EventHandler(this.lbInfo_SelectedIndexChanged);
            this.lbInfo.ValueMemberChanged += new System.EventHandler(this.lbInfo_ValueMemberChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBuzzer);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chkRedLed);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "硬件测试";
            // 
            // chkBuzzer
            // 
            this.chkBuzzer.AutoSize = true;
            this.chkBuzzer.Location = new System.Drawing.Point(16, 64);
            this.chkBuzzer.Name = "chkBuzzer";
            this.chkBuzzer.Size = new System.Drawing.Size(60, 16);
            this.chkBuzzer.TabIndex = 11;
            this.chkBuzzer.Text = "蜂鸣器";
            this.chkBuzzer.UseVisualStyleBackColor = true;
            this.chkBuzzer.CheckedChanged += new System.EventHandler(this.chkBuzzer_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "绿灯";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chkRedLed
            // 
            this.chkRedLed.AutoSize = true;
            this.chkRedLed.Location = new System.Drawing.Point(16, 20);
            this.chkRedLed.Name = "chkRedLed";
            this.chkRedLed.Size = new System.Drawing.Size(48, 16);
            this.chkRedLed.TabIndex = 9;
            this.chkRedLed.Text = "红灯";
            this.chkRedLed.UseVisualStyleBackColor = true;
            this.chkRedLed.CheckedChanged += new System.EventHandler(this.chkRedLed_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_GetUID);
            this.groupBox2.Location = new System.Drawing.Point(138, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "序列号";
            // 
            // button_GetUID
            // 
            this.button_GetUID.Location = new System.Drawing.Point(6, 20);
            this.button_GetUID.Name = "button_GetUID";
            this.button_GetUID.Size = new System.Drawing.Size(75, 23);
            this.button_GetUID.TabIndex = 11;
            this.button_GetUID.Text = "获取UID";
            this.button_GetUID.UseVisualStyleBackColor = true;
            this.button_GetUID.Click += new System.EventHandler(this.button_GetUID_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbComPortNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnYLE280_Close);
            this.Controls.Add(this.btnYLE280_Reset);
            this.Controls.Add(this.btnYLE280_Open);
            this.Name = "FrmMain";
            this.Text = "功能测试主界面";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYLE280_Open;
        private System.Windows.Forms.Button btnYLE280_Reset;
        private System.Windows.Forms.Button btnYLE280_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbComPortNo;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBuzzer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkRedLed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_GetUID;
    }
}

