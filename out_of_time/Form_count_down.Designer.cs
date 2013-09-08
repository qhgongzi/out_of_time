namespace out_of_time
{
    partial class Form_count_down
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_count_down));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_task_title = new System.Windows.Forms.Label();
            this.btn_suspend = new System.Windows.Forms.Button();
            this.btn_task_done = new System.Windows.Forms.Button();
            this.lb_span_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lb_task_title
            // 
            this.lb_task_title.AutoSize = true;
            this.lb_task_title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb_task_title.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_task_title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_task_title.Location = new System.Drawing.Point(12, 3);
            this.lb_task_title.Name = "lb_task_title";
            this.lb_task_title.Size = new System.Drawing.Size(82, 31);
            this.lb_task_title.TabIndex = 1;
            this.lb_task_title.Text = "label2";
            // 
            // btn_suspend
            // 
            this.btn_suspend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_suspend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_suspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suspend.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_suspend.Location = new System.Drawing.Point(19, 100);
            this.btn_suspend.Name = "btn_suspend";
            this.btn_suspend.Size = new System.Drawing.Size(49, 28);
            this.btn_suspend.TabIndex = 1;
            this.btn_suspend.TabStop = false;
            this.btn_suspend.Text = "暂停";
            this.btn_suspend.UseVisualStyleBackColor = false;
            this.btn_suspend.Click += new System.EventHandler(this.btn_suspend_Click);
            // 
            // btn_task_done
            // 
            this.btn_task_done.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_task_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_task_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_task_done.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_task_done.Location = new System.Drawing.Point(74, 100);
            this.btn_task_done.Name = "btn_task_done";
            this.btn_task_done.Size = new System.Drawing.Size(47, 28);
            this.btn_task_done.TabIndex = 2;
            this.btn_task_done.TabStop = false;
            this.btn_task_done.Text = "完成";
            this.btn_task_done.UseVisualStyleBackColor = false;
            this.btn_task_done.Click += new System.EventHandler(this.btn_task_done_Click);
            // 
            // lb_span_time
            // 
            this.lb_span_time.AutoSize = true;
            this.lb_span_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_span_time.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb_span_time.Location = new System.Drawing.Point(15, 76);
            this.lb_span_time.Name = "lb_span_time";
            this.lb_span_time.Size = new System.Drawing.Size(53, 20);
            this.lb_span_time.TabIndex = 4;
            this.lb_span_time.Text = "label2";
            // 
            // Form_count_down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(327, 140);
            this.Controls.Add(this.lb_span_time);
            this.Controls.Add(this.btn_task_done);
            this.Controls.Add(this.btn_suspend);
            this.Controls.Add(this.lb_task_title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_count_down";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_count_down";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_count_down_FormClosing);
            this.Load += new System.EventHandler(this.Form_count_down_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_count_down_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_count_down_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_count_down_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_task_title;
        private System.Windows.Forms.Button btn_suspend;
        private System.Windows.Forms.Button btn_task_done;
        private System.Windows.Forms.Label lb_span_time;
    }
}