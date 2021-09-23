using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TarotApi.IntegrationTests
{
    public static class HttpResponseMessageExtensions
    {
        private static JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        public static async Task<T> ReadJsonResponse<T>(this HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json, _options);
        }
    }
}
