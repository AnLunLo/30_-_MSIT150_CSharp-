using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.HW8_Guess;

namespace HomeWork
{
    public class Utility
    {
        public class Classroom
        {
            public string StudentName { get; set; }
            public int ChScore { get; set; }
            public int EnScore { get; set; }
            public int MathScore { get; set; }
        }


        public class GuessGame
        {
            public static int MaxNum = 100;
            public static int MinNum = 1;
            

            public bool isInRange(int x) //判斷使用者的數字是否在指定範圍
            {
                if (x <= MaxNum && x >= MinNum)
                    return true;

                else
                    return false;
            }

            public void Compare(int random, int userOld,int userNew, string mess)
            {
                if (userNew == random)
                {
                    MessageBox.Show($"恭喜你猜中了!! 答案是{userNew}");
                }
                else if (userNew < MaxNum && userNew > random)
                {
                    mess = $"太大了!!\n在{MinNum}和{userNew}之間";

                }


                else if (userNew > MinNum && userNew < random)
                {
                    mess = $"太小了!!\n在{userNew}和{MaxNum}之間";
                }


            }//比較大小
            public static void RandomAnswer(out int ranNum)  //產生隨機數字
            {
                GuessNum a = new GuessNum();
                Random randomNum = new Random();
                ranNum = randomNum.Next(MinNum, MaxNum);
                
            }


         


        }

        public struct Student 
        {
            public string Name;
            public int ChScore;
            public int EnScore;
            public int MathScore;

            public static void RandomScore(out int ranNum)  //產生隨機數字
            {
                Student a = new Student();
                Random randomscore = new Random();
                ranNum = randomscore.Next(0, 101);

            }

        }

       
    }


    
}
