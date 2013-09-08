using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace out_of_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(tb_task_hour.Text);
            int min = int.Parse(tb_task_min.Text);
            int seconds = int.Parse(tb_task_sec.Text);
            
            Form_count_down count_down = new Form_count_down(this);
            count_down.remain_millisecond = (hour*3600+min*60+seconds)*1000;
            count_down.task_title = this.tb_task_title.Text;
            count_down.Show();
            this.Hide();
        }
    }
}
