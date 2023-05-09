namespace HomeWork
{
    partial class HW14_Alarm
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
            this.timer_showTime = new System.Windows.Forms.Timer(this.components);
            this.label_NowTime = new System.Windows.Forms.Label();
            this.label_CountDown = new System.Windows.Forms.Label();
            this.checkBox_SetAlarm = new System.Windows.Forms.CheckBox();
            this.groupBox_Time = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Sec = new System.Windows.Forms.ComboBox();
            this.comboBox_Min = new System.Windows.Forms.ComboBox();
            this.comboBox_Hr = new System.Windows.Forms.ComboBox();
            this.timer_CountDown = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_showTime
            // 
            this.timer_showTime.Interval = 1000;
            this.timer_showTime.Tick += new System.EventHandler(this.timer_Time);
            // 
            // label_NowTime
            // 
            this.label_NowTime.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_NowTime.Location = new System.Drawing.Point(14, 22);
            this.label_NowTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_NowTime.Name = "label_NowTime";
            this.label_NowTime.Size = new System.Drawing.Size(132, 65);
            this.label_NowTime.TabIndex = 0;
            // 
            // label_CountDown
            // 
            this.label_CountDown.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CountDown.Location = new System.Drawing.Point(3, 48);
            this.label_CountDown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_CountDown.Name = "label_CountDown";
            this.label_CountDown.Size = new System.Drawing.Size(91, 28);
            this.label_CountDown.TabIndex = 1;
            this.label_CountDown.Text = "倒數計時:";
            // 
            // checkBox_SetAlarm
            // 
            this.checkBox_SetAlarm.AutoSize = true;
            this.checkBox_SetAlarm.Location = new System.Drawing.Point(162, 114);
            this.checkBox_SetAlarm.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.checkBox_SetAlarm.Name = "checkBox_SetAlarm";
            this.checkBox_SetAlarm.Size = new System.Drawing.Size(143, 28);
            this.checkBox_SetAlarm.TabIndex = 4;
            this.checkBox_SetAlarm.Text = "設定倒數計時";
            this.checkBox_SetAlarm.UseVisualStyleBackColor = true;
            this.checkBox_SetAlarm.CheckedChanged += new System.EventHandler(this.checkBox_SetAlarm_CheckedChanged);
            // 
            // groupBox_Time
            // 
            this.groupBox_Time.Controls.Add(this.btn_Reset);
            this.groupBox_Time.Controls.Add(this.label3);
            this.groupBox_Time.Controls.Add(this.label2);
            this.groupBox_Time.Controls.Add(this.label1);
            this.groupBox_Time.Controls.Add(this.comboBox_Sec);
            this.groupBox_Time.Controls.Add(this.comboBox_Min);
            this.groupBox_Time.Controls.Add(this.comboBox_Hr);
            this.groupBox_Time.Controls.Add(this.checkBox_SetAlarm);
            this.groupBox_Time.Controls.Add(this.label_CountDown);
            this.groupBox_Time.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Time.Location = new System.Drawing.Point(12, 81);
            this.groupBox_Time.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox_Time.Name = "groupBox_Time";
            this.groupBox_Time.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox_Time.Size = new System.Drawing.Size(392, 201);
            this.groupBox_Time.TabIndex = 5;
            this.groupBox_Time.TabStop = false;
            this.groupBox_Time.Text = "選擇時間";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Enabled = false;
            this.btn_Reset.Location = new System.Drawing.Point(182, 151);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(82, 30);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(342, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "秒";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(249, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "分";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(155, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "時";
            // 
            // comboBox_Sec
            // 
            this.comboBox_Sec.DisplayMember = "1";
            this.comboBox_Sec.FormattingEnabled = true;
            this.comboBox_Sec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Sec.Location = new System.Drawing.Point(284, 45);
            this.comboBox_Sec.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBox_Sec.Name = "comboBox_Sec";
            this.comboBox_Sec.Size = new System.Drawing.Size(58, 31);
            this.comboBox_Sec.TabIndex = 7;
            this.comboBox_Sec.ValueMember = "1,2,3";
            // 
            // comboBox_Min
            // 
            this.comboBox_Min.DisplayMember = "1";
            this.comboBox_Min.FormattingEnabled = true;
            this.comboBox_Min.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Min.Location = new System.Drawing.Point(191, 45);
            this.comboBox_Min.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBox_Min.Name = "comboBox_Min";
            this.comboBox_Min.Size = new System.Drawing.Size(58, 31);
            this.comboBox_Min.TabIndex = 6;
            this.comboBox_Min.ValueMember = "1,2,3";
            // 
            // comboBox_Hr
            // 
            this.comboBox_Hr.DisplayMember = "1";
            this.comboBox_Hr.FormattingEnabled = true;
            this.comboBox_Hr.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Hr.Location = new System.Drawing.Point(96, 45);
            this.comboBox_Hr.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBox_Hr.Name = "comboBox_Hr";
            this.comboBox_Hr.Size = new System.Drawing.Size(58, 31);
            this.comboBox_Hr.TabIndex = 5;
            this.comboBox_Hr.ValueMember = "1,2,3";
            // 
            // timer_CountDown
            // 
            this.timer_CountDown.Tick += new System.EventHandler(this.timer_CountDown_Tick);
            // 
            // HW14_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 298);
            this.Controls.Add(this.groupBox_Time);
            this.Controls.Add(this.label_NowTime);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "HW14_Alarm";
            this.Text = "HW14_Alarm";
            this.Load += new System.EventHandler(this.HW14_Alarm_Load);
            this.groupBox_Time.ResumeLayout(false);
            this.groupBox_Time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_showTime;
        private System.Windows.Forms.Label label_NowTime;
        private System.Windows.Forms.Label label_CountDown;
        private System.Windows.Forms.CheckBox checkBox_SetAlarm;
        private System.Windows.Forms.GroupBox groupBox_Time;
        private System.Windows.Forms.ComboBox comboBox_Hr;
        private System.Windows.Forms.ComboBox comboBox_Sec;
        private System.Windows.Forms.ComboBox comboBox_Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Timer timer_CountDown;
    }
}