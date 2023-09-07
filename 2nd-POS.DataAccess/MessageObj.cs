using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_POS.DataAccess
{
    public class MessageObj
    {
        private int code;
        private string msg;

        public MessageObj(int code, string msg)
        {
            this.code = code;
            this.msg = msg;
        }

        public int getCode() { return code; } 
        public string getMsg() { return msg; }


    }
}
