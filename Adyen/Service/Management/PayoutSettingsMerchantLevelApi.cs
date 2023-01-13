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
    public class PayoutSettingsMerchantLevelApi : AbstractService
    {
        public PayoutSettingsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Delete a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Object</returns>
        public Object DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, RequestOptions requestOptions = null)
        {
            return DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(merchantId, payoutSettingsId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Object</returns>
        public async Task<Object> DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("DELETE"));
            return JsonConvert.DeserializeObject<Object>(jsonResult);
        }

        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettingsResponse</returns>
        public PayoutSettingsResponse GetMerchantsMerchantIdPayoutSettings(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdPayoutSettingsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettingsResponse</returns>
        public async Task<PayoutSettingsResponse> GetMerchantsMerchantIdPayoutSettingsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PayoutSettingsResponse>(jsonResult);
        }

        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettings</returns>
        public PayoutSettings GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(merchantId, payoutSettingsId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PayoutSettings>(jsonResult);
        }

        /// <summary>
        /// Update a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="updatePayoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettings</returns>
        public PayoutSettings PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = null)
        {
            return PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(merchantId, payoutSettingsId, updatePayoutSettingsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="updatePayoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updatePayoutSettingsRequest.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<PayoutSettings>(jsonResult);
        }

        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettings</returns>
        public PayoutSettings PostMerchantsMerchantIdPayoutSettings(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdPayoutSettingsAsync(merchantId, payoutSettingsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> PostMerchantsMerchantIdPayoutSettingsAsync(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(payoutSettingsRequest.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<PayoutSettings>(jsonResult);
        }

    }
}
