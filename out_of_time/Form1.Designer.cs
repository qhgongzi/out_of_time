namespace out_of_time
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_task_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_task_hour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_task_min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_task_sec = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务标题：";
            // 
            // tb_task_title
            // 
            this.tb_task_title.Location = new System.Drawing.Point(85, 10);
            this.tb_task_title.Name = "tb_task_title";
            this.tb_task_title.Size = new System.Drawing.Size(313, 25);
            this.tb_task_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "预估时间：";
            // 
            // tb_task_hour
            // 
            this.tb_task_hour.Location = new System.Drawing.Point(85, 56);
            this.tb_task_hour.Name = "tb_task_hour";
            this.tb_task_hour.Size = new System.Drawing.Size(48, 25);
            this.tb_task_hour.TabIndex = 3;
            this.tb_task_hour.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "小时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "分";
            // 
            // tb_task_min
            // 
            this.tb_task_min.Location = new System.Drawing.Point(181, 56);
            this.tb_task_min.Name = "tb_task_min";
            this.tb_task_min.Size = new System.Drawing.Size(48, 25);
            this.tb_task_min.TabIndex = 3;
            this.tb_task_min.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "秒";
            // 
            // tb_task_sec
            // 
            this.tb_task_sec.Location = new System.Drawing.Point(277, 56);
            this.tb_task_sec.Name = "tb_task_sec";
            this.tb_task_sec.Size = new System.Drawing.Size(48, 25);
            this.tb_task_sec.TabIndex = 3;
            this.tb_task_sec.Text = "0";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(85, 127);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(240, 39);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "开始计时";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 192);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_task_sec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_task_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_task_hour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_task_title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务倒计时";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_task_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_task_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_task_min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_task_sec;
        private System.Windows.Forms.Button btn_start;

    }
}

