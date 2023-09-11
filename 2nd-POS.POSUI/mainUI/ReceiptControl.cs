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
    public partial class PriceReceiptControl : UserControl
    {
        public PriceReceiptControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("asd");
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
