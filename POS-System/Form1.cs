using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS_System
{
    public partial class Form1 : Form
    {

        private readonly HttpClient _httpClient;

        IniFile ini = new IniFile();
        int _employeeNo = 0;

        public Form1()
        {
            InitializeComponent();

            ini.Load("C:\\2nd-POS\\setting.ini");
            uuidTextBox.Text = ini["Setting"]["uuid"].ToString();
            numberTextBox.Text = ini["Setting"]["employee"].ToString();
            showMsg.ForeColor = Color.Red;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:9800"); // API 엔드포인트 URL로 설정
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void settingSaveBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                ini["Setting"]["uuid"] = uuidTextBox.Text;
                ini["Setting"]["employee"] = numberTextBox.Text;
                ini.Save("C:\\2nd-POS\\setting.ini");

                Task task = post();
                await task;

                showMsg.Text = "저장이 완료되었습니다.";
                _employeeNo++;

                Delay(1500);
                showMsg.Text = "";
            }
            catch (Exception ex)
            {
                showMsg.Text = ex.Message;
                return;
            }
        }

        private async Task post()
        {
            try
            {
                string postData = "{\"branchUuid\":\"" + uuidTextBox.Text + "\",\"employeeNo\":\"" + numberTextBox.Text + "\"}";
                HttpResponseMessage response = await _httpClient.PostAsync("/branches", new StringContent(postData, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    // 여기서 data를 파싱하고 원하는 방식으로 처리합니다.
                    showMsg.Text = data;
                }
                else
                {
                    throw new Exception("API 요청 실패 코드: " + response.StatusCode + "실패 사유 : " + response.Content.ReadAsStringAsync().Result.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("에러: " + ex.Message);
            }
        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            if (_employeeNo == 0)
            {
                showMsg.Text = "검증 후 시작해주세요.";
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
