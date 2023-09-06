using System;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _2nd_POS.DataAccess
{
    public class Api
    {
        private HttpClient _httpClient;

        public Api()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:9800"); // API 엔드포인트 URL로 설정
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<string> post(string url, string postData)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync("/branches"+url, new StringContent(postData, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();


                    return data;
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



        public async Task<string> GetData(string sqlData)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(sqlData);
                if (response.IsSuccessStatusCode)
                {

                    string data = await response.Content.ReadAsStringAsync();
                       
                    return data;
                }
                else
                {
                    throw new Exception("API 요청 실패 코드: " + response.StatusCode + "실패 사유 : " + response.Content.ReadAsStringAsync().Result.ToString());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async Task<string> patch(string url, string data)
        {
            // HttpContent 생성
            HttpContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json-patch+json");

            // PATCH 요청 메서드 설정
            httpContent.Headers.Add("X-HTTP-Method-Override", "PATCH"); // PATCH 메서드 사용

            // PATCH 요청 보내기
            HttpResponseMessage response = await _httpClient.PostAsync("/branches"+url, httpContent);

            // 응답 처리
            if (response.IsSuccessStatusCode)
            {
                // 성공적으로 업데이트되었을 때의 처리
                return response.Content.ReadAsStringAsync().ToString();
            }
            else
            {
                // 오류 응답 처리
                return response.Content.ReadAsStringAsync().ToString();
            }
        }
    }
}
