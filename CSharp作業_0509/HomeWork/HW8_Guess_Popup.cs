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
    public partial class HW8_Guess_Popup : Form
    {
        public HW8_Guess_Popup(HW8_Guess ParentForm)//讓這邊輸入的數字可以傳送到主視窗
        {
            InitializeComponent();
            this.Tag = ParentForm;
        }

        
        int max = GuessGame.MaxNum;
        int min = GuessGame.MinNum;
        bool isSecondRound = false ;//進入第二輪遊戲的判定

        private void btn_Enter_Click(object sender, EventArgs e)//玩家輸入數字後，按下按鈕
        {

            try
            {
                bool isNum;
                int a;
                double b;
                isNum = int.TryParse(textBox_Guess.Text, out a) && double.TryParse(textBox_Guess.Text, out b);
                if (!isNum)
                {
                    MessageBox.Show("請輸入數字 / 整數");
                    return;
                }
                else
                {
                    int thisNewNum = int.Parse(textBox_Guess.Text);

                    GuessGame guessGame = new GuessGame();
                    if (!guessGame.isInRange(thisNewNum)) //如果輸入的數字不在指定範圍中間
                    {
                        MessageBox.Show("請輸入1~100的數字");
                        return;
                    }


                    else if (thisNewNum == HW8_Guess.ranNum)//主要判斷開始
                    {
                        MessageBox.Show($"恭喜猜中了! 答案是 {thisNewNum}");//猜中
                        ((HW8_Guess)this.Tag).userNum = " 重新開始遊戲 ";
                        this.Close();
                        return;
                    } //猜中，遊戲結束



                    else if (!isSecondRound)
                    {
                        if (thisNewNum < HW8_Guess.ranNum)  //狀況A
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太小了，答案在 {thisNewNum} 跟 {GuessGame.MaxNum} 之間 ";
                            min = thisNewNum;
                            isSecondRound = true;

                        }


                        else if (thisNewNum > HW8_Guess.ranNum) //狀況B
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太大了，答案在 {GuessGame.MinNum} 跟 {thisNewNum} 之間";
                            max = thisNewNum;
                            isSecondRound = true;
                        }
                    }

                    else
                    {
                        if (int.Parse(textBox_Guess.Text) <= min)
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太小了，答案在 {thisNewNum} 跟 {max} 之間 ";
                        }
                        else if (int.Parse(textBox_Guess.Text) >= max)
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太大了，答案在 {min} 跟 {thisNewNum} 之間";
                        }
                        else if (int.Parse(textBox_Guess.Text) < HW8_Guess.ranNum)
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太小了，答案在 {int.Parse(textBox_Guess.Text)} 跟 {max} 之間 ";
                            min = thisNewNum;
                        }
                        else if (int.Parse(textBox_Guess.Text) > HW8_Guess.ranNum)
                        {
                            ((HW8_Guess)this.Tag).userNum = $"太大了，答案在 {min} 跟 {int.Parse(textBox_Guess.Text)} 之間 ";
                            max = thisNewNum;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ((HW8_Guess)this.Tag).userNum = " 重新開始遊戲 ";
            this.Close();
        }
    }   
}
