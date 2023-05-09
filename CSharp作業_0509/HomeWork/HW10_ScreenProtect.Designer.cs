namespace HomeWork
{
    partial class HW10_ScreenProtect
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
            this.timer_ShowTime = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.pic_puppy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_puppy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_ShowTime
            // 
            this.timer_ShowTime.Tick += new System.EventHandler(this.timer_ShowTime_Tick);
            // 
            // label_Time
            // 
            this.label_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Time.Font = new System.Drawing.Font("微軟正黑體", 92.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Time.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Time.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Time.Location = new System.Drawing.Point(377, 18);
            this.label_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(1610, 890);
            this.label_Time.TabIndex = 0;
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // pic_puppy
            // 
            this.pic_puppy.BackColor = System.Drawing.Color.Transparent;
            this.pic_puppy.BackgroundImage = global::HomeWork.Properties.Resources.puppy;
            this.pic_puppy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_puppy.Location = new System.Drawing.Point(717, 356);
            this.pic_puppy.Margin = new System.Windows.Forms.Padding(0);
            this.pic_puppy.Name = "pic_puppy";
            this.pic_puppy.Size = new System.Drawing.Size(596, 236);
            this.pic_puppy.TabIndex = 1;
            this.pic_puppy.TabStop = false;
            // 
            // HW10_ScreenProtect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1556, 908);
            this.ControlBox = false;
            this.Controls.Add(this.pic_puppy);
            this.Controls.Add(this.label_Time);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "HW10_ScreenProtect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HW10_ScreenProtect";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HW10_ScreenProtect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HW10_ScreenProtect_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HW10_ScreenProtect_MouseClick);
            this.MouseCaptureChanged += new System.EventHandler(this.HW10_ScreenProtect_MouseCaptureChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pic_puppy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_ShowTime;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.PictureBox pic_puppy;
    }
}