using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanDaoInputHelper
{
    public partial class Application : Form
    {
        public static List<string> WorkList = new List<string>();
        public static bool ExecFlag = false;
        public Application()
        {
            InitializeComponent();

            HolidayWork.InitHolidayWorkDays();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x112)
            {
                switch ((int)m.WParam)
                {
                    //禁止双击标题栏关闭窗体
                    case 0xF063:
                    case 0xF093:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止拖拽标题栏还原窗体
                    case 0xF012:
                    case 0xF010:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止双击标题栏
                    case 0xf122:
                        m.WParam = IntPtr.Zero;
                        break;


                    //允许关闭按钮
                    case 0xF060:
                        //m.WParam = IntPtr.Zero;
                        break;

                    //允许最大化按钮
                    case 0xf020:
                        m.WParam = IntPtr.Zero;
                        break;

                    //允许最小化按钮
                    case 0xf030:
                        m.WParam = IntPtr.Zero;
                        break;

                    //允许还原按钮
                    case 0xf120:
                        m.WParam = IntPtr.Zero;
                        break;

                    default:
                        m.WParam = IntPtr.Zero;
                        break;
                }
            } 
            else if (m.Msg == 0x0312)
            {
                switch ((int) m.WParam)
                {
                    case 901:
                        Console.WriteLine("按下了开始快捷键");
                        if (ExecFlag)
                        {
                            return;
                        }
                        //MessageBox.Show("任务开始");
                        doRun();
                        break;
                    case 902: 
                        Console.WriteLine("按下了终止快捷键");
                        if (!ExecFlag)
                        {
                            return;
                        }
                        ExecFlag = false;
                        //MessageBox.Show("任务终止");
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.doRun();
        }

        private void doRun()
        {
            string content = this.textBox1.Text;
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("输入内容哦");
                return;
            }
            this.richTextBox1.Clear();
            decimal count = this.numericUpDown_task_count.Value;

            DateTime startDateTime = this.dateTimePicker1.Value;
            string startDateStr = this.dateTimePicker1.Text;

            List<string> dateValues = new List<string>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("i = " + i);
                string str = startDateTime.ToString("yyyy-MM-dd");

                var day = startDateTime.DayOfWeek;

                if (day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
                {
                    if (WorkList.Contains(str))
                    {
                        // 是周末 但补班
                        this.richTextBox1.AppendText(str + " 是 " + day + "仍然加入\n");
                        dateValues.Add(str);
                        
                    }
                    // 是周末 不计入
                    this.richTextBox1.AppendText(str + " 是 " + day + "放弃加入\n");
                    i = i - 1;
                }
                else
                {
                    this.richTextBox1.AppendText(str + "加入\n");
                    dateValues.Add(str);
                }
                startDateTime = startDateTime.AddDays(1);
            }

            this.run(dateValues, content);
        }

        private void run(List<string> dateValues, string content)
        {
            ExecFlag = true;
            Thread.Sleep(1500);
            
            int timeUsed = (int) this.numericUpDown_time_used.Value;

            int timeLeft = (int) this.numericUpDown_time_left.Value;

            foreach (string dateValue in dateValues)
            {
                if (!ExecFlag)
                {
                    this.richTextBox1.AppendText("快捷键终止任务\n\n");
                    return;
                }
                Console.WriteLine("run execFlag " + ExecFlag);
                // 输入日期
                this.input(dateValue);
                // 输入内容
                this.input(content);
                // 输入耗时
                this.input(timeUsed.ToString());
                // 输入剩余
                timeLeft = timeLeft - timeUsed;
                this.input(timeLeft.ToString());

                this.richTextBox1.AppendText("=================\n");
            }
            this.Show();
        }

        private void input(string keys)
        {
            if (!ExecFlag)
            {
                this.richTextBox1.AppendText("快捷键终止任务\n\n");
                return;
            }
            Console.WriteLine("input execFlag " + ExecFlag);
            Thread.Sleep(500);
            SendKeys.Send("{TAB}");
            this.richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 输入: TAB\n");
            SendKeys.Send(keys);
            this.richTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 输入: " + keys + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HolidayWork().ShowDialog();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            SystemHotKey.RegHotKey(this.Handle, 901, SystemHotKey.KeyModifiers.Alt, Keys.F2);

            SystemHotKey.RegHotKey(this.Handle, 902, SystemHotKey.KeyModifiers.Alt, Keys.F3);
        }

        private void Application_FormClosed(object sender, FormClosedEventArgs e)
        {
            SystemHotKey.UnRegHotKey(this.Handle, 901);

            SystemHotKey.UnRegHotKey(this.Handle, 902);
        }
    }
}
