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
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.BalancePlatform;
using Newtonsoft.Json;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentInstrumentGroupsApi : AbstractService
    {
        private readonly string _baseUrl;
        
        public PaymentInstrumentGroupsApi(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutVersion;
        }
    
        /// <summary>
        /// Get a payment instrument group
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentInstrumentGroup</returns>
        public PaymentInstrumentGroup (string id, RequestOptions requestOptions = default)
        {
            return Async(id, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payment instrument group
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentInstrumentGroup</returns>
        public async Task<PaymentInstrumentGroup> Async(string id, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/paymentInstrumentGroups/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrumentGroup>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument group
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRulesResponse</returns>
        public TransactionRulesResponse (string id, RequestOptions requestOptions = default)
        {
            return Async(id, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument group
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRulesResponse</returns>
        public async Task<TransactionRulesResponse> Async(string id, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/paymentInstrumentGroups/{id}/transactionRules";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TransactionRulesResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Create a payment instrument group
        /// </summary>
        /// <param name="paymentInstrumentGroupInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentInstrumentGroup</returns>
        public PaymentInstrumentGroup (PaymentInstrumentGroupInfo paymentInstrumentGroupInfo, RequestOptions requestOptions = default)
        {
            return Async(paymentInstrumentGroupInfo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a payment instrument group
        /// </summary>
        /// <param name="paymentInstrumentGroupInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentInstrumentGroup</returns>
        public async Task<PaymentInstrumentGroup> Async(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/paymentInstrumentGroups";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrumentGroup>(paymentInstrumentGroupInfo.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}