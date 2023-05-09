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
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void btn_ToHello_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HW1_Hello hello = new HW1_Hello() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(hello);

                hello.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HW2_Loan loan = new HW2_Loan() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(loan);
                loan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guess(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HW8_Guess guess = new HW8_Guess() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(guess);
                guess.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HW4_Pos post = new HW4_Pos() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HM6_Calulator post = new HM6_Calulator() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_StudentStruct_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();

                HW5_Student_Struct post = new HW5_Student_Struct() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW10_ScreenProtect post = new HW10_ScreenProtect()/* { TopLevel = false, TopMost = true }*/;
                //panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_OXGame_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW7_OX_Game post = new HW7_OX_Game() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Method_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW11_Method post = new HW11_Method() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Painter_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW13_Painting post = new HW13_Painting() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_CountDown_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW14_Alarm post = new HW14_Alarm() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW15_PicBrowser post = new HW15_PicBrowser() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Main.Controls.Clear();
                HW12_Note post = new HW12_Note() { TopLevel = false, TopMost = true };
                panel_Main.Controls.Add(post);
                post.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
