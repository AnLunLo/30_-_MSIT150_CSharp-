namespace HomeWork
{
    partial class HW8_Guess
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
            this.label_Main = new System.Windows.Forms.Label();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.btn_ShowAnswer = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Main
            // 
            this.label_Main.BackColor = System.Drawing.Color.Transparent;
            this.label_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Main.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Main.Location = new System.Drawing.Point(1, 17);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(416, 113);
            this.label_Main.TabIndex = 0;
            this.label_Main.Text = "請選擇1~100之間的數字!";
            this.label_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Guess
            // 
            this.btn_Guess.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Guess.Location = new System.Drawing.Point(20, 183);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(134, 62);
            this.btn_Guess.TabIndex = 1;
            this.btn_Guess.Text = "開始猜";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_ShowAnswer
            // 
            this.btn_ShowAnswer.Enabled = false;
            this.btn_ShowAnswer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ShowAnswer.Location = new System.Drawing.Point(288, 183);
            this.btn_ShowAnswer.Name = "btn_ShowAnswer";
            this.btn_ShowAnswer.Size = new System.Drawing.Size(134, 62);
            this.btn_ShowAnswer.TabIndex = 2;
            this.btn_ShowAnswer.Text = "公布答案";
            this.btn_ShowAnswer.UseVisualStyleBackColor = true;
            this.btn_ShowAnswer.Click += new System.EventHandler(this.btn_ShowAnswer_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label_Main);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox.Location = new System.Drawing.Point(14, 33);
            this.groupBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox.Size = new System.Drawing.Size(418, 132);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            
            // 
            // HW8_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 265);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn_ShowAnswer);
            this.Controls.Add(this.btn_Guess);
            this.Name = "HW8_Guess";
            this.Text = "HW8_Guess";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Main;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_ShowAnswer;
        private System.Windows.Forms.GroupBox groupBox;
    }
}