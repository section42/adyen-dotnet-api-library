/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// PayoutMethod
    /// </summary>
    [DataContract(Name = "PayoutMethod")]
    public partial class PayoutMethod : IEquatable<PayoutMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethod" /> class.
        /// </summary>
        /// <param name="merchantAccount">The [&#x60;merchantAccount&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_merchantAccount) you used in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store). (required).</param>
        /// <param name="payoutMethodCode">Adyen-generated unique alphanumeric identifier (UUID) for the payout method, returned in the response when you create a payout method. Required when updating an existing payout method in an &#x60;/updateAccountHolder&#x60; request..</param>
        /// <param name="payoutMethodReference">Your reference for the payout method..</param>
        /// <param name="recurringDetailReference">The [&#x60;recurringDetailReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-recurring-recurringDetailReference)  returned in the &#x60;/payments&#x60; response when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store). (required).</param>
        /// <param name="shopperReference">The [&#x60;shopperReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_shopperReference) you sent in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store). (required).</param>
        public PayoutMethod(string merchantAccount = default(string), string payoutMethodCode = default(string), string payoutMethodReference = default(string), string recurringDetailReference = default(string), string shopperReference = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.RecurringDetailReference = recurringDetailReference;
            this.ShopperReference = shopperReference;
            this.PayoutMethodCode = payoutMethodCode;
            this.PayoutMethodReference = payoutMethodReference;
        }

        /// <summary>
        /// The [&#x60;merchantAccount&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_merchantAccount) you used in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).
        /// </summary>
        /// <value>The [&#x60;merchantAccount&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_merchantAccount) you used in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Adyen-generated unique alphanumeric identifier (UUID) for the payout method, returned in the response when you create a payout method. Required when updating an existing payout method in an &#x60;/updateAccountHolder&#x60; request.
        /// </summary>
        /// <value>Adyen-generated unique alphanumeric identifier (UUID) for the payout method, returned in the response when you create a payout method. Required when updating an existing payout method in an &#x60;/updateAccountHolder&#x60; request.</value>
        [DataMember(Name = "payoutMethodCode", EmitDefaultValue = false)]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// Your reference for the payout method.
        /// </summary>
        /// <value>Your reference for the payout method.</value>
        [DataMember(Name = "payoutMethodReference", EmitDefaultValue = false)]
        public string PayoutMethodReference { get; set; }

        /// <summary>
        /// The [&#x60;recurringDetailReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-recurring-recurringDetailReference)  returned in the &#x60;/payments&#x60; response when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).
        /// </summary>
        /// <value>The [&#x60;recurringDetailReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-recurring-recurringDetailReference)  returned in the &#x60;/payments&#x60; response when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).</value>
        [DataMember(Name = "recurringDetailReference", IsRequired = false, EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The [&#x60;shopperReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_shopperReference) you sent in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).
        /// </summary>
        /// <value>The [&#x60;shopperReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_shopperReference) you sent in the &#x60;/payments&#x60; request when you [saved the account holder&#39;s card details](https://docs.adyen.com/marketplaces-and-platforms/classic/payouts/manual-payout/payout-to-cards#check-and-store).</value>
        [DataMember(Name = "shopperReference", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayoutMethod {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutMethodReference: ").Append(PayoutMethodReference).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayoutMethod);
        }

        /// <summary>
        /// Returns true if PayoutMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.PayoutMethodCode == input.PayoutMethodCode ||
                    (this.PayoutMethodCode != null &&
                    this.PayoutMethodCode.Equals(input.PayoutMethodCode))
                ) && 
                (
                    this.PayoutMethodReference == input.PayoutMethodReference ||
                    (this.PayoutMethodReference != null &&
                    this.PayoutMethodReference.Equals(input.PayoutMethodReference))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.PayoutMethodCode != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutMethodCode.GetHashCode();
                }
                if (this.PayoutMethodReference != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutMethodReference.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
