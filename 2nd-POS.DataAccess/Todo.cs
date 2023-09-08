using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_POS.DataAccess
{
    internal class Todo
    {
        private String branchUuid
        {
            set { branchUuid = value; }
            get { return branchUuid; }
        }
        private String todoTime
        {
            set { todoTime = value; }
            get { return todoTime; }
        }

        private String todoTitle
        {
            set { todoTitle = value; }
            get { return todoTitle; }
        }

        private int todoYn 
        { 
            set { todoYn = value; }
            get { return todoYn; }
        }

        private int todoNo 
        {
            set { todoNo = value; }
            get { return todoNo; }
        }



    }
}
