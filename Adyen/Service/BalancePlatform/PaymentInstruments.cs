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

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Adyen.Service.Resource;
using Adyen.Model.BalancePlatform;
using Adyen.HttpClient;


namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentInstruments : AbstractService
    {
        public PaymentInstruments(Adyen.Client client) : base(client) {}

        /// <summary>
        /// Get a payment instrument Returns the details of a payment instrument.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument GetPaymentInstrumentsId(string id)
        {
            return GetPaymentInstrumentsIdAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payment instrument Returns the details of a payment instrument.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> GetPaymentInstrumentsIdAsync(string id)
        {
            var resource = new BalancePlatformResource(this, $"/paymentInstruments/{id}");
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<PaymentInstrument>(jsonResult);
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument Returns a list of transaction rules associated with a payment instrument.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <returns>TransactionRulesResponse</returns>
        public TransactionRulesResponse GetPaymentInstrumentsIdTransactionRules(string id)
        {
            return GetPaymentInstrumentsIdTransactionRulesAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument Returns a list of transaction rules associated with a payment instrument.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <returns>Task of TransactionRulesResponse</returns>
        public async Task<TransactionRulesResponse> GetPaymentInstrumentsIdTransactionRulesAsync(string id)
        {
            var resource = new BalancePlatformResource(this, $"/paymentInstruments/{id}/transactionRules");
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<TransactionRulesResponse>(jsonResult);
        }

        /// <summary>
        /// Update a payment instrument Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with **inactive** status, you can still update the balance account associated with the card.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"> (optional)</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument PatchPaymentInstrumentsId(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest)
        {
            return PatchPaymentInstrumentsIdAsync(id, paymentInstrumentUpdateRequest).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a payment instrument Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with **inactive** status, you can still update the balance account associated with the card.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"> (optional)</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> PatchPaymentInstrumentsIdAsync(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest)
        {
            var httpMethod = new HttpMethod("PATCH");
            string jsonRequest = paymentInstrumentUpdateRequest.ToJson();
            var resource = new BalancePlatformResource(this, $"/paymentInstruments/{id}");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<PaymentInstrument>(jsonResult);
        }

        /// <summary>
        /// Create a payment instrument Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.   For more information, refer to [Issue cards](https://docs.adyen.com/issuing/create-cards) or [Issue business accounts](https://docs.adyen.com/marketplaces-and-platforms/business-accounts).
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="paymentInstrumentInfo"> (optional)</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument PostPaymentInstruments(PaymentInstrumentInfo paymentInstrumentInfo)
        {
            return PostPaymentInstrumentsAsync(paymentInstrumentInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a payment instrument Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.   For more information, refer to [Issue cards](https://docs.adyen.com/issuing/create-cards) or [Issue business accounts](https://docs.adyen.com/marketplaces-and-platforms/business-accounts).
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="paymentInstrumentInfo"> (optional)</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> PostPaymentInstrumentsAsync(PaymentInstrumentInfo paymentInstrumentInfo)
        {
            string jsonRequest = paymentInstrumentInfo.ToJson();
            var resource = new BalancePlatformResource(this, $"/paymentInstruments");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentInstrument>(jsonResult);
        }

    }
}