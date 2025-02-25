/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// PaymentInstrumentGroupsService Interface
    /// </summary>
    public interface IPaymentInstrumentGroupsService
    {
        /// <summary>
        /// Get a payment instrument group
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentInstrumentGroup"/>.</returns>
        Model.BalancePlatform.PaymentInstrumentGroup GetPaymentInstrumentGroup(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a payment instrument group
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentInstrumentGroup"/>.</returns>
        Task<Model.BalancePlatform.PaymentInstrumentGroup> GetPaymentInstrumentGroupAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get all transaction rules for a payment instrument group
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TransactionRulesResponse"/>.</returns>
        Model.BalancePlatform.TransactionRulesResponse GetAllTransactionRulesForPaymentInstrumentGroup(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all transaction rules for a payment instrument group
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument group.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TransactionRulesResponse"/>.</returns>
        Task<Model.BalancePlatform.TransactionRulesResponse> GetAllTransactionRulesForPaymentInstrumentGroupAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a payment instrument group
        /// </summary>
        /// <param name="paymentInstrumentGroupInfo"><see cref="PaymentInstrumentGroupInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentInstrumentGroup"/>.</returns>
        Model.BalancePlatform.PaymentInstrumentGroup CreatePaymentInstrumentGroup(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment instrument group
        /// </summary>
        /// <param name="paymentInstrumentGroupInfo"><see cref="PaymentInstrumentGroupInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentInstrumentGroup"/>.</returns>
        Task<Model.BalancePlatform.PaymentInstrumentGroup> CreatePaymentInstrumentGroupAsync(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PaymentInstrumentGroupsService API endpoints
    /// </summary>
    public class PaymentInstrumentGroupsService : AbstractService, IPaymentInstrumentGroupsService
    {
        private readonly string _baseUrl;
        
        public PaymentInstrumentGroupsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public Model.BalancePlatform.PaymentInstrumentGroup GetPaymentInstrumentGroup(string id, RequestOptions requestOptions = default)
        {
            return GetPaymentInstrumentGroupAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.PaymentInstrumentGroup> GetPaymentInstrumentGroupAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstrumentGroups/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.PaymentInstrumentGroup>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.TransactionRulesResponse GetAllTransactionRulesForPaymentInstrumentGroup(string id, RequestOptions requestOptions = default)
        {
            return GetAllTransactionRulesForPaymentInstrumentGroupAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.TransactionRulesResponse> GetAllTransactionRulesForPaymentInstrumentGroupAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstrumentGroups/{id}/transactionRules";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.TransactionRulesResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.BalancePlatform.PaymentInstrumentGroup CreatePaymentInstrumentGroup(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo = default, RequestOptions requestOptions = default)
        {
            return CreatePaymentInstrumentGroupAsync(paymentInstrumentGroupInfo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.PaymentInstrumentGroup> CreatePaymentInstrumentGroupAsync(PaymentInstrumentGroupInfo paymentInstrumentGroupInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentInstrumentGroups";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.PaymentInstrumentGroup>(paymentInstrumentGroupInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}