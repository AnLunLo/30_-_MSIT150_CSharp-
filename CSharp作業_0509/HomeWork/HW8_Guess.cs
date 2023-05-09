using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.Utility;

namespace HomeWork
{
    
    public partial class HW8_Guess : Form
    {
        

        public HW8_Guess()
        {
            InitializeComponent();
        }

        public class GuessNum
        {
            public int a = 0;
        }
        
       
        public string userNum //把使用者的數字儲存到userNum
        {
            set
            {
                label_Main.Text = value;
            }
        }


        private int a;
        public static int ranNum; //將隨機產生的數字儲存在ranNum

        private void btn_Guess_Click(object sender, EventArgs e)//按下開始按鈕，即產生隨機數字
        {
            try
            {
                btn_ShowAnswer.Enabled = true;
                label_Main.Text = "請選擇1~100之間的數字!";
                GuessGame.RandomAnswer(out a);
                ranNum = a;
                HW8_Guess_Popup pop = new HW8_Guess_Popup(this);
                /*pop.StartPosition = FormStartPosition.CenterScreen;*///設定開啟後在螢幕正中間，避免重疊主視窗
                pop.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_ShowAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"正確答案是: {ranNum.ToString()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
