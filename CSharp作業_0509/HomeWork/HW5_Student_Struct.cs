using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.Utility;

namespace HomeWork
{
    public partial class HW5_Student_Struct : Form
    {
     

        public HW5_Student_Struct()
        {
            InitializeComponent();
        }
        List<Classroom> StudentList = new List<Classroom>();//定義一個List
        private bool isSaved = false; // 初始時還未儲存

        private void btn_Store_Click(object sender, EventArgs e)
        {
            try
            {
                isSaved = true;
                MessageBox.Show("已儲存");
                Classroom cl = new Classroom();
                cl.StudentName = txtbox_Name.Text;
                cl.ChScore = int.Parse(txtbox_Chinese.Text);
                cl.EnScore = int.Parse(txtbox_English.Text);
                cl.MathScore = int.Parse(txtbox_Math.Text);
                StudentList.Add(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_ShowStore_Click(object sender, EventArgs e) //顯示成績按鈕
        {
            try
            {
                bool chIsNum = int.TryParse(txtbox_Chinese.Text, out int a);
                bool enIsNum = int.TryParse(txtbox_Chinese.Text, out int b);
                bool mathIsNum = int.TryParse(txtbox_Chinese.Text, out int c);


                if (
                        txtbox_English.Text == "" || //成績格子空白
                        txtbox_Chinese.Text == "" ||
                        txtbox_Math.Text == ""
                    )

                {
                    MessageBox.Show("請輸入數字");
                    return;
                }
                else if (
                       !chIsNum || !enIsNum || mathIsNum //檢查數字範圍在0~100   
                    )

                {
                    MessageBox.Show("請輸入0~100");
                    return;
                }
                else if (
                        string.IsNullOrEmpty(txtbox_Name.Text)//檢查有填寫名字
                        )
                {
                    MessageBox.Show("請輸入你的名字");
                    return;
                }

                else if (!isSaved)
                { //有沒有先去按儲存按鈕，按了之後把isSaved變成true才會執行下面
                    MessageBox.Show("請先儲存");
                    return;
                }

                string sum =
                   "姓名 : " + txtbox_Name.Text + "\n" +
                   "國文 : " + txtbox_Chinese.Text + " 分" + "\n" +
                   "英文 : " + txtbox_English.Text + " 分" + "\n" +
                   "數學 : " + txtbox_Math.Text + " 分";
                label_SumBox.Text = sum;

                isSaved = false; //執行完更新BOX之後，將isSaved回歸初始狀態
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btn_ShowHighLow_Click(object sender, EventArgs e)
        {
            try
            {
                label_HighAndLow.Text = "";
                List<Classroom> ChHighest = StudentList.Where(x => x.ChScore == StudentList.Max(s => s.ChScore)).ToList();
                List<Classroom> EnHighest = StudentList.Where(x => x.EnScore == StudentList.Max(s => s.EnScore)).ToList();
                List<Classroom> MathHighest = StudentList.Where(x => x.MathScore == StudentList.Max(s => s.MathScore)).ToList();


                foreach (var a in ChHighest)
                {
                    label_HighAndLow.Text += $"國文最高分的學生是 {a.StudentName}，分數是{a.ChScore} \n";
                }
                foreach (var a in EnHighest)
                {
                    label_HighAndLow.Text += $"英文最高分的學生是 {a.StudentName}，分數是{a.EnScore} \n";
                }
                foreach (var a in MathHighest)
                {
                    label_HighAndLow.Text += $"數學最高分的學生是 {a.StudentName}，分數是{a.MathScore} \n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
