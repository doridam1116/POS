using System;
using System.Net.Http;
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


        public async Task<string> post(string postData)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync("/branches", new StringContent(postData, Encoding.UTF8, "application/json"));

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
                throw new Exception("에러: " + ex.Message);
            }

        }
    }
}
