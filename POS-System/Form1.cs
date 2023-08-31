using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2nd_POS;


namespace POS_System
{
    public partial class Form1 : Form
    {
        
        IniFile ini = new IniFile();
        int _employeeNo = 0;

        public Form1()
        {
            InitializeComponent();

            ini.Load("C:\\2nd-POS\\setting.ini");
            typeTextBox.Text = ini["Setting"]["type"].ToString();
            uuidTextBox.Text = ini["Setting"]["uuid"].ToString();
            numberTextBox.Text = ini["Setting"]["employee"].ToString();
            showMsg.ForeColor = Color.Red;

        }

        private void settingSaveBtn_Click(object sender, EventArgs e)
        {
            ini["Setting"]["type"] = typeTextBox.Text;
            ini["Setting"]["uuid"] = uuidTextBox.Text;
            ini["Setting"]["employee"] = numberTextBox.Text;
            ini.Save("C:\\2nd-POS\\setting.ini");


            showMsg.Text = "저장이 완료되었습니다.";
            _employeeNo++;

            Delay(1500);
            showMsg.Text = "";
        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            if(_employeeNo == 0)
            {
                showMsg.Text = "저장 후 시작해주세요.";
                return;
            }
            this.Visible = false;

            // 현재 연결된 모니터들 가져오기
            Screen[] screens = Screen.AllScreens;

            // 첫 번째 폼을 첫 번째 모니터에 배치하고 최대화
            if (screens.Length > 0)
            {
                POSUI.Form1 form1 = new POSUI.Form1();
                form1.StartPosition = FormStartPosition.Manual;
                form1.Location = screens[0].WorkingArea.Location;
                form1.WindowState = FormWindowState.Maximized;
                form1.Show();
            }

            // 두 번째 폼을 두 번째 모니터에 배치하고 최대화
            if (screens.Length > 1)
            {
                POSUI.Form2 form2 = new POSUI.Form2();
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = screens[1].WorkingArea.Location;
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
            }

    }


        // 딜레이 메서드
        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

    }
}
