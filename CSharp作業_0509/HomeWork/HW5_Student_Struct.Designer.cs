namespace HomeWork
{
    partial class HW5_Student_Struct
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Math = new System.Windows.Forms.Label();
            this.label_English = new System.Windows.Forms.Label();
            this.label_Chinese = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Chinese = new System.Windows.Forms.TextBox();
            this.txtbox_Math = new System.Windows.Forms.TextBox();
            this.txtbox_English = new System.Windows.Forms.TextBox();
            this.btn_Store = new System.Windows.Forms.Button();
            this.btn_ShowStore = new System.Windows.Forms.Button();
            this.btn_ShowHighLow = new System.Windows.Forms.Button();
            this.label_SumBox = new System.Windows.Forms.Label();
            this.label_HighAndLow = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name.Location = new System.Drawing.Point(47, 103);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(69, 27);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "姓名 : ";
            // 
            // label_Math
            // 
            this.label_Math.AutoSize = true;
            this.label_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Math.Location = new System.Drawing.Point(47, 256);
            this.label_Math.Name = "label_Math";
            this.label_Math.Size = new System.Drawing.Size(69, 27);
            this.label_Math.TabIndex = 1;
            this.label_Math.Text = "數學 : ";
            // 
            // label_English
            // 
            this.label_English.AutoSize = true;
            this.label_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_English.Location = new System.Drawing.Point(47, 207);
            this.label_English.Name = "label_English";
            this.label_English.Size = new System.Drawing.Size(69, 27);
            this.label_English.TabIndex = 2;
            this.label_English.Text = "英文 : ";
            // 
            // label_Chinese
            // 
            this.label_Chinese.AutoSize = true;
            this.label_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Chinese.Location = new System.Drawing.Point(47, 157);
            this.label_Chinese.Name = "label_Chinese";
            this.label_Chinese.Size = new System.Drawing.Size(69, 27);
            this.label_Chinese.TabIndex = 3;
            this.label_Chinese.Text = "國文 : ";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox_Name.Location = new System.Drawing.Point(150, 103);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(94, 33);
            this.txtbox_Name.TabIndex = 4;
            this.txtbox_Name.Text = "0";
            this.txtbox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Chinese
            // 
            this.txtbox_Chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox_Chinese.Location = new System.Drawing.Point(150, 151);
            this.txtbox_Chinese.Name = "txtbox_Chinese";
            this.txtbox_Chinese.Size = new System.Drawing.Size(94, 33);
            this.txtbox_Chinese.TabIndex = 5;
            this.txtbox_Chinese.Text = "0";
            this.txtbox_Chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Math
            // 
            this.txtbox_Math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox_Math.Location = new System.Drawing.Point(150, 250);
            this.txtbox_Math.Name = "txtbox_Math";
            this.txtbox_Math.Size = new System.Drawing.Size(94, 33);
            this.txtbox_Math.TabIndex = 7;
            this.txtbox_Math.Text = "0";
            this.txtbox_Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_English
            // 
            this.txtbox_English.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox_English.Location = new System.Drawing.Point(150, 201);
            this.txtbox_English.Name = "txtbox_English";
            this.txtbox_English.Size = new System.Drawing.Size(94, 33);
            this.txtbox_English.TabIndex = 6;
            this.txtbox_English.Text = "0";
            this.txtbox_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Store
            // 
            this.btn_Store.Location = new System.Drawing.Point(30, 338);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(113, 39);
            this.btn_Store.TabIndex = 8;
            this.btn_Store.Text = "儲存";
            this.btn_Store.UseVisualStyleBackColor = true;
            this.btn_Store.Click += new System.EventHandler(this.btn_Store_Click);
            // 
            // btn_ShowStore
            // 
            this.btn_ShowStore.Location = new System.Drawing.Point(179, 338);
            this.btn_ShowStore.Name = "btn_ShowStore";
            this.btn_ShowStore.Size = new System.Drawing.Size(113, 39);
            this.btn_ShowStore.TabIndex = 9;
            this.btn_ShowStore.Text = "顯示儲存內容";
            this.btn_ShowStore.UseVisualStyleBackColor = true;
            this.btn_ShowStore.Click += new System.EventHandler(this.btn_ShowStore_Click);
            // 
            // btn_ShowHighLow
            // 
            this.btn_ShowHighLow.Location = new System.Drawing.Point(574, 388);
            this.btn_ShowHighLow.Name = "btn_ShowHighLow";
            this.btn_ShowHighLow.Size = new System.Drawing.Size(113, 39);
            this.btn_ShowHighLow.TabIndex = 10;
            this.btn_ShowHighLow.Text = "最高分/最低分科目";
            this.btn_ShowHighLow.UseVisualStyleBackColor = true;
            this.btn_ShowHighLow.Click += new System.EventHandler(this.btn_ShowHighLow_Click);
            // 
            // label_SumBox
            // 
            this.label_SumBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_SumBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SumBox.Location = new System.Drawing.Point(422, 81);
            this.label_SumBox.Name = "label_SumBox";
            this.label_SumBox.Size = new System.Drawing.Size(225, 121);
            this.label_SumBox.TabIndex = 11;
            
            // 
            // label_HighAndLow
            // 
            this.label_HighAndLow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_HighAndLow.Location = new System.Drawing.Point(422, 235);
            this.label_HighAndLow.Name = "label_HighAndLow";
            this.label_HighAndLow.Size = new System.Drawing.Size(225, 130);
            this.label_HighAndLow.TabIndex = 12;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Score.Location = new System.Drawing.Point(417, 36);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(54, 27);
            this.label_Score.TabIndex = 13;
            this.label_Score.Text = "成績";
            // 
            // HW5_Student_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_HighAndLow);
            this.Controls.Add(this.label_SumBox);
            this.Controls.Add(this.btn_ShowHighLow);
            this.Controls.Add(this.btn_ShowStore);
            this.Controls.Add(this.btn_Store);
            this.Controls.Add(this.txtbox_Math);
            this.Controls.Add(this.txtbox_English);
            this.Controls.Add(this.txtbox_Chinese);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.label_Chinese);
            this.Controls.Add(this.label_English);
            this.Controls.Add(this.label_Math);
            this.Controls.Add(this.label_Name);
            this.Name = "HW5_Student_Struct";
            this.Text = "HW5_Student_Struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Math;
        private System.Windows.Forms.Label label_English;
        private System.Windows.Forms.Label label_Chinese;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Chinese;
        private System.Windows.Forms.TextBox txtbox_Math;
        private System.Windows.Forms.TextBox txtbox_English;
        private System.Windows.Forms.Button btn_Store;
        private System.Windows.Forms.Button btn_ShowStore;
        private System.Windows.Forms.Button btn_ShowHighLow;
        private System.Windows.Forms.Label label_SumBox;
        private System.Windows.Forms.Label label_HighAndLow;
        private System.Windows.Forms.Label label_Score;
    }
}