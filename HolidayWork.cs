using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanDaoInputHelper
{
    public partial class HolidayWork : Form
    {
        public HolidayWork()
        {
            InitializeComponent();


            foreach (string date in Application.WorkList)
            {
                this.richTextBox1.AppendText(date + ",");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.richTextBox1.Text;
            if (text == null)
            {
                InitHolidayWorkDays();
                return;
            }

            string[] strs = text.Split(',');

            Application.WorkList.Clear();
            foreach (string str in strs)
            {
                Application.WorkList.Add(str);
            }

            this.Dispose();
        }

        public static void InitHolidayWorkDays()
        {
            string date = "2024-02-04,2024-04-07,2024-04-28,2024-05-11,2024-09-14,2024-09-29,2024-10-12";
            string[] strs = date.Split(',');

            Application.WorkList.Clear();
            foreach (string str in strs)
            {
                Application.WorkList.Add(str);
            }
        }
    }
}
