using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Media;
using System.IO;


namespace HomeWork
{
    public partial class HW14_Alarm : Form
    {
        public HW14_Alarm()
        {
            InitializeComponent();

        }



        private void timer_Time(object sender, EventArgs e)
        {
            try
            {
                label_NowTime.Text = DateTime.Now.ToString($"HH : mm : ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HW14_Alarm_Load(object sender, EventArgs e)
        {
            try
            {
                timer_showTime.Enabled = true;
                timer_showTime.Interval = 500;
                timer_showTime.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int hr, min, sec;

 

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox_Hr.Text = null;
                comboBox_Min.Text = null;
                comboBox_Sec.Text = null;
                btn_Reset.Enabled = false;
                checkBox_SetAlarm.Enabled = true;
                checkBox_SetAlarm.Checked = false;
                timer_CountDown.Enabled = false;
                comboBox_Hr.Enabled = true;
                comboBox_Min.Enabled = true;
                comboBox_Sec.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void timer_CountDown_Tick(object sender, EventArgs e)
        {
            try
            {

                if (sec == 1)
                {

                    if (hr != 0 && min != 0)
                    {
                        sec += 58;
                        min--;

                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }

                    else if (hr == 0 && min != 0)
                    {
                        min--;
                        sec += 58;
                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }
                    else if (hr != 0 && min == 0)
                    {
                        sec += 58;
                        min += 59;
                        hr--;
                        comboBox_Hr.Text = hr.ToString();
                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }

                    else if (hr == 0 && min == 0)
                    {
                        sec = 0;
                        SoundPlayer player = new SoundPlayer(@"C:\git\CSharp作業_0509\sound\GMS.wav"); //to do 放入音檔路徑
                        player.Play();
                        comboBox_Sec.Text = sec.ToString();
                        checkBox_SetAlarm.Enabled = true;
                        checkBox_SetAlarm.Checked = false;
                        timer_CountDown.Enabled = false;
                        comboBox_Hr.Enabled = true;
                        comboBox_Min.Enabled = true;
                        comboBox_Sec.Enabled = true;
                    }
                }
                if (sec == 0)
                {

                    if (hr != 0 && min != 0)
                    {
                        sec += 59;
                        min--;

                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }

                    else if (hr == 0 && min != 0)
                    {
                        min--;
                        sec += 59;
                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }
                    else if (hr != 0 && min == 0)
                    {
                        sec += 59;
                        min += 59;
                        hr--;
                        comboBox_Hr.Text = hr.ToString();
                        comboBox_Min.Text = min.ToString();
                        comboBox_Sec.Text = sec.ToString();
                    }

                    else if (hr == 0 && min == 0 && sec == 1)
                    {
                        //sec = 0;
                        SoundPlayer player = new SoundPlayer(@"/sound/GMS.wav"); //to do 放入音檔路徑
                        player.Play();
                        comboBox_Sec.Text = sec.ToString();
                        checkBox_SetAlarm.Enabled = true;
                        checkBox_SetAlarm.Checked = false;
                        timer_CountDown.Enabled = false;
                        comboBox_Hr.Enabled = true;
                        comboBox_Min.Enabled = true;
                        comboBox_Sec.Enabled = true;
                    }
                }


                else
                {
                    sec--;
                    comboBox_Sec.Text = sec.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void checkBox_SetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_SetAlarm.Checked == true)
                {

                    if (!int.TryParse(comboBox_Hr.Text, out hr) || !int.TryParse(comboBox_Min.Text, out min) || !int.TryParse(comboBox_Sec.Text, out sec))
                    {
                        MessageBox.Show("請輸入數字");
                        checkBox_SetAlarm.Checked = false;

                    }
                    else if (hr < 0 || hr > 12)
                    {
                        MessageBox.Show("小時欄位 只能請輸入 0~12 的數字");
                        checkBox_SetAlarm.Checked = false;

                    }

                    else if (min > 59 || min < 0)
                    {
                        MessageBox.Show("分鐘欄位 請輸入 0 ~59 數字");
                        checkBox_SetAlarm.Checked = false;

                    }
                    else if (sec > 59 || sec < 0)
                    {
                        MessageBox.Show("秒欄位 輸入 0 ~59 數字");
                        checkBox_SetAlarm.Checked = false;

                    }

                    else
                    {
                        timer_CountDown.Enabled = true;
                        timer_CountDown.Interval = 1000;
                        timer_CountDown.Start();
                        btn_Reset.Enabled = true;
                        checkBox_SetAlarm.Enabled = false;
                        comboBox_Hr.Enabled = false;
                        comboBox_Min.Enabled = false;
                        comboBox_Sec.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
