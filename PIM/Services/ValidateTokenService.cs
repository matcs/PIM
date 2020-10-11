using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PIM.Services
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
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }      
        }
    }
}
