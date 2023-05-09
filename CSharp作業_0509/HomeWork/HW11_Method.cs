using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.HW8_Guess;
using static HomeWork.Utility;

namespace HomeWork
{
    public partial class HW11_Method : Form
    {
        public HW11_Method()
        {
            InitializeComponent();
        }



        int i, j, c;

        private void btn_Swap_Click(object sender, EventArgs e) //數字交換
        {
            try { 
            int a = 5;
            int b = 8;
            MessageBox.Show($"數字a的值是:{a}，數字a的值是:{b}");
            int c = a;
            a = b;
            b = c;
            MessageBox.Show($"數字a的值是:{a}，數字a的值是:{b}");
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_tree_Click(object sender, EventArgs e)//聖誕樹
        {
            try { 
                label_Show.Text = "";
                int num;
                if (!int.TryParse(textBox_Row.Text, out num))
                {
                    MessageBox.Show("請輸入數字");
                    return;
                }
                else
                {
                    num = int.Parse(textBox_Row.Text);

                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < i + 1; j++)
                        {
                            label_Show.Text += "*";
                        }
                        label_Show.Text += "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_oneAround_Click(object sender, EventArgs e)//1圍繞
        {
            try { 
                label_Show.Text = "";
                int num;
                if (!int.TryParse(textBox_oneAround.Text, out num))
                {
                    MessageBox.Show("請輸入數字");
                    return;
                }

                else if (int.Parse(textBox_oneAround.Text) < 3)
                {
                    MessageBox.Show("請輸入大於等於3的數字");
                    return;
                }

                else
                {
                    num = int.Parse(textBox_oneAround.Text);
                    for (int i = 0; i < num; i++)//第一列
                    {
                        label_Show.Text += "1";
                    }
                    label_Show.Text += "\n";

                    for (int i = 0; i < num; i++)
                    {
                        label_Show.Text += "1"; //每一列第一個數字為1
                        for (int j = 0; j < num - 2; j++)
                        {
                            label_Show.Text += "0";
                        }
                        label_Show.Text += "1";//每一列最後一個數字為1
                        label_Show.Text += "\n";
                    }

                    for (int i = 0; i < num; i++)//最後一列
                    {
                        label_Show.Text += "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Staggered_Click(object sender, EventArgs e)//10交錯
        {
            try { 
                    label_Show.Text = "";
                int num;
                if (!int.TryParse(textBox_Staggered.Text, out num))
                {
                    MessageBox.Show("請輸入數字");
                    return;
                }

                else
                {
                    int count = 2;
                    num = int.Parse(textBox_Staggered.Text);

                    for (i = 0; i < num; i++)
                    { if (count % 2 == 0)

                        {
                            for (j = 0; j < (num); j++)
                            {
                                label_Show.Text += "1 0 ";
                            }
                            label_Show.Text += "\n";
                            count++;
                        }
                        else
                        {
                            for (j = 0; j < (num); j++)
                            {
                                label_Show.Text += "0 1 ";
                            }
                            label_Show.Text += "\n";
                            count++;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        int LotteryNum;

        private void btn_Lottery_Click(object sender, EventArgs e)//產生六個隨機樂透數字
        {
            try { 
                label_Show.Text = "";
                List<int> Lottery = new List<int>();

                Random randomNum = new Random();
                LotteryNum = randomNum.Next(1, 43);
                Lottery.Add(LotteryNum);
                label_Show.Text = $"{LotteryNum} ";

                for (int i = 0; i < 5; i++)//開始產生另外５個號碼
                {
                    int newNum = randomNum.Next(1, 43);
                    while (Lottery.Contains(newNum))
                    {
                        newNum = randomNum.Next(1, 43);
                    }
                    Lottery.Add(newNum);

                    label_Show.Text += $"{newNum} ";
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Binary_Click(object sender, EventArgs e)//二進位轉換
        {
            try { 
            label_Show.Text = "";
            int Binary;
            if (!int.TryParse(textBox_Binary.Text, out Binary))
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            Binary = int.Parse(textBox_Binary.Text);

            string result = Convert.ToString(Binary, 2);

            label_Show.Text = ($"{Binary.ToString()} 的二進位數字是 :{result}   ");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_OddEven_Click(object sender, EventArgs e) //奇數或偶數
        {
            try
            {
                label_Show.Text = "";
                int num;
                if (!int.TryParse(textBox_OddOrEven.Text, out num))
                {
                    MessageBox.Show("請輸入數字");
                    return;
                }

                num = int.Parse(textBox_OddOrEven.Text);
                if (num % 2 == 0)
                {
                    label_Show.Text = "你的數字是偶數";
                }
                else if (num % 2 == 1)
                {
                    label_Show.Text = "你的數字是奇數";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }




        private void btn_For_Click(object sender, EventArgs e)
        {
            try {
                label_Show.Text = "";
                bool isFirstNum = int.TryParse(textBox_StartNum.Text, out int a);
                bool isLastNum = int.TryParse(textBox_EndNum.Text, out int b);
                bool isInterval = int.TryParse(textBox_Intereval.Text, out int c);
                if (isFirstNum || isLastNum || isInterval)
                {
                    int result = a;
                    for (int i = 0; i < (b - a) / c; i++)
                    {
                        result += a + ((i + 1) * c);
                    }

                    label_Show.Text = $"使用for迴圈，結果是{result.ToString()}";
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Do_Click(object sender, EventArgs e)
        {
            try {
                label_Show.Text = "";
                bool isFirstNum = int.TryParse(textBox_StartNum.Text, out int a);
                bool isLastNum = int.TryParse(textBox_EndNum.Text, out int b);
                bool isInterval = int.TryParse(textBox_Intereval.Text, out int c);
                if (isFirstNum || isLastNum || isInterval)
                {

                    int result = a;
                    int count = 0;
                    do
                    {
                        result += a + ((count + 1) * c);
                        count++;
                    }
                    while (count < (b - a) / c);

                    label_Show.Text = $"使用do迴圈，結果是{result.ToString()}";
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            try
            {
                label_Show.Text = "";
                bool isFirstNum = int.TryParse(textBox_StartNum.Text, out int a);
                bool isLastNum = int.TryParse(textBox_EndNum.Text, out int b);
                bool isInterval = int.TryParse(textBox_Intereval.Text, out int c);
                if (isFirstNum || isLastNum || isInterval)
                {

                    int result = a;
                    int count = 0;
                    while (count < (b - a) / c)
                    {
                        result += a + ((count + 1) * c);
                        count++;
                    }

                    label_Show.Text = $"使用while迴圈，結果是{result.ToString()}";
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        int ArrNum;
        private void btn_MaxAndMin_Click(object sender, EventArgs e)
        {
            try {
                label_Show.Text = "";
                List<int> Arr = new List<int>();
                Random randomNum = new Random();
                ArrNum = randomNum.Next(1, 1000);
                Arr.Add(ArrNum);//存入Arr

                label_Show.Text = $"{ArrNum} "; //顯示第一個數字

                for (int i = 0; i < 9; i++)//開始產生另外9個號碼
                {
                    int newNum = randomNum.Next(1, 1000);
                    while (Arr.Contains(newNum))
                    {
                        newNum = randomNum.Next(1, 1000);
                    }
                    Arr.Add(newNum);
                    label_Show.Text += $" {newNum}, ";
                }
                int max = Arr.Max();
                int min = Arr.Min();
                int sum = Arr.Sum();
                int odd = 0;
                int even = 0;
                foreach (int x in Arr)
                {
                    if (x % 2 == 0)
                    { even++; }
                    else
                    { odd++; }
                }

                label_Show.Text += $"最大數字是{max}，最小的數字是{min}，總和是{sum}\n奇數有 {odd} 個，偶數有 {even} 個";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }//陣列各種取值



        private void button1_Click(object sender, EventArgs e)
        {
            try {
                List<string> names = new List<string>()
                    {
                        "Alice", "Bob", "Cathy", "David", "Erica", "Frank",
                        "George", "Helen", "Ivan", "Julia", "Kathy", "Lucas"
                    };

                int count = names.Count(name => name.Contains("c") || name.Contains("C"));

                label_Show.Text = ($"人名： Alice, Bob, Cathy,David, Erica, Frank, George, Helen, Ivan, Julia, Kathy, " +
                    $"Lucas\n名字包含 c 或者 C 的有 {count}個");

            }
        catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void btn_ArrName_Click(object sender, EventArgs e)
        {
            try {
                List<string> names = new List<string>()
                    {
                        "Alice", "Bob", "Cathy", "David", "Erica", "Frank",
                        "George", "Helen", "Ivan", "Julia", "Kathy", "Lucas","MotherFuker"
                    };

                string longestName = names.OrderByDescending(n => n.Length).FirstOrDefault();
                label_Show.Text = $"人名： Alice, Bob, Cathy,David, Erica, Frank, George, Helen, Ivan, Julia, Kathy," +
                    $" Lucas, MotherFuker\n名字最長的人是 {longestName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_99_Click(object sender, EventArgs e) //九九乘法表
        {
            try {
                label_Show.Text = "九九乘法表\n";

                for (i = 2; i < 10; i++)
                {
                    for (j = 1; j < 10; j++)
                    {
                        c = i * j;
                        string result = $"{i} x {j} ={(c < 10 ? " " : "")}{c} | ";
                        label_Show.Text += result;
                    }

                    label_Show.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            label_Show.Text = "";
        }//全部清除
    }
}
