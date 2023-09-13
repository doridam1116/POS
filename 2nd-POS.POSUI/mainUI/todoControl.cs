using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2nd_POS.DataAccess;
using static System.Windows.Forms.AxHost;

namespace _2nd_POS.POSUI
{
    public partial class todoControl : UserControl
    {
        private DateTime _date = DateTime.Now;
        private Api api;
        private Todo todo;

        public todoControl()
        {
            InitializeComponent();
            todoDateLabel.Text = _date.ToString("yyyy-MM-dd");
            api = new Api();
            todo = new Todo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _date = _date.AddDays(+1);
            todoDateLabel.Text = _date.ToString("yyyy-MM-dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _date = _date.AddDays(-1);
            todoDateLabel.Text = _date.ToString("yyyy-MM-dd");
        }

        private void button6_ClickAsync(object sender, EventArgs e)
        {
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(todo);
            //string postData = await api.post("/todos/todoyn",data);
            //MessageBox.Show(postData);
        }
    }
}
