using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_POS.DataAccess
{
    public class POSDBA
    {
        private SqlConnection sqlcon;

        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        { 
            get { return this.sda; } 
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        { 
            get { return this.ds; }
            set { this.ds = value; }            
        }

        public POSDBA()
        {
            this.Sqlcon = new SqlConnection();
            Sqlcon.Open();
        }
    }
}
