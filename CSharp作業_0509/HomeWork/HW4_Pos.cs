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
    public partial class HW4_Pos : Form
    {

        public int BurgAmount = 0;
        public int ColaAmount = 0;
        public int IceAmount = 0;
        public int PieAmount = 0;
        public int TotalPrice = 0;


        public HW4_Pos()
        {
            InitializeComponent();
        }

      

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("總金額 : NT " + TotalPrice, "確認付款");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_CreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("總金額 : NT " + TotalPrice + "\n" + "折扣後金額 : NT " + Math.Round(TotalPrice * 0.9), "確認付款");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Erase_Click(object sender, EventArgs e)
        {

            BurgAmount *= 0;
            ColaAmount *= 0;   
            IceAmount *= 0;
            PieAmount *= 0;
            CheckEmpty();
            UpdatePriceBox();
        }

        private void UpdatePriceBox()
        {
            int Price = BurgAmount * 120 +
                    ColaAmount * 35 +
                    IceAmount * 20 +
                    PieAmount * 40;
            string result = "NT $ "+ Price;
            Box_TotalPrice.Text = result;
            TotalPrice = Price;
        }


        private void btn_HambAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BurgAmount++;
                CheckEmpty();
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_HambReduce_Click(object sender, EventArgs e)
        {
            try
            {
                if (BurgAmount < 1)
                    return;
                else
                {
                    BurgAmount--;
                    CheckEmpty();
                }
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ColaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ColaAmount++;
                CheckEmpty();
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ColaReduce_Click(object sender, EventArgs e)
        {
            try
            {
                if (ColaAmount < 1)
                    return;
                else
                {
                    ColaAmount--;
                    CheckEmpty();
                }
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_IceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IceAmount++;
                CheckEmpty();
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void btn_IceReduce_Click(object sender, EventArgs e)
        {
            try
            {
                if (IceAmount < 1)
                    return;
                else
                {
                    IceAmount--;
                    CheckEmpty();
                }
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_PieAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PieAmount++;
                CheckEmpty();
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void btn_PieReduce_Click(object sender, EventArgs e)
        {
            try
            {
                if (PieAmount < 1)
                    return;
                else
                {
                    PieAmount--;
                    CheckEmpty();
                }
                UpdatePriceBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void CheckEmpty()
        {
            try
            {
                string result = "";

                if (BurgAmount != 0)
                {
                    result +=
                    "漢堡 Hamburger x" + BurgAmount + ",共NT$ " + 120 * BurgAmount + "元" + "\n";
                }
                if (ColaAmount != 0)
                {
                    result +=
                    "可樂 Cola x" + ColaAmount + ",共NT$ " + 35 * ColaAmount + "元" + "\n";
                }
                if (IceAmount != 0)
                {
                    result +=
                    "冰淇淋 Ice Cream x" + IceAmount + ",共NT$ " + 20 * IceAmount + "元" + "\n";
                }
                if (PieAmount != 0)
                {
                    result +=
                    "蘋果派 Apple Pie x" + PieAmount + ",共NT$ " + 40 * PieAmount + "元" + "\n";
                }

                if (BurgAmount == 0 && ColaAmount == 0 && IceAmount == 0 && PieAmount == 0)
                {
                    result = "尚未點餐";
                }

                label_ListBox.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }



    }
    


