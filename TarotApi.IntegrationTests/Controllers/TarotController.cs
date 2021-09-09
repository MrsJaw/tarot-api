using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TarotApi.IntegrationTests.Controllers
{
    public static class TarotController
    {
        private const string Route = "/tarot";

        public static Task<HttpResponseMessage> GET_GetReadingTypesAsync(HttpClient client )
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{Route}/reading-types");
            return client.SendAsync(request);
        }

        public static Task<HttpResponseMessage> GET_DoReadingAsync(HttpClient client, string readingType)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{Route}/read/{readingType}");
            return client.SendAsync(request);
        }
    }
}
