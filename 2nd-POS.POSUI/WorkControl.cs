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
            string employeeNo = "/branches/employee/find?employeeNo=" + employeeTextBox.Text;

            string data = await api.GetData(employeeNo);

            employee = JsonConvert.DeserializeObject<Employee>(data);

            employeeNameLabel.Text = employee.employeeName;

            if(employee.attendanceIn == null)
            {
                attendanceInLabel.Text = "-";
                attendanceOutLabel.Text = "-";
                return;
            }

        }
    }
}
