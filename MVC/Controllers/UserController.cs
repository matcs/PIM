using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public const string Baseurl = "https://localhost:44343/api/";

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> PaymentReceipts()
        {
            List<PaymentReceiptViewModel> PaymentReceipt = new List<PaymentReceiptViewModel>();

            string cookie = Request.Cookies["jwt"];

            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(cookie) as JwtSecurityToken;
            string userId = (string)tokenS.Payload["unique_name"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookie);

                HttpResponseMessage Res = await client.GetAsync("PaymentReceipts/" + userId);

                if (Res.IsSuccessStatusCode)
                {
                    var PaymentResponse = Res.Content.ReadAsStringAsync().Result;

                    PaymentReceipt = JsonConvert.DeserializeObject<List<PaymentReceiptViewModel>>(PaymentResponse);
                }

                return View(PaymentReceipt);
            }
        }
            
        public async Task<IActionResult> PaymentDetails(string id)
        {
            PaymentReceiptViewModel PaymentReceipt = new PaymentReceiptViewModel();

            string cookie = Request.Cookies["jwt"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44343/api/");

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookie);
                HttpResponseMessage Res = await client.GetAsync("PaymentReceipts/Details/" + id);

                if (Res.IsSuccessStatusCode)
                {
                    var PaymentResponse = Res.Content.ReadAsStringAsync().Result;

                    PaymentReceipt = JsonConvert.DeserializeObject<PaymentReceiptViewModel>(PaymentResponse);

                }

                return View(PaymentReceipt);
            }
        }

    }
}
