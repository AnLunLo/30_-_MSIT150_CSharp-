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
    public partial class HW1_Hello : Form
    {
        public HW1_Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nm = box_name.Text;
                string ennm = box_en_name.Text;
                string gen = box_gender.Text;
                string star = box_star.Text;
                MessageBox.Show("Hello, 我是 " + nm + ", \n" +
                    "英文名字是 " + ennm + ", \n" +
                    "性別是 " + gen + ", \n" +
                    "星座是 " + star + ", \n" +
                    "很高興認識你。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_SayHi_Click(object sender, EventArgs e)
        {
            string nm = box_name.Text;
            string ennm = box_en_name.Text;
            string gen = box_gender.Text;
            string star = box_star.Text;
            try
            {
                MessageBox.Show("Hi, 我是 " + nm + ", \n" +
                    "英文名字是 " + ennm + ", \n" +
                    "性別是 " + gen + ", \n" +
                    "星座是 " + star + ", \n" +
                    "很高興認識你。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
