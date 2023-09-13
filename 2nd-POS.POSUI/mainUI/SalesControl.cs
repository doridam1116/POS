using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using _2nd_POS.DataAccess;

namespace _2nd_POS.POSUI
{
    public partial class SalesControl : UserControl
    {
        private POSDBA _POSDBA;
        private int tabIndex = 0;
        private int y = 11;

        public SalesControl()
        {
            InitializeComponent();
            _POSDBA = new POSDBA();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalesControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void dbConnection(string sql, SqlConnection sqlcon)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sql, sqlcon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Panel productPanel = new Panel();
                        productPanel.Location = new Point(16, y);
                        productPanel.Size = new Size(680, 91);
                        productPanel.BackColor = Color.White;
                        panel1.Controls.Add(productPanel);

                        while (reader.Read())
                        {

                            Label label = new Label();

                            label.Tag = reader.GetSqlInt64(0);
                            label.Text = reader.GetString(1);
                            productPanel.Controls.Add(label);
                            label.Location = new Point(30, 40);


                            foreach (Panel product in panel1.Controls)
                            {
                                if (product.Controls[0].Tag.ToString() == label.Tag.ToString())
                                {
                                    Label countLabel = new Label();
                                    countLabel.Text = (int.Parse(countLabel.Text) + 1).ToString();
                                    countLabel.Location = new Point(150, 40);
                                    product.Controls.Add(countLabel);
                                }
                            }

                        }
                    }
                }

                y += 97;
                tabIndex++;
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT  * FROM PRODUCT_TBL WHERE BARCODE = 8801048101023";
            dbConnection(sql,_POSDBA.Sqlcon);
        }
    }
}
