using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HomeWork
{
    public partial class HW7_OX_Game : Form
    {
        public HW7_OX_Game()
        {
            InitializeComponent();
        }

        static void  Num1(ref int a) //初始化OX判定
        {
            a = 0; 
        }

        static void AllBlock(ref int a, ref int b, ref int c, ref int d, ref int e, ref int f,ref int g, ref int h, ref int i)//初始化所有按鈕
        { 
        a=0; b=0; c=0; d=0; e=0; f=0; g=0; h=0; i=0;
        }

        
        string BlockO = "O";
        string BlockX = "X";
        int Num = 0;//用來判斷該次要下X還是O
        int A1= 0, A2 = 0, A3 = 0, A4 = 0, A5 = 0, A6 = 0, A7 = 0, A8 = 0, A9= 0; //每一個按鈕初始值是0

        private void Test() //檢查用，上架停用
        {
            //label_Test.Text = $" {Num.ToString()} \n {A1.ToString()}  {A2.ToString()}  {A3.ToString()}  {A4.ToString()} {A5.ToString()}  {A6.ToString()}  {A7.ToString()}  {A8.ToString()} {A9.ToString()}  ";
        }


        private void Condition()//定義OX贏的時候跟平手的狀態
        {

            if (
                (A1 == 1 && A2 == 1 && A3 == 1) ||
                (A4 == 1 && A5 == 1 && A6 == 1) ||
                (A7 == 1 && A8 == 1 && A9 == 1) ||
                (A1 == 1 && A4 == 1 && A7 == 1) ||
                (A2 == 1 && A5 == 1 && A8 == 1) ||
                (A3 == 1 && A6 == 1 && A9 == 1) ||
                (A1 == 1 && A5 == 1 && A9 == 1) ||
                (A3 == 1 && A5 == 1 && A7 == 1)
                )
            {
                MessageBox.Show("X 方獲勝");
                CleanAll();
            }
            else if (
                (A1 == -1 && A2 == -1 && A3 == -1) ||
                (A4 == -1 && A5 == -1 && A6 == -1) ||
                (A7 == -1 && A8 == -1 && A9 == -1) ||
                (A1 == -1 && A4 == -1 && A7 == -1) ||
                (A2 == -1 && A5 == -1 && A8 == -1) ||
                (A3 == -1 && A6 == -1 && A9 == -1) ||
                (A1 == -1 && A5 == -1 && A9 == -1) ||
                (A3 == -1 && A5 == -1 && A7 == -1)
                )
            {
                MessageBox.Show("O 方獲勝");
                CleanAll();
            }

            else if (A1 != 0 && A2 != 0 && A3 != 0 && A4 != 0 && A5 != 0 && A6 != 0 && A7 != 0 && A8 != 0 && A9 != 0  )
            { 
                MessageBox.Show("平手!");
                CleanAll();

            }


        }
         
        //設定九個按鈕
       

        private void btn_ul_Click(object sender, EventArgs e) 
        {
            Num++;
          
            btn_ul.Enabled = false;
            
            if (Num % 2 == 0) //第奇數次按下按鈕時是X
            {
                btn_ul.Text = BlockX;
                A1++;
            }
            else
            {
                btn_ul.Text = BlockO;
                A1--;
            }
            Test();
            Condition();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            Num++;
           


            btn_um.Enabled = false;
            if (Num % 2 == 0) 
            {
                btn_um.Text = BlockX;
                A2++;
            }
            else
            {
                btn_um.Text = BlockO;
                A2--;
            }
            Test();
            Condition();
        }

        private void btn_ur_Click(object sender, EventArgs e)
        {
            Num++;
           
            btn_ur.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_ur.Text = BlockX;
                A3++;
            }
            else
            {
                btn_ur.Text = BlockO;
                A3--;
            }
            Test();
            Condition();
        }

        private void btn_ml_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_ml.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_ml.Text = BlockX;
                A4++;
            }
            else
            {
                btn_ml.Text = BlockO;
                A4--;
            }
            Test();
            Condition();
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_mm.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_mm.Text = BlockX;
                A5++;   
            }
            else
            {
                btn_mm.Text = BlockO;
                A5--;
            }
            Test();
            Condition();
        }

        private void btn_mr_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_mr.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_mr.Text = BlockX;
                A6++;
            }
            else
            {
                btn_mr.Text = BlockO;
                A6--;
            }
            Test();
            Condition();
        }

        private void btn_bl_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_bl.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_bl.Text = BlockX;
                A7++;
            }
            else
            {
                btn_bl.Text = BlockO;
                A7--;
            }
                Test();
            Condition();
        }

        private void btn_bm_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_bm.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_bm.Text = BlockX;
                A8++;
            }
            else
            {
                btn_bm.Text = BlockO;
                A8--;
            }
            Test();
            Condition();
        }

        private void btn_br_Click(object sender, EventArgs e)
        {
            Num++;
            
            btn_br.Enabled = false;
            if (Num % 2 == 0)
            {
                btn_br.Text = BlockX;
                A9++;
            }
            else
            {
                btn_br.Text = BlockO;
                A9--;
            }
            Test();
            Condition();
        }


        private void CleanAll() // 重置遊戲

        {
            try
            {
                Num1(ref Num);
                Button[] buttons = { btn_ul, btn_um, btn_ur, btn_ml, btn_mm, btn_mr, btn_bl, btn_bm, btn_br };
                foreach (Button button in buttons)
                {
                    button.Text = "";
                    button.Enabled = true;
                }
                AllBlock(ref A1, ref A2, ref A3, ref A4, ref A5, ref A6, ref A7, ref A8, ref A9);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e) //清空所有按鈕
        {
            CleanAll();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//離開遊戲按鈕

        private void HW7_OX_Game_KeyDown(object sender, KeyEventArgs e) //當鍵盤按下
        {
            try
            {

                if (e.KeyCode == Keys.R)//按下R重置遊戲
                {
                    CleanAll();
                }

                else if (e.KeyCode == Keys.Escape) //按下Esc鍵離開遊戲
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
