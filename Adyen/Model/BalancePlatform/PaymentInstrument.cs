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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// PaymentInstrument
    /// </summary>
    [DataContract(Name = "PaymentInstrument")]
    public partial class PaymentInstrument : IEquatable<PaymentInstrument>, IValidatableObject
    {
        /// <summary>
        /// The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to **active** by default. However, there can be exceptions for cards based on the &#x60;card.formFactor&#x60; and the &#x60;issuingCountryCode&#x60;. For example, when issuing physical cards in the US, the default status is **inactive**.  Possible values:    * **active**:  The payment instrument is active and can be used to make payments.    * **inactive**: The payment instrument is inactive and cannot be used to make payments.    * **suspended**: The payment instrument is suspended, either because it was stolen or lost.    * **closed**: The payment instrument is permanently closed. This action cannot be undone.   
        /// </summary>
        /// <value>The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to **active** by default. However, there can be exceptions for cards based on the &#x60;card.formFactor&#x60; and the &#x60;issuingCountryCode&#x60;. For example, when issuing physical cards in the US, the default status is **inactive**.  Possible values:    * **active**:  The payment instrument is active and can be used to make payments.    * **inactive**: The payment instrument is inactive and cannot be used to make payments.    * **suspended**: The payment instrument is suspended, either because it was stolen or lost.    * **closed**: The payment instrument is permanently closed. This action cannot be undone.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 4

        }


        /// <summary>
        /// The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to **active** by default. However, there can be exceptions for cards based on the &#x60;card.formFactor&#x60; and the &#x60;issuingCountryCode&#x60;. For example, when issuing physical cards in the US, the default status is **inactive**.  Possible values:    * **active**:  The payment instrument is active and can be used to make payments.    * **inactive**: The payment instrument is inactive and cannot be used to make payments.    * **suspended**: The payment instrument is suspended, either because it was stolen or lost.    * **closed**: The payment instrument is permanently closed. This action cannot be undone.   
        /// </summary>
        /// <value>The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to **active** by default. However, there can be exceptions for cards based on the &#x60;card.formFactor&#x60; and the &#x60;issuingCountryCode&#x60;. For example, when issuing physical cards in the US, the default status is **inactive**.  Possible values:    * **active**:  The payment instrument is active and can be used to make payments.    * **inactive**: The payment instrument is inactive and cannot be used to make payments.    * **suspended**: The payment instrument is suspended, either because it was stolen or lost.    * **closed**: The payment instrument is permanently closed. This action cannot be undone.   </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The reason for updating the status of the payment instrument.  Possible values: **lost**, **stolen**, **damaged**, **suspectedFraud**, **expired**, **endOfLife**, **accountClosure**, **other**. If the reason is **other**, you must also send the &#x60;statusComment&#x60; parameter describing the status change.
        /// </summary>
        /// <value>The reason for updating the status of the payment instrument.  Possible values: **lost**, **stolen**, **damaged**, **suspectedFraud**, **expired**, **endOfLife**, **accountClosure**, **other**. If the reason is **other**, you must also send the &#x60;statusComment&#x60; parameter describing the status change.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusReasonEnum
        {
            /// <summary>
            /// Enum AccountClosure for value: accountClosure
            /// </summary>
            [EnumMember(Value = "accountClosure")]
            AccountClosure = 1,

            /// <summary>
            /// Enum Damaged for value: damaged
            /// </summary>
            [EnumMember(Value = "damaged")]
            Damaged = 2,

            /// <summary>
            /// Enum EndOfLife for value: endOfLife
            /// </summary>
            [EnumMember(Value = "endOfLife")]
            EndOfLife = 3,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 4,

            /// <summary>
            /// Enum Lost for value: lost
            /// </summary>
            [EnumMember(Value = "lost")]
            Lost = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6,

            /// <summary>
            /// Enum Stolen for value: stolen
            /// </summary>
            [EnumMember(Value = "stolen")]
            Stolen = 7,

            /// <summary>
            /// Enum SuspectedFraud for value: suspectedFraud
            /// </summary>
            [EnumMember(Value = "suspectedFraud")]
            SuspectedFraud = 8

        }


        /// <summary>
        /// The reason for updating the status of the payment instrument.  Possible values: **lost**, **stolen**, **damaged**, **suspectedFraud**, **expired**, **endOfLife**, **accountClosure**, **other**. If the reason is **other**, you must also send the &#x60;statusComment&#x60; parameter describing the status change.
        /// </summary>
        /// <value>The reason for updating the status of the payment instrument.  Possible values: **lost**, **stolen**, **damaged**, **suspectedFraud**, **expired**, **endOfLife**, **accountClosure**, **other**. If the reason is **other**, you must also send the &#x60;statusComment&#x60; parameter describing the status change.</value>
        [DataMember(Name = "statusReason", EmitDefaultValue = false)]
        public StatusReasonEnum? StatusReason { get; set; }
        /// <summary>
        /// Type of payment instrument.  Possible value: **card**, **bankAccount**. 
        /// </summary>
        /// <value>Type of payment instrument.  Possible value: **card**, **bankAccount**. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bankAccount
            /// </summary>
            [EnumMember(Value = "bankAccount")]
            BankAccount = 1,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 2

        }


        /// <summary>
        /// Type of payment instrument.  Possible value: **card**, **bankAccount**. 
        /// </summary>
        /// <value>Type of payment instrument.  Possible value: **card**, **bankAccount**. </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrument" /> class.
        /// </summary>
        /// <param name="balanceAccountId">The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/balanceAccounts__resParam_id) associated with the payment instrument. (required).</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="card">card.</param>
        /// <param name="description">Your description for the payment instrument, maximum 300 characters..</param>
        /// <param name="id">The unique identifier of the payment instrument. (required).</param>
        /// <param name="issuingCountryCode">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the payment instrument is issued. For example, **NL** or **US**. (required).</param>
        /// <param name="paymentInstrumentGroupId">The unique identifier of the [payment instrument group](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/paymentInstrumentGroups__resParam_id) to which the payment instrument belongs..</param>
        /// <param name="reference">Your reference for the payment instrument, maximum 150 characters..</param>
        /// <param name="status">The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to **active** by default. However, there can be exceptions for cards based on the &#x60;card.formFactor&#x60; and the &#x60;issuingCountryCode&#x60;. For example, when issuing physical cards in the US, the default status is **inactive**.  Possible values:    * **active**:  The payment instrument is active and can be used to make payments.    * **inactive**: The payment instrument is inactive and cannot be used to make payments.    * **suspended**: The payment instrument is suspended, either because it was stolen or lost.    * **closed**: The payment instrument is permanently closed. This action cannot be undone.   .</param>
        /// <param name="statusReason">The reason for updating the status of the payment instrument.  Possible values: **lost**, **stolen**, **damaged**, **suspectedFraud**, **expired**, **endOfLife**, **accountClosure**, **other**. If the reason is **other**, you must also send the &#x60;statusComment&#x60; parameter describing the status change..</param>
        /// <param name="type">Type of payment instrument.  Possible value: **card**, **bankAccount**.  (required).</param>
        public PaymentInstrument(string balanceAccountId = default(string), PaymentInstrumentBankAccount bankAccount = default(PaymentInstrumentBankAccount), Card card = default(Card), string description = default(string), string id = default(string), string issuingCountryCode = default(string), string paymentInstrumentGroupId = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), StatusReasonEnum? statusReason = default(StatusReasonEnum?), TypeEnum type = default(TypeEnum))
        {
            this.BalanceAccountId = balanceAccountId;
            this.Id = id;
            this.IssuingCountryCode = issuingCountryCode;
            this.Type = type;
            this.BankAccount = bankAccount;
            this.Card = card;
            this.Description = description;
            this.PaymentInstrumentGroupId = paymentInstrumentGroupId;
            this.Reference = reference;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/balanceAccounts__resParam_id) associated with the payment instrument.
        /// </summary>
        /// <value>The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/balanceAccounts__resParam_id) associated with the payment instrument.</value>
        [DataMember(Name = "balanceAccountId", IsRequired = false, EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public PaymentInstrumentBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        /// <summary>
        /// Your description for the payment instrument, maximum 300 characters.
        /// </summary>
        /// <value>Your description for the payment instrument, maximum 300 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the payment instrument.
        /// </summary>
        /// <value>The unique identifier of the payment instrument.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the payment instrument is issued. For example, **NL** or **US**.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the payment instrument is issued. For example, **NL** or **US**.</value>
        [DataMember(Name = "issuingCountryCode", IsRequired = false, EmitDefaultValue = false)]
        public string IssuingCountryCode { get; set; }

        /// <summary>
        /// The unique identifier of the [payment instrument group](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/paymentInstrumentGroups__resParam_id) to which the payment instrument belongs.
        /// </summary>
        /// <value>The unique identifier of the [payment instrument group](https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/paymentInstrumentGroups__resParam_id) to which the payment instrument belongs.</value>
        [DataMember(Name = "paymentInstrumentGroupId", EmitDefaultValue = false)]
        public string PaymentInstrumentGroupId { get; set; }

        /// <summary>
        /// Your reference for the payment instrument, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the payment instrument, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInstrument {\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuingCountryCode: ").Append(IssuingCountryCode).Append("\n");
            sb.Append("  PaymentInstrumentGroupId: ").Append(PaymentInstrumentGroupId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentInstrument);
        }

        /// <summary>
        /// Returns true if PaymentInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalanceAccountId == input.BalanceAccountId ||
                    (this.BalanceAccountId != null &&
                    this.BalanceAccountId.Equals(input.BalanceAccountId))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssuingCountryCode == input.IssuingCountryCode ||
                    (this.IssuingCountryCode != null &&
                    this.IssuingCountryCode.Equals(input.IssuingCountryCode))
                ) && 
                (
                    this.PaymentInstrumentGroupId == input.PaymentInstrumentGroupId ||
                    (this.PaymentInstrumentGroupId != null &&
                    this.PaymentInstrumentGroupId.Equals(input.PaymentInstrumentGroupId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusReason == input.StatusReason ||
                    this.StatusReason.Equals(input.StatusReason)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.BalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccountId.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IssuingCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCountryCode.GetHashCode();
                }
                if (this.PaymentInstrumentGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentGroupId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusReason.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
