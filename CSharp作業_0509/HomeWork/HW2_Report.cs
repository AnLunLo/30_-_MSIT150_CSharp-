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
    public partial class HW2_Report : Form
    {
        public HW2_Report(string a, string b, string c, double d, double e)
        {
            InitializeComponent();

            label_ReportOriginal.Text = a;
            label_ReportYear.Text = b;
            label_ReportRate.Text = c;
            label_ReportMonth.Text = d.ToString();
            label_ReportTotal.Text = e.ToString();  

        }
       
    }
}
