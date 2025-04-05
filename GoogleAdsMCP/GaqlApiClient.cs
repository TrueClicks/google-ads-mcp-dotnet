using System.Net.Http.Json;
using System.Text.Json;

namespace GoogleAdsMCP
{
    public class GaqlApiClient
    {
        private readonly HttpClient httpClient;
        private readonly string token;

        public GaqlApiClient(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentNullException(nameof(token));
            }

            this.token = token;
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.gaql.app")
            };

            this.httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("qaql-tool-client/1.0");
        }

        public async Task<string> GetAccountsAsync()
        {
            var json = await this.httpClient.GetFromJsonAsync<JsonElement>($"/api/gpt/google-ads/get-accounts?gptToken={this.token}");
            return JsonSerializer.Serialize(json, new JsonSerializerOptions { WriteIndented = true });
        }

        public async Task<string> ExecuteGaqlQueryAsync(GaqlQueryRequest query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            var response = await this.httpClient.PostAsJsonAsync($"/api/gpt/google-ads/execute-query?gptToken={this.token}", query);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Serialize(JsonSerializer.Deserialize<object>(json), new JsonSerializerOptions { WriteIndented = true });
        }
    }
}