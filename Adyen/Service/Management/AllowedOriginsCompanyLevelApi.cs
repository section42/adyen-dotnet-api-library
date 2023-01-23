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
    public class AllowedOriginsCompanyLevelApi : AbstractService
    {
        public AllowedOriginsCompanyLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public void DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(companyId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public async Task DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            var resource = new ManagementResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOriginsResponse</returns>
        public AllowedOriginsResponse GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(companyId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOriginsResponse</returns>
        public async Task<AllowedOriginsResponse> GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(string companyId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<AllowedOriginsResponse>(jsonResult);
        }

        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOrigin</returns>
        public AllowedOrigin GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            return GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(companyId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOrigin</returns>
        public async Task<AllowedOrigin> GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(string companyId, string apiCredentialId, string originId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<AllowedOrigin>(jsonResult);
        }

        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOriginsResponse</returns>
        public AllowedOriginsResponse PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default)
        {
            return PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(companyId, apiCredentialId, allowedOrigin, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOriginsResponse</returns>
        public async Task<AllowedOriginsResponse> PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(string companyId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = default)
        {
            var endpoint = $"/companies/{companyId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(allowedOrigin.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<AllowedOriginsResponse>(jsonResult);
        }

    }
}
