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
    public partial class HM6_Calulator : Form
    {
        public HM6_Calulator()
        {
            InitializeComponent();
        }

      


        private void btn_plus_Click(object sender, EventArgs e)
        {
            try { 
            double Num1 = Convert.ToDouble (textBox_Num1.Text);
            double Num2 = Convert.ToDouble (textBox_Num2.Text);
            double result = Num1 + Num2;
            label_AnswerBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(textBox_Num1.Text);
                double Num2 = Convert.ToDouble(textBox_Num2.Text);
                double result = Num1 - Num2;
                label_AnswerBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(textBox_Num1.Text);
                double Num2 = Convert.ToDouble(textBox_Num2.Text);
                double result = Num1 * Num2;
                label_AnswerBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(textBox_Num1.Text);
                double Num2 = Convert.ToDouble(textBox_Num2.Text);
                double result = Num1 / Num2;
                label_AnswerBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
