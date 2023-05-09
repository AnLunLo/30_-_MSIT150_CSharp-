namespace HomeWork
{
    partial class HW13_Painting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開新檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar_Size = new System.Windows.Forms.TrackBar();
            this.label_ShowNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1642, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開新檔案ToolStripMenuItem,
            this.開啟舊檔ToolStripMenuItem,
            this.存檔ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(81, 34);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開新檔案ToolStripMenuItem
            // 
            this.開新檔案ToolStripMenuItem.Name = "開新檔案ToolStripMenuItem";
            this.開新檔案ToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.開新檔案ToolStripMenuItem.Text = "開新檔案";
            this.開新檔案ToolStripMenuItem.Click += new System.EventHandler(this.開新檔案ToolStripMenuItem_Click);
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            this.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            this.開啟舊檔ToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            // 
            // 存檔ToolStripMenuItem
            // 
            this.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            this.存檔ToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.存檔ToolStripMenuItem.Text = "存檔";
            this.存檔ToolStripMenuItem.Click += new System.EventHandler(this.存檔ToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "影像檔案|*.jpg;*.png";
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.Location = new System.Drawing.Point(11, 60);
            this.pictureBox_Main.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(1620, 941);
            this.pictureBox_Main.TabIndex = 1;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseDown);
            this.pictureBox_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseMove);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileName = "Image";
            // 
            // trackBar_Size
            // 
            this.trackBar_Size.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar_Size.Location = new System.Drawing.Point(1467, 83);
            this.trackBar_Size.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar_Size.Maximum = 20;
            this.trackBar_Size.Minimum = 1;
            this.trackBar_Size.Name = "trackBar_Size";
            this.trackBar_Size.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Size.Size = new System.Drawing.Size(90, 408);
            this.trackBar_Size.TabIndex = 2;
            this.trackBar_Size.Value = 2;
            this.trackBar_Size.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_ShowNum
            // 
            this.label_ShowNum.Location = new System.Drawing.Point(1454, 513);
            this.label_ShowNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ShowNum.Name = "label_ShowNum";
            this.label_ShowNum.Size = new System.Drawing.Size(121, 34);
            this.label_ShowNum.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1422, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "選擇顏色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HW13_Painting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 752);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_ShowNum);
            this.Controls.Add(this.trackBar_Size);
            this.Controls.Add(this.pictureBox_Main);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "HW13_Painting";
            this.Text = "HW13_Painting";
            this.Load += new System.EventHandler(this.HW13_Painting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.ToolStripMenuItem 開新檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存檔ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 粗細ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar_Size;
        private System.Windows.Forms.Label label_ShowNum;
        private System.Windows.Forms.Button button1;
    }
}