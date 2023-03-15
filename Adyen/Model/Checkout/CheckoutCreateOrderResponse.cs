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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutCreateOrderResponse
    /// </summary>
    [DataContract(Name = "CheckoutCreateOrderResponse")]
    public partial class CheckoutCreateOrderResponse : IEquatable<CheckoutCreateOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the order creation request.  The value is always **Success**.
        /// </summary>
        /// <value>The result of the order creation request.  The value is always **Success**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1

        }


        /// <summary>
        /// The result of the order creation request.  The value is always **Success**.
        /// </summary>
        /// <value>The result of the order creation request.  The value is always **Success**.</value>
        [DataMember(Name = "resultCode", IsRequired = false, EmitDefaultValue = false)]
        public ResultCodeEnum ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutCreateOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateOrderResponse" /> class.
        /// </summary>
        /// <param name="additionalData">Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="expiresAt">The date that the order will expire. (required).</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="orderData">The encrypted data that will be used by merchant for adding payments to the order. (required).</param>
        /// <param name="pspReference">Adyen&#39;s 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request..</param>
        /// <param name="reference">The reference provided by merchant for creating the order..</param>
        /// <param name="refusalReason">If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="remainingAmount">remainingAmount (required).</param>
        /// <param name="resultCode">The result of the order creation request.  The value is always **Success**. (required).</param>
        public CheckoutCreateOrderResponse(Dictionary<string, string> additionalData = default(Dictionary<string, string>), Amount amount = default(Amount), string expiresAt = default(string), FraudResult fraudResult = default(FraudResult), string orderData = default(string), string pspReference = default(string), string reference = default(string), string refusalReason = default(string), Amount remainingAmount = default(Amount), ResultCodeEnum resultCode = default(ResultCodeEnum))
        {
            this.Amount = amount;
            this.ExpiresAt = expiresAt;
            this.OrderData = orderData;
            this.RemainingAmount = remainingAmount;
            this.ResultCode = resultCode;
            this.AdditionalData = additionalData;
            this.FraudResult = fraudResult;
            this.PspReference = pspReference;
            this.Reference = reference;
            this.RefusalReason = refusalReason;
        }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**.
        /// </summary>
        /// <value>Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The date that the order will expire.
        /// </summary>
        /// <value>The date that the order will expire.</value>
        [DataMember(Name = "expiresAt", IsRequired = false, EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// The encrypted data that will be used by merchant for adding payments to the order.
        /// </summary>
        /// <value>The encrypted data that will be used by merchant for adding payments to the order.</value>
        [DataMember(Name = "orderData", IsRequired = false, EmitDefaultValue = false)]
        public string OrderData { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The reference provided by merchant for creating the order.
        /// </summary>
        /// <value>The reference provided by merchant for creating the order.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Gets or Sets RemainingAmount
        /// </summary>
        [DataMember(Name = "remainingAmount", IsRequired = false, EmitDefaultValue = false)]
        public Amount RemainingAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutCreateOrderResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  OrderData: ").Append(OrderData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as CheckoutCreateOrderResponse);
        }

        /// <summary>
        /// Returns true if CheckoutCreateOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutCreateOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutCreateOrderResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.FraudResult == input.FraudResult ||
                    (this.FraudResult != null &&
                    this.FraudResult.Equals(input.FraudResult))
                ) && 
                (
                    this.OrderData == input.OrderData ||
                    (this.OrderData != null &&
                    this.OrderData.Equals(input.OrderData))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RefusalReason == input.RefusalReason ||
                    (this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason))
                ) && 
                (
                    this.RemainingAmount == input.RemainingAmount ||
                    (this.RemainingAmount != null &&
                    this.RemainingAmount.Equals(input.RemainingAmount))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.FraudResult != null)
                {
                    hashCode = (hashCode * 59) + this.FraudResult.GetHashCode();
                }
                if (this.OrderData != null)
                {
                    hashCode = (hashCode * 59) + this.OrderData.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.RefusalReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefusalReason.GetHashCode();
                }
                if (this.RemainingAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RemainingAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
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
