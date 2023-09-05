using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_POS.DataAccess
{
    public class Branch
    {
        public String branchUuid;
        public String branchName;

        public int employeeNo;
        public String employeeName;

        public Branch(string branchUuid, string branchName, int employeeNo, string employeeName)
        {
            this.branchUuid = branchUuid;
            this.branchName = branchName;
            this.employeeNo = employeeNo;
            this.employeeName = employeeName;
        }
    }
}
