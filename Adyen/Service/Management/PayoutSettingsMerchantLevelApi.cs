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
using System.Collections.Generic;
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
        public void DeletePayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            DeletePayoutSettingAsync(merchantId, payoutSettingsId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public async Task DeletePayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettingsResponse</returns>
        public PayoutSettingsResponse ListPayoutSettings(string merchantId, RequestOptions requestOptions = default)
        {
            return ListPayoutSettingsAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of payout settings
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettingsResponse</returns>
        public async Task<PayoutSettingsResponse> ListPayoutSettingsAsync(string merchantId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PayoutSettingsResponse>(jsonResult);
        }

        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettings</returns>
        public PayoutSettings GetPayoutSetting(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            return GetPayoutSettingAsync(merchantId, payoutSettingsId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> GetPayoutSettingAsync(string merchantId, string payoutSettingsId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
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
        public PayoutSettings UpdatePayoutSetting(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default)
        {
            return UpdatePayoutSettingAsync(merchantId, payoutSettingsId, updatePayoutSettingsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
        /// <param name="updatePayoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> UpdatePayoutSettingAsync(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest updatePayoutSettingsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings/{payoutSettingsId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updatePayoutSettingsRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<PayoutSettings>(jsonResult);
        }

        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PayoutSettings</returns>
        public PayoutSettings AddPayoutSetting(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default)
        {
            return AddPayoutSettingAsync(merchantId, payoutSettingsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a payout setting
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="payoutSettingsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PayoutSettings</returns>
        public async Task<PayoutSettings> AddPayoutSettingAsync(string merchantId, PayoutSettingsRequest payoutSettingsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/payoutSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(payoutSettingsRequest.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<PayoutSettings>(jsonResult);
        }

    }
}
