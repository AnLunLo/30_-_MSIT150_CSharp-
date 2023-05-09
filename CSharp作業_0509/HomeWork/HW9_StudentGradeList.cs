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
    public partial class HW9_StudentGradeList : Form
    {
        public HW9_StudentGradeList()
        {
            InitializeComponent();
        }

        public void Show()
        {
            foreach (Student st in student)
            {

                label_List.Text += $"  {st.Name}                " +
                    $"{st.ChScore}            " +
                    $"{st.EnScore}            " +
                    $"{st.MathScore}            " +
                    $"{(st.ChScore + st.EnScore + st.MathScore)}            " +
                    $"{(st.ChScore + st.EnScore + st.MathScore) / 3}            " +
                    $"{Math.Max((Math.Max(st.ChScore, st.EnScore)), st.MathScore)}          " +
                    $"{Math.Min((Math.Min(st.ChScore, st.EnScore)), st.MathScore)}\n";

               
            }

        }

        List <Student> student = new List<Student>();

        private void btn_Add_Click(object sender, EventArgs e)
        {

            

            btn_analysis.Enabled = true;
            Student st;
            st.Name = textBox_Name.Text;
            st.ChScore = int.Parse(textBox_Ch.Text);
            st.EnScore = int.Parse(textBox_En.Text);
            st.MathScore = int.Parse(textBox_Math.Text);
            student.Add(st);

            label_List.Text = "";

            Show();




        }
        
        private void btn_AddRandom_Click(object sender, EventArgs e)
        {
            List<Student> ran = new List<Student>();

            Student a = new Student();
            Random randomscore = new Random();
            int ranNum = randomscore.Next(0, 101);


            label_List.Text = "";


            btn_analysis.Enabled = true;
            Student st;
            st.Name = textBox_Name.Text;
            st.ChScore = int.Parse(textBox_Ch.Text);
            st.EnScore = int.Parse(textBox_En.Text);
            st.MathScore = int.Parse(textBox_Math.Text);
            student.Add(st);


        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add20Random_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
