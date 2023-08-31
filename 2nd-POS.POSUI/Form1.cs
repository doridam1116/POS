using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2nd_POS.POSUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSUI
{
    public partial class Form1 : Form
    {
        todoControl todo;
        menuControl menu;
        SalesControl sales;
        ServiceControl service;
        InventoryControl inventory;
        ReceiptControl receipt;
        public Form1()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;

            dateLabel.Text = currentDate.ToString("yyyy년 MM월 dd일");

            timer1.Tick += Timer1_Tick;
            timer1.Start();

            bookmarkLoad();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToString("HH:mm:ss");

        }

        private void bookmarkLoad()
        {
            foreach(Label bookmark in bookmarkPanel.Controls)
            {
                if(bookmark.Text == "")
                {
                    bookmark.Image = Image.FromFile("C:\\Users\\Com\\source\\repos\\2nd-POS\\2nd-POS.POSUI\\Properties\\plusBtn.png");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new menuControl();
            menu.Location = new Point(0, 0);
            menu.Visible = true;
            this.Controls.Add(menu);
            menu.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            todo = new todoControl();
            todo.Location = new Point(0, 0);
            todo.Visible = true;
            this.Controls.Add(todo);
            todo.BringToFront();
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            sales = new SalesControl();
            sales.Location = new Point(0, 0);
            sales.Visible = true;
            this.Controls.Add(sales);
            sales.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service = new ServiceControl();
            service.Location = new Point(0, 0);
            service.Visible = true;
            this.Controls.Add(service);
            service.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory = new InventoryControl();
            inventory.Location = new Point(0, 0);
            inventory.Visible = true;
            this.Controls.Add(inventory);
            inventory.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            receipt = new ReceiptControl();
            receipt.Location = new Point(0, 0);
            receipt.Visible = true;
            this.Controls.Add(receipt);
            receipt.BringToFront();
        }
    }
}
