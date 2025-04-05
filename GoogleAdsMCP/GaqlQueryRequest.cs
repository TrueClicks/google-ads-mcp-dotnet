namespace GoogleAdsMCP
{
    public class GaqlQueryRequest
    {
        public GaqlQueryRequest(string query, long customerId, long loginCustomerId, string reportAggregation)
        {
            this.Query = query ?? throw new ArgumentNullException(nameof(query));
            this.CustomerId = customerId;
            this.LoginCustomerId = loginCustomerId;
            this.ReportAggregation = reportAggregation;
        }

        /// <summary>
        /// GAQL Query
        /// </summary>
        public string Query { get; }

        public long CustomerId { get; }

        public long LoginCustomerId { get; }

        /// <summary>
        /// Report aggregation. Ignore for Google Ads, only valid for Microsoft Advertising.
        /// </summary>
        public string ReportAggregation { get; }
    }
}
