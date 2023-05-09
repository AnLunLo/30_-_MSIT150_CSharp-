namespace HomeWork
{
    partial class HW2_Loan
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
            this.btm_ppm = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.txt_LoanTotal = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.Label();
            this.box_year = new System.Windows.Forms.TextBox();
            this.box_LoanTotal = new System.Windows.Forms.TextBox();
            this.box_first = new System.Windows.Forms.TextBox();
            this.box_rate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btm_ppm
            // 
            this.btm_ppm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btm_ppm.Location = new System.Drawing.Point(33, 237);
            this.btm_ppm.Name = "btm_ppm";
            this.btm_ppm.Size = new System.Drawing.Size(110, 39);
            this.btm_ppm.TabIndex = 0;
            this.btm_ppm.Text = "月付金額";
            this.btm_ppm.UseVisualStyleBackColor = true;
            this.btm_ppm.Click += new System.EventHandler(this.btm_ppm_Click_1);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(327, 237);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(110, 39);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "產生總表";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_total
            // 
            this.btn_total.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_total.Location = new System.Drawing.Point(178, 237);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(111, 39);
            this.btn_total.TabIndex = 2;
            this.btn_total.Text = "總付額";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // txt_LoanTotal
            // 
            this.txt_LoanTotal.AutoSize = true;
            this.txt_LoanTotal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LoanTotal.Location = new System.Drawing.Point(110, 37);
            this.txt_LoanTotal.Name = "txt_LoanTotal";
            this.txt_LoanTotal.Size = new System.Drawing.Size(86, 24);
            this.txt_LoanTotal.TabIndex = 3;
            this.txt_LoanTotal.Text = "貸款金額";
            // 
            // txt_first
            // 
            this.txt_first.AutoSize = true;
            this.txt_first.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_first.Location = new System.Drawing.Point(110, 161);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(67, 24);
            this.txt_first.TabIndex = 4;
            this.txt_first.Text = "頭期款";
            // 
            // txt_rate
            // 
            this.txt_rate.AutoSize = true;
            this.txt_rate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_rate.Location = new System.Drawing.Point(110, 120);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(77, 24);
            this.txt_rate.TabIndex = 5;
            this.txt_rate.Text = "利率(%)";
            // 
            // txt_year
            // 
            this.txt_year.AutoSize = true;
            this.txt_year.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_year.Location = new System.Drawing.Point(110, 80);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(79, 24);
            this.txt_year.TabIndex = 6;
            this.txt_year.Text = "期限(年)";
            // 
            // box_year
            // 
            this.box_year.Location = new System.Drawing.Point(219, 80);
            this.box_year.Name = "box_year";
            this.box_year.Size = new System.Drawing.Size(100, 22);
            this.box_year.TabIndex = 7;
            // 
            // box_LoanTotal
            // 
            this.box_LoanTotal.Location = new System.Drawing.Point(219, 43);
            this.box_LoanTotal.Name = "box_LoanTotal";
            this.box_LoanTotal.Size = new System.Drawing.Size(100, 22);
            this.box_LoanTotal.TabIndex = 7;
            // 
            // box_first
            // 
            this.box_first.Location = new System.Drawing.Point(219, 163);
            this.box_first.Name = "box_first";
            this.box_first.Size = new System.Drawing.Size(100, 22);
            this.box_first.TabIndex = 8;
            // 
            // box_rate
            // 
            this.box_rate.Location = new System.Drawing.Point(219, 120);
            this.box_rate.Name = "box_rate";
            this.box_rate.Size = new System.Drawing.Size(100, 22);
            this.box_rate.TabIndex = 9;
            // 
            // HW2_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 303);
            this.Controls.Add(this.box_rate);
            this.Controls.Add(this.box_first);
            this.Controls.Add(this.box_LoanTotal);
            this.Controls.Add(this.box_year);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.txt_LoanTotal);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btm_ppm);
            this.Name = "HW2_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_ppm;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label txt_LoanTotal;
        private System.Windows.Forms.Label txt_first;
        private System.Windows.Forms.Label txt_rate;
        private System.Windows.Forms.Label txt_year;
        private System.Windows.Forms.TextBox box_year;
        private System.Windows.Forms.TextBox box_LoanTotal;
        private System.Windows.Forms.TextBox box_first;
        private System.Windows.Forms.TextBox box_rate;
    }
}