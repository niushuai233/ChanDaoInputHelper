
namespace ChanDaoInputHelper
{
    partial class Application
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_task_count = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_time_left = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_time_used = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_task_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time_used)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始任务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "MES功能开发";
            // 
            // numericUpDown_task_count
            // 
            this.numericUpDown_task_count.Location = new System.Drawing.Point(211, 90);
            this.numericUpDown_task_count.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_task_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_task_count.Name = "numericUpDown_task_count";
            this.numericUpDown_task_count.Size = new System.Drawing.Size(60, 21);
            this.numericUpDown_task_count.TabIndex = 3;
            this.numericUpDown_task_count.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_time_left
            // 
            this.numericUpDown_time_left.Location = new System.Drawing.Point(36, 90);
            this.numericUpDown_time_left.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_time_left.Name = "numericUpDown_time_left";
            this.numericUpDown_time_left.Size = new System.Drawing.Size(68, 21);
            this.numericUpDown_time_left.TabIndex = 3;
            this.numericUpDown_time_left.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 273);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown_time_used
            // 
            this.numericUpDown_time_used.Location = new System.Drawing.Point(123, 90);
            this.numericUpDown_time_used.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_time_used.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_time_used.Name = "numericUpDown_time_used";
            this.numericUpDown_time_used.Size = new System.Drawing.Size(68, 21);
            this.numericUpDown_time_used.TabIndex = 3;
            this.numericUpDown_time_used.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "设置补班日期";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown_time_used);
            this.Controls.Add(this.numericUpDown_time_left);
            this.Controls.Add(this.numericUpDown_task_count);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "禅道工时录入工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_FormClosed);
            this.Load += new System.EventHandler(this.Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_task_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time_used)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_task_count;
        private System.Windows.Forms.NumericUpDown numericUpDown_time_left;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_time_used;
        private System.Windows.Forms.Button button2;
    }
}

