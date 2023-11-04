using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using TelegramBotApiLib.Models;

namespace TelegramBotApiLib
{
    public class TelegramClient
    {
        private readonly string RequestString;
        private readonly IHttpClientFactory httpClientFactory;
        private JsonSerializerOptions serialize_options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public TelegramClient(string token)
        {
            RequestString = $"https://api.telegram.org/bot{token}/";

            var services = new ServiceCollection();
            services.AddHttpClient("TelegramClient", options =>
            {
                options.BaseAddress = new Uri(RequestString);
            });
            var serviceProvider = services.BuildServiceProvider();
            httpClientFactory = serviceProvider.GetService<IHttpClientFactory>()!;
        }

        public async Task<User?> GetMe()
        {
            using var client = httpClientFactory.CreateClient("TelegramClient");

            TelegramResponse? res = await client.GetFromJsonAsync<TelegramResponse>("getMe");

            return res!.ok ? res.result : null;
        }

        public async Task<bool> SendMessageAsync(RequestMessage message)
        {
            using var client = httpClientFactory.CreateClient("TelegramClient");

            HttpResponseMessage res = await client.PostAsJsonAsync("sendMessage", message, serialize_options);

            return res.IsSuccessStatusCode;
        }
    }
}