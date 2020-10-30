using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace API.Services
{
    public class CookieService
    {
        public void PutCookie()
        {
            HttpResponseMessage respMessage = new HttpResponseMessage();
            CookieHeaderValue cookie = new CookieHeaderValue("session-id", "12345");
            cookie.Expires = DateTimeOffset.Now.AddDays(1);
            cookie.Path = "/";
            respMessage.Headers.AddCookies(new CookieHeaderValue[] { cookie });
        }
    }
}
