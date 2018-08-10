namespace Plaid.Net.Contracts
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Request object to exchange banking tokens.
    /// </summary>
    internal class StripeBankAccountRequest : PlaidRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeTokenRequest"/> class.
        /// </summary>
        public StripeBankAccountRequest(string clientId, string secret, string accessToken, string accountId) : base(clientId, secret, accessToken)
        {
            this.AccountId = accountId;
        }

       

        /// <summary>
        /// The account identifier from Plaid Link.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}