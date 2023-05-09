using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeWork
{


    public partial class HW2_Loan : Form
    {
        double ReportTotal = 0;
        double ReportTotalM = 0;
        double userTotal;
        double userTotalM;
 
        static void Calculate
            (double Original,
            double Rate, 
            double Year, 
            int First,
            out double Total,
            out double TotalM) //計算數字方法
        {
            TotalM = Math.Round((Original-First) / ((1 - Math.Pow((1 + (Rate / 1200)), (-Year * 12))) / (Rate / 1200))); //原始月付款金額
            Total = TotalM *12 * Year; //新月還款金額四捨五入
            double NewMonthRound = TotalM;
            double NewTotalRound = Math.Round(Total);
        }

       
        public HW2_Loan()
        {
            InitializeComponent();
        }

       
        private void CheckEmpty()
        {

            if (string.IsNullOrEmpty(box_LoanTotal.Text) ||
                        string.IsNullOrEmpty(box_year.Text) ||
                        string.IsNullOrEmpty(box_rate.Text) ||
                        string.IsNullOrEmpty(box_first.Text) 
                        )
                   
            {
                MessageBox.Show("請填入數字");
                return;
            }
            //任一個格子未填的話則執行後面
        }//確認輸入格不為空白

        double ii = 0;
        private void CheckNum()
        {
            bool isNum = double.TryParse(box_LoanTotal.Text,out ii);
            if (!isNum) 
            {
                MessageBox.Show("不要亂輸入");
                return;

            }
        }



        private void btn_total_Click(object sender, EventArgs e)//總額按鈕
        {
            try
            {
                CheckEmpty();
                CheckNum();


                double userOriginal = Convert.ToInt32(box_LoanTotal.Text);
                double userYear = Convert.ToInt32(box_year.Text);
                double userRate = Convert.ToInt32(box_rate.Text);
                int userFirst = Convert.ToInt32(box_first.Text);

                Calculate(userOriginal, userYear, userRate, userFirst, out userTotal, out userTotalM);
                string result = userTotal.ToString();
                MessageBox.Show("總付款額: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btm_ppm_Click_1(object sender, EventArgs e) //月付按鈕
        {
            try
            {
                CheckEmpty();

                double userOriginal = Convert.ToInt32(box_LoanTotal.Text);
                double userYear = Convert.ToInt32(box_year.Text);
                double userRate = Convert.ToInt32(box_rate.Text);
                int userFirst = Convert.ToInt32(box_first.Text);

                Calculate(userOriginal, userYear, userRate, userFirst, out userTotal, out userTotalM);
                string result = userTotalM.ToString();
                MessageBox.Show("月付額: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                ReportCalculate();
                HW2_Report report = new HW2_Report(box_LoanTotal.Text, box_year.Text, box_rate.Text, ReportTotalM, ReportTotal);
                report.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } //總表按鈕

        private void ReportCalculate() //總表用計算
        {
            try
            {
                CheckEmpty();

                double userOriginal = Convert.ToInt32(box_LoanTotal.Text);
                double userYear = Convert.ToInt32(box_year.Text);
                double userRate = Convert.ToInt32(box_rate.Text);
                int userFirst = Convert.ToInt32(box_first.Text);

                Calculate(userOriginal, userYear, userRate, userFirst, out userTotal, out userTotalM);

                ReportTotalM = userTotalM;
                ReportTotal = userTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        
    }

}
