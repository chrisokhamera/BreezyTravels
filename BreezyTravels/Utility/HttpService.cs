using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BreezyTravels.Utility
{
    public class HttpService
    {
        public static HttpClient GetHttpClient()
        {
            HttpClient client = null;
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("X-Auth-Token", "de936799-d4e5");
            cookieContainer.Add(new Uri("https://dev.allmyles.com/v2.0/flights"), new Cookie("CookieName", "cookie_value"));
            

            return client;
        }
    }
}
