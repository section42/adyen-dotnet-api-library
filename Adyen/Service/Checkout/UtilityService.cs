/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using Adyen.Model.Checkout;
using Newtonsoft.Json;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UtilityService : AbstractService
    {
        private readonly string _baseUrl;
        
        public UtilityService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
    
        /// <summary>
        /// Get an Apple Pay session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createApplePaySessionRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApplePaySessionResponse</returns>
        public ApplePaySessionResponse GetApplePaySession(CreateApplePaySessionRequest createApplePaySessionRequest, RequestOptions requestOptions = default)
        {
            return GetApplePaySessionAsync(createApplePaySessionRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an Apple Pay session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createApplePaySessionRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApplePaySessionResponse</returns>
        public async Task<ApplePaySessionResponse> GetApplePaySessionAsync(CreateApplePaySessionRequest createApplePaySessionRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/applePay/sessions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ApplePaySessionResponse>(createApplePaySessionRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Create originKey values for domains
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="checkoutUtilityRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CheckoutUtilityResponse</returns>
        [Obsolete]
        public CheckoutUtilityResponse CreateOriginkeyValuesForDomains(CheckoutUtilityRequest checkoutUtilityRequest, RequestOptions requestOptions = default)
        {
            return CreateOriginkeyValuesForDomainsAsync(checkoutUtilityRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create originKey values for domains
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="checkoutUtilityRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CheckoutUtilityResponse</returns>
        [Obsolete]
        public async Task<CheckoutUtilityResponse> CreateOriginkeyValuesForDomainsAsync(CheckoutUtilityRequest checkoutUtilityRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/originKeys";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CheckoutUtilityResponse>(checkoutUtilityRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}