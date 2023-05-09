using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class HW10_ScreenProtect : Form
    {
        public HW10_ScreenProtect()
        {
            InitializeComponent();

            Cursor.Hide();//隱藏鼠標
            pic_puppy.Parent = label_Time;//解決透明底色掩蓋問題

        }
        
        private void HW10_ScreenProtect_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Cursor.Show();
        }
        private void HW10_ScreenProtect_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
            Cursor.Show();
        }
       
        

        int puppyLastLeft ; //紀錄上一個位置
        int puppyLastTop ;
        

        void setPositon() //當圖像移動之後，將位置資訊做更新
        {
            puppyLastLeft = pic_puppy.Left;
            puppyLastTop = pic_puppy.Top;
           
        }

       
        void goTL()//往左上
        {
            pic_puppy.Left -= 1;
            pic_puppy.Top -= 1;
        }
        void goTR()//往右上
        {
            pic_puppy.Left += 1; 
            pic_puppy.Top -= 1;
        }
        void goDL()//往左下
        {
            pic_puppy.Left -= 1;
            pic_puppy.Top += 1;
        }
        void goDR()//往右下
        {
            pic_puppy.Left += 1;
            pic_puppy.Top += 1;
        }



        private void timer_ShowTime_Tick(object sender, EventArgs e)
        {
            
                label_Time.Text = DateTime.Now.ToString($"HH : mm : ss");

                if (pic_puppy.Left < puppyLastLeft && pic_puppy.Top < puppyLastTop)//如果上一動往左上
                {
                    setPositon();
                    if (pic_puppy.Top == 0)
                    {
                        goDL();//往左下
                    }
                    else if (pic_puppy.Left == 0)
                    {
                        goTR();//往右上
                    }
                    else
                        goTL();//往左上
                }

                if (pic_puppy.Left > puppyLastLeft && pic_puppy.Top < puppyLastTop)//如果上一動往右上
                {
                    setPositon();
                    if (pic_puppy.Top == 0)
                    {
                        goDR();//往右下;
                    }
                    else if ((pic_puppy.Left == this.Width - pic_puppy.Width))
                    {
                        goTL();//往左上
                    }
                    else
                        goTR();//往右上
                }

                if (pic_puppy.Left < puppyLastLeft && pic_puppy.Top > puppyLastTop)//如果上一動往左下
                {
                    setPositon();
                    if ((pic_puppy.Top == this.Height - pic_puppy.Height))
                    {
                        goTL();//往左上
                    }
                    else if (pic_puppy.Left == 0)
                    {
                        goDR();//往右下;
                    }
                    else
                        goDL();//往左下
                }
                if (pic_puppy.Left > puppyLastLeft && pic_puppy.Top > puppyLastTop)//如果上一動往右下

                {

                    setPositon();
                    if ((pic_puppy.Top == this.Height - pic_puppy.Height))
                    {
                        goTR();//往右上
                    }
                    else if ((pic_puppy.Left == this.Width - pic_puppy.Width))
                    {
                        goDL();//往左下
                    }
                    else
                        goDR();//往右下;
                }

            
            
        }

       
        private void HW10_ScreenProtect_Load(object sender, EventArgs e)
        {   
            
            timer_ShowTime.Enabled = true;
            timer_ShowTime.Interval = 1;
            timer_ShowTime.Start();

            setPositon();
            pic_puppy.Left -= 1; //程式初次載入時，圖像先往左上方移動，以連動後續判斷
            pic_puppy.Top -= 1;
            label_Time.Left = (this.Width - label_Time.Width) / 2;//設定時間文字位於畫面正中央
            label_Time.Top = (this.Height - label_Time.Height) / 2;


        }

        private void label_Time_Click(object sender, EventArgs e)//如果按到的區塊是時間顯示區
        {
            this.Close();
            Cursor.Show();
        }

        private void HW10_ScreenProtect_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
            Cursor.Show();
        }

       
    }
}
