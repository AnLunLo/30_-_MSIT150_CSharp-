namespace HomeWork
{
    partial class HW1_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SayHello = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_EN_name = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.Label();
            this.txt_star = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_star = new System.Windows.Forms.TextBox();
            this.box_gender = new System.Windows.Forms.TextBox();
            this.box_en_name = new System.Windows.Forms.TextBox();
            this.btn_SayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SayHello
            // 
            this.btn_SayHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SayHello.Location = new System.Drawing.Point(64, 255);
            this.btn_SayHello.Name = "btn_SayHello";
            this.btn_SayHello.Size = new System.Drawing.Size(116, 40);
            this.btn_SayHello.TabIndex = 0;
            this.btn_SayHello.Text = "Say HELLO!";
            this.btn_SayHello.UseVisualStyleBackColor = true;
            this.btn_SayHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(61, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(75, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "姓名：";
            // 
            // txt_EN_name
            // 
            this.txt_EN_name.AutoSize = true;
            this.txt_EN_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_EN_name.Location = new System.Drawing.Point(59, 87);
            this.txt_EN_name.Name = "txt_EN_name";
            this.txt_EN_name.Size = new System.Drawing.Size(168, 27);
            this.txt_EN_name.TabIndex = 3;
            this.txt_EN_name.Text = "English Name：";
            // 
            // txt_gender
            // 
            this.txt_gender.AutoSize = true;
            this.txt_gender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_gender.Location = new System.Drawing.Point(59, 141);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(75, 27);
            this.txt_gender.TabIndex = 4;
            this.txt_gender.Text = "性別：";
            // 
            // txt_star
            // 
            this.txt_star.AutoSize = true;
            this.txt_star.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_star.Location = new System.Drawing.Point(59, 196);
            this.txt_star.Name = "txt_star";
            this.txt_star.Size = new System.Drawing.Size(75, 27);
            this.txt_star.TabIndex = 5;
            this.txt_star.Text = "星座：";
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(216, 40);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(100, 22);
            this.box_name.TabIndex = 6;
            
            // 
            // box_star
            // 
            this.box_star.Location = new System.Drawing.Point(216, 204);
            this.box_star.Name = "box_star";
            this.box_star.Size = new System.Drawing.Size(100, 22);
            this.box_star.TabIndex = 7;
            // 
            // box_gender
            // 
            this.box_gender.Location = new System.Drawing.Point(216, 149);
            this.box_gender.Name = "box_gender";
            this.box_gender.Size = new System.Drawing.Size(100, 22);
            this.box_gender.TabIndex = 8;
            // 
            // box_en_name
            // 
            this.box_en_name.Location = new System.Drawing.Point(216, 92);
            this.box_en_name.Name = "box_en_name";
            this.box_en_name.Size = new System.Drawing.Size(100, 22);
            this.box_en_name.TabIndex = 9;
            // 
            // btn_SayHi
            // 
            this.btn_SayHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SayHi.Location = new System.Drawing.Point(207, 255);
            this.btn_SayHi.Name = "btn_SayHi";
            this.btn_SayHi.Size = new System.Drawing.Size(93, 40);
            this.btn_SayHi.TabIndex = 10;
            this.btn_SayHi.Text = "Say HI!";
            this.btn_SayHi.UseVisualStyleBackColor = true;
            this.btn_SayHi.Click += new System.EventHandler(this.btn_SayHi_Click);
            // 
            // HW1_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 359);
            this.Controls.Add(this.btn_SayHi);
            this.Controls.Add(this.box_en_name);
            this.Controls.Add(this.box_gender);
            this.Controls.Add(this.box_star);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.txt_star);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_EN_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_SayHello);
            this.Name = "HW1_Hello";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SayHello;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_EN_name;
        private System.Windows.Forms.Label txt_gender;
        private System.Windows.Forms.Label txt_star;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox box_star;
        private System.Windows.Forms.TextBox box_gender;
        private System.Windows.Forms.TextBox box_en_name;
        private System.Windows.Forms.Button btn_SayHi;
    }
}

