using System;
using System.Net.Http;

namespace API.Services
{
    public class ValidateTokenService
    {
        Object client = new HttpClient();

        //string BaseUrl = "https://localhost:44343/";

        public bool CheckTokenValidation()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44343/api/");

                var responseTask = client.GetAsync("Home");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
        }
    }
}