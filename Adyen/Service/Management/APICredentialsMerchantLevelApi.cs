/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class APICredentialsMerchantLevelApi : AbstractService
    {
        public APICredentialsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>ListMerchantApiCredentialsResponse</returns>
        public ListMerchantApiCredentialsResponse GetMerchantsMerchantIdApiCredentials(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdApiCredentialsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of API credentials
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of ListMerchantApiCredentialsResponse</returns>
        public async Task<ListMerchantApiCredentialsResponse> GetMerchantsMerchantIdApiCredentialsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListMerchantApiCredentialsResponse>(jsonResult);
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApiCredential</returns>
        public ApiCredential GetMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdApiCredentialsApiCredentialIdAsync(merchantId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApiCredential</returns>
        public async Task<ApiCredential> GetMerchantsMerchantIdApiCredentialsApiCredentialIdAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ApiCredential>(jsonResult);
        }

        /// <summary>
        /// Update an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApiCredential</returns>
        public ApiCredential PatchMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest, RequestOptions requestOptions = null)
        {
            return PatchMerchantsMerchantIdApiCredentialsApiCredentialIdAsync(merchantId, apiCredentialId, updateMerchantApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="updateMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApiCredential</returns>
        public async Task<ApiCredential> PatchMerchantsMerchantIdApiCredentialsApiCredentialIdAsync(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest updateMerchantApiCredentialRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}";
            string jsonRequest = updateMerchantApiCredentialRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<ApiCredential>(jsonResult);
        }

        /// <summary>
        /// Create an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreateApiCredentialResponse</returns>
        public CreateApiCredentialResponse PostMerchantsMerchantIdApiCredentials(string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdApiCredentialsAsync(merchantId, createMerchantApiCredentialRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an API credential
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantApiCredentialRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CreateApiCredentialResponse</returns>
        public async Task<CreateApiCredentialResponse> PostMerchantsMerchantIdApiCredentialsAsync(string merchantId, CreateMerchantApiCredentialRequest createMerchantApiCredentialRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials";
            string jsonRequest = createMerchantApiCredentialRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<CreateApiCredentialResponse>(jsonResult);
        }

    }
}
