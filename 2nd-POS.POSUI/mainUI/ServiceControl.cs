using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2nd_POS.POSUI.service;

namespace _2nd_POS.POSUI
{
    public partial class ServiceControl : UserControl
    {
        private LottoControl lotto;
        private SportsToToControl sportsToTo;
        private LogisAcceptControl logisAccept;
        private LogisReceiveControl logisReceive;
        private TrafficCardControl trafficCard;
        private TmoneyControl tmoney;

        public ServiceControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lotto = new LottoControl();
            lotto.Location = new Point(0, 0);
            this.Controls.Add(lotto);
            lotto.BringToFront();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sportsToTo = new SportsToToControl();
            sportsToTo.Location = new Point(0,0);
            this.Controls.Add(sportsToTo);
            sportsToTo.BringToFront();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            logisAccept = new LogisAcceptControl();
            logisAccept.Location = new Point(0, 0);
            this.Controls.Add(logisAccept);
            logisAccept.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            logisReceive = new LogisReceiveControl();
            logisReceive.Location = new Point(0, 0);
            this.Controls.Add(logisReceive);
            logisReceive.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trafficCard = new TrafficCardControl();
            trafficCard.Location = new Point(0, 0);
            this.Controls.Add(trafficCard);
            trafficCard.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tmoney = new TmoneyControl();
            tmoney.Location = new Point(0, 0);
            this.Controls.Add(tmoney);
            tmoney.BringToFront();
        }
    }
}
