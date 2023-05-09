using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class HW15_PicBrowser : Form
    {
        public HW15_PicBrowser()
        {
            InitializeComponent();
        }

       

        private void pictureBox_Cat_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_Cat.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_Allun_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_Allun.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_puppy_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_puppy.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_Burger_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_Burger.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_Coke_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_Coke.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_Pie_Click(object sender, EventArgs e)
        {
            try
            {
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.CenterScreen; // 設定開啟位置為螢幕中央

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; // 設定圖片縮放方式為等比例縮放
                pb.Image = pictureBox_Pie.Image; // 將點擊的 PictureBox 的圖片設定至新的 PictureBox 控制項
                pb.Dock = DockStyle.Fill; // 設定圖片控制項填滿整個視窗

                newForm.Controls.Add(pb); // 將新的 PictureBox 控制項新增至新的視窗中
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
