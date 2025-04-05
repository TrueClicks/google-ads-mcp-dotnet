using System.ComponentModel;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;

namespace GoogleAdsMCP
{
    [McpServerToolType]
    public static class GaqlTools
    {
        [McpServerTool, Description("Gets Google Ads accounts.")]
        public static async Task<string> GetAccountsAsync(GaqlApiClient client)
        {
            return await client.GetAccountsAsync();
        }

        [McpServerTool, Description("Executes a GAQL query and returns the result as a formatted JSON string.")]
        public static async Task<string> ExexuteGaqlQueryAsync(
            GaqlApiClient client,
            ILogger logger,
            [Description("The GAQL (Google Ads Query Language) query to execute.")] GaqlQueryRequest query)
        {
            return await client.ExecuteGaqlQueryAsync(query);

        }
    }
}
