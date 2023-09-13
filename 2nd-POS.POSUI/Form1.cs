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
using _2nd_POS.POSUI.inventory;
using _2nd_POS.POSUI.service;
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
        PriceReceiptControl receipt;
        WorkControl work;
        ChangeWorkControl change;
        CashBoxControl cashBoxControl;
        DisposeControl dispose;
        IncomeControl income;
        LogisAcceptControl logisAccept;
        LogisConfirmControl logisConfirm;
        MissStockRegistercontrol misstockRegister;
        StockControl stockRegister;
        LottoControl lotto;
        SportsToToControl sportToTo;
        TmoneyControl tmoney;
        TrafficCardControl trafficCard;

        IniFile ini;


        Dictionary<string, Control> controlDictionary = new Dictionary<string, Control>();



        public Form1()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;

            dateLabel.Text = currentDate.ToString("yyyy년 MM월 dd일");

            timer1.Tick += Timer1_Tick;
            timer1.Start();

            ini = new IniFile();
            ini.Load("C:\\2nd-POS\\setting.ini");


            workerName.Text = ini["Setting"]["employeeName"].ToString();
            branchName.Text = ini["Setting"]["branchName"].ToString();

            menu = new menuControl();
            BookMarkInit();
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
                bookmark.Tag = ini["BookMarker"][bookmark.TabIndex.ToString()].ToString();

                if (bookmark.Tag.ToString() == "")
                {
                    bookmark.Image = _2nd_POS.POSUI.Properties.Resources.plusBtn;
                    continue;
                }
                
                bookmark.Text = controlDictionary[bookmark.Tag.ToString()].Controls.Find("label1",true).FirstOrDefault().Text;
                bookmark.BorderStyle = BorderStyle.FixedSingle;

            }
        }

        private void BookmarkInit(object sender, EventArgs e)
        {
                
        }


        private void button5_Click(object sender, EventArgs e)
        {
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
            receipt = new PriceReceiptControl();
            receipt.Location = new Point(0, 0);
            receipt.Visible = true;
            this.Controls.Add(receipt);
            receipt.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            work = new WorkControl();
            work.Location = new Point(0, 0);
            work.Visible = true;
            this.Controls.Add(work);
            work.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change = new ChangeWorkControl();
            change.Location = new Point(0, 0);
            change.Visible = true;
            this.Controls.Add(change);
            change.BringToFront();
        }

        private void bookmark1_Click(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark0.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();
        }

        private void bookmark1_Click_1(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark1.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();

        }

        private void bookmark2_Click(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark2.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();

        }

        private void bookmark3_Click(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark3.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();

        }

        private void bookmark4_Click(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark4.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();

        }

        private void bookmark5_Click(object sender, EventArgs e)
        {
            Control c = controlDictionary[bookmark5.Tag.ToString()];
            c.Location = new Point(0, 0);
            c.Visible = true;
            this.Controls.Add(c);
            c.BringToFront();

        }

        private void BookMarkInit()
        {

            controlDictionary["cashBoxControl"] = new CashBoxControl();
            controlDictionary["dispose"] = new DisposeControl();
            controlDictionary["income"] = new IncomeControl();
            controlDictionary["logisAccept"] = new LogisAcceptControl();
            controlDictionary["logisConfirm"] = new LogisConfirmControl();
            controlDictionary["misstockRegister"] = new MissStockRegistercontrol();
            controlDictionary["stockRegister"] = new StockControl();
            controlDictionary["lotto"] = new LottoControl();
            controlDictionary["sportToTo"] = new SportsToToControl();
            controlDictionary["tmoney"] = new TmoneyControl();
            controlDictionary["trafficCard"] = new TrafficCardControl();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
