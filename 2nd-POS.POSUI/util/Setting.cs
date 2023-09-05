using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_POS.POSUI.util
{
    internal class Setting
    {
        IniFile ini;

        public Setting()
        {
            ini = new IniFile();
            ini.Load("C:\\2nd-POS\\setting.ini");
        }

        public void saveSetting(int employeeNo)
        {
            ini["Setting"]["employee"] = employeeNo;
            ini.Save("C:\\2nd-POS\\setting.ini");
        }
    }
}
