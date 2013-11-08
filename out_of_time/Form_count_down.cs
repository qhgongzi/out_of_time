using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace out_of_time
{
    public partial class Form_count_down : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);

        int state;
        public Int64 remain_millisecond;//剩余毫秒数
        public string task_title;

        Int64 total_millsecond;

        private Form1 mainform = null;

        private Point _MouseOffset;
        private bool _IsMouseDown = false;

        public Form_count_down(Form1 main)
        {
            this.mainform = main;
            InitializeComponent();
        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x0201) //鼠标左键按下去的消息
        //    {
        //        m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
        //        m.LParam = IntPtr.Zero;//默认值
        //        m.WParam = new IntPtr(2);//鼠标放在标题栏内
        //    }
        //    base.WndProc(ref m);
        //}

        private void Form_count_down_Load(object sender, EventArgs e)
        {
            this.lb_task_title.Text = task_title;
            this.total_millsecond = remain_millisecond;

            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = 300;//Screen.PrimaryScreen.WorkingArea.Height-80;
            state = 0;
        }


        private void Form_count_down_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remain_millisecond -= timer1.Interval;
            this.setLabelColor();

            if (remain_millisecond > 0)
            {
                label1.Text = "还剩下" + this.millToString(remain_millisecond);
                lb_span_time.Text = "总耗时: " + this.millToString(total_millsecond - remain_millisecond);
            }
            else
            {
                label1.Text = "已超时" + this.millToString(remain_millisecond);
                lb_span_time.Text = "总耗时: " + this.millToString(total_millsecond - remain_millisecond);
            }
            
        }

        private string millToString(Int64 mills)
        {
            mills = Math.Abs(mills);
            Int64 hour = (mills / 1000) / 3600;
            Int64 min = ((mills / 1000) - hour * 3600) / 60;
            float mill = (float)(mills - (hour * 3600 + min * 60) * 1000) / 1000;

            string timestr = "";
            if (hour > 0)
            {
                timestr += hour.ToString() + "小时";
            }

            if (min > 0)
            {
                timestr += min.ToString() + "分";
            }

            timestr += mill.ToString("f1") + "秒";

            return timestr;
        }

        //设置文本显示颜色
        private void setLabelColor()
        {
            float percent = (float)remain_millisecond / (float)total_millsecond;
            if (percent > 0.5)
            {
                label1.ForeColor = Color.Lime;
            }
            else if (percent > 0.3)
            {
                label1.ForeColor = Color.CornflowerBlue;
            }
            else if (percent > 0.0)
            {
                label1.ForeColor = Color.NavajoWhite;
            }

            if (remain_millisecond < 0)
            {
                label1.ForeColor = Color.OrangeRed;
            }
        }

        private void Form_count_down_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _IsMouseDown = false;
            }
        }

        private void Form_count_down_MouseDown(object sender, MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            //if (e.Button == MouseButtons.Left)//按下的是鼠标左键            
            //{
            //    Capture = false;//释放鼠标，使能够手动操作                
            //    SendMessage(Handle, 0x00A1, 2, 0);//拖动窗体            
            //}  
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;

                yOffset = -e.Y;

                _MouseOffset = new Point(xOffset, yOffset);

                _IsMouseDown = true;

            }
        }

        private void Form_count_down_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_MouseOffset.X, _MouseOffset.Y);
                Location = mousePos;
            }

        }

        private void btn_suspend_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                btn_suspend.Text = "go";
                timer1.Enabled = false;
            }
            else
            {
                btn_suspend.Text = "暂停";
                timer1.Enabled = true;
            }

        }

        private void btn_task_done_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform.Show();
        }


    }
}
