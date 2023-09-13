using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2nd_POS.DataAccess;
using Newtonsoft.Json;

namespace _2nd_POS.POSUI
{
    public partial class WorkControl : UserControl
    {
        private Api api;

        private Employee employee;


        public WorkControl()
        {
            InitializeComponent();
            api = new Api();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if(employeeTextBox.Text == "")
            {
                return;
            }

            string employeeNo = "/branches/employee/find?employeeNo=" + employeeTextBox.Text;

            string data = await api.GetData(employeeNo);

            if (data.Contains("{\"employeeName\":null"))
            {
                employeeTextBox.Text = "";
                employeeNameLabel.Text = "-";
                attendanceInLabel.Text = "-";
                attendanceOutLabel.Text = "-";
                MessageLabel.Text = "일치하는 직원이 없습니다.";
            }
            else
            {
                employee = JsonConvert.DeserializeObject<Employee>(data);
                employeeNameLabel.Text = employee.employeeName;
                if (employee.attendanceIn == null)
                {
                    attendanceInLabel.Text = "-";
                    attendanceOutLabel.Text = "-";
                }
                else
                {
                    attendanceInLabel.Text = employee.attendanceIn;
                    attendanceOutLabel.Text = employee.attendanceOut ?? "-";
                }

            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string data;
            string url = "/branches/employee/attendance";

            if (employeeTextBox.Text == "")
            {
                return;
            }

                data = "{\"employeeNo\":\"" + employee.employeeNo + "\"}";
                
                string result = await api.post(url, data);

            MessageObj message = JsonConvert.DeserializeObject<MessageObj>(result);

            MessageLabel.Text = message.getMsg();

            button1_ClickAsync(sender, e);

        }
    }
}
