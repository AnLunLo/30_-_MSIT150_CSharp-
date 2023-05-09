using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class HW13_Painting : Form
    {
        public HW13_Painting()
        {
            InitializeComponent();
        }


        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)//點擊開新檔案
        {
            try { 

            pictureBox_Main.Image = new Bitmap(800, 600);//這個picBox是用來放圖片的，new一個放圖片的格式Bitmap，並給予大小
            Graphics g = Graphics.FromImage(pictureBox_Main.Image);//使用繪圖工具Graphics，針對哪一張圖來畫，這個g就是用來處理繪畫工具
            g.Clear(Color.White); //把這個bitmap變成白色(原本是透明的)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HW13_Painting_Load(object sender, EventArgs e)// 程式開始時自動開新檔案
        {
            try
            {
                開新檔案ToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        int mouseX,mouseY; //滑鼠座標
        int BarNum;//畫筆粗細

        private void pictureBox_Main_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left) //e是滑鼠，滑鼠的左鍵按住的狀態
                {

                    Pen p = new Pen(colorDialog1.Color, BarNum);
                    Graphics g = Graphics.FromImage(pictureBox_Main.Image);
                    g.DrawLine(p, mouseX, mouseY, e.X, e.Y);
                    mouseX = e.X;
                    mouseY = e.Y;
                    pictureBox_Main.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //粗細選擇
        {
            try
            {
                BarNum = trackBar_Size.Value;
                label_ShowNum.Text = (trackBar_Size.Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e) //選擇顏色
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void 存檔ToolStripMenuItem_Click_1(object sender, EventArgs e) //存檔
        {
            try { 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.DefaultExt = ".jpg";//預設檔案類型是jpg
                    Bitmap bmp = new Bitmap(pictureBox_Main.Image);
                    bmp.Save(saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void pictureBox_Main_MouseDown(object sender, MouseEventArgs e)//紀錄當前鼠標位置
        {
          mouseX = e.X;
          mouseY = e.Y;
        }
    }
}
