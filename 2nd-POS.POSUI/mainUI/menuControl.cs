using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_POS.POSUI
{
    public partial class menuControl : UserControl
    {
        private LottoControl lotto;
        private LogisAccept logisAccept;
        private LogisReceive logisReceive;
        private SportsToTo sportsToTo;

        public menuControl()
        {
            InitializeComponent();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
            this.Dispose();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lotto = new LottoControl();
            lotto.Location = new Point(0, 0);
            this.Controls.Add(lotto);
            lotto.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logisAccept = new LogisAccept();
            logisAccept.Location = new Point(0, 0);
            this.Controls.Add(logisAccept);
            logisAccept.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            logisReceive = new LogisReceive();
            logisReceive.Location = new Point(0, 0);
            this.Controls.Add(logisReceive);
            logisReceive.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sportsToTo = new SportsToTo();
            sportsToTo.Location = new Point(0, 0);
            this.Controls.Add(sportsToTo);
            sportsToTo.BringToFront();
        }
    }
}
