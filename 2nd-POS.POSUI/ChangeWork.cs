using System;
using System.Linq;
using System.Windows.Forms;
using _2nd_POS.DataAccess;
using _2nd_POS.POSUI.util;
using Newtonsoft.Json;

namespace _2nd_POS.POSUI
{
    public partial class ChangeWorkControl : UserControl
    {
        private _2nd_POS.DataAccess.Api api;

        private Branch branch;

        private Setting setting;

        public ChangeWorkControl()
        {
            InitializeComponent();
            api = new DataAccess.Api();
            setting = new Setting();
        }


        private  void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string getData = "/branches/employee/change?employeeNo=" + textBox1.Text;

            string data = await api.GetData(getData);

            branch = JsonConvert.DeserializeObject<Branch>(data);

            label6.Text = branch.employeeName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(branch == null)
            {
                MessageBox.Show("조회 후 눌러주세요.");
                return;
            }

            setting.saveSetting(branch.employeeNo);

            Control workName = Parent.Controls.Find("workerName", true).FirstOrDefault();

            workName.Text = branch.employeeName;

            this.Visible = false;
        }
    }
}
