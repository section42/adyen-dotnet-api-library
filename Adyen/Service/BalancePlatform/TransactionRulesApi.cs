/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.BalancePlatform;
using Newtonsoft.Json;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionRulesApi : AbstractService
    {
        public TransactionRulesApi(Client client) : base(client) {}
    
        /// <summary>
        /// Delete a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRule</returns>
        public TransactionRule DeleteTransactionRulesTransactionRuleId(string transactionRuleId, RequestOptions requestOptions = default)
        {
            return DeleteTransactionRulesTransactionRuleIdAsync(transactionRuleId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRule</returns>
        public async Task<TransactionRule> DeleteTransactionRulesTransactionRuleIdAsync(string transactionRuleId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/transactionRules/{transactionRuleId}";
            var resource = new BalancePlatformResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"));
            return JsonConvert.DeserializeObject<TransactionRule>(jsonResult);
        }

        /// <summary>
        /// Get a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRuleResponse</returns>
        public TransactionRuleResponse GetTransactionRulesTransactionRuleId(string transactionRuleId, RequestOptions requestOptions = default)
        {
            return GetTransactionRulesTransactionRuleIdAsync(transactionRuleId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRuleResponse</returns>
        public async Task<TransactionRuleResponse> GetTransactionRulesTransactionRuleIdAsync(string transactionRuleId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/transactionRules/{transactionRuleId}";
            var resource = new BalancePlatformResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TransactionRuleResponse>(jsonResult);
        }

        /// <summary>
        /// Update a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="transactionRuleInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRule</returns>
        public TransactionRule PatchTransactionRulesTransactionRuleId(string transactionRuleId, TransactionRuleInfo transactionRuleInfo, RequestOptions requestOptions = default)
        {
            return PatchTransactionRulesTransactionRuleIdAsync(transactionRuleId, transactionRuleInfo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a transaction rule
        /// </summary>
        /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
        /// <param name="transactionRuleInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRule</returns>
        public async Task<TransactionRule> PatchTransactionRulesTransactionRuleIdAsync(string transactionRuleId, TransactionRuleInfo transactionRuleInfo, RequestOptions requestOptions = default)
        {
            var endpoint = $"/transactionRules/{transactionRuleId}";
            var resource = new BalancePlatformResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(transactionRuleInfo.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TransactionRule>(jsonResult);
        }

        /// <summary>
        /// Create a transaction rule
        /// </summary>
        /// <param name="transactionRuleInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRule</returns>
        public TransactionRule PostTransactionRules(TransactionRuleInfo transactionRuleInfo, RequestOptions requestOptions = default)
        {
            return PostTransactionRulesAsync(transactionRuleInfo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a transaction rule
        /// </summary>
        /// <param name="transactionRuleInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRule</returns>
        public async Task<TransactionRule> PostTransactionRulesAsync(TransactionRuleInfo transactionRuleInfo, RequestOptions requestOptions = default)
        {
            var endpoint = "/transactionRules";
            var resource = new BalancePlatformResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(transactionRuleInfo.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<TransactionRule>(jsonResult);
        }

    }
}
