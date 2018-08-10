namespace Plaid.Net.Contracts.Response
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Response contract for ExchangeToken api.
    /// </summary>
    internal class StripeBankAccountResponse
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        [JsonProperty("stripe_bank_account_token")]
        public string StripeBankAccount { get; set; }

      
    }
}