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
    /// BillDeskDetails
    /// </summary>
    [DataContract(Name = "BillDeskDetails")]
    public partial class BillDeskDetails : IEquatable<BillDeskDetails>, IValidatableObject
    {
        /// <summary>
        /// **billdesk**
        /// </summary>
        /// <value>**billdesk**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BilldeskOnline for value: billdesk_online
            /// </summary>
            [EnumMember(Value = "billdesk_online")]
            BilldeskOnline = 1,

            /// <summary>
            /// Enum BilldeskWallet for value: billdesk_wallet
            /// </summary>
            [EnumMember(Value = "billdesk_wallet")]
            BilldeskWallet = 2,

            /// <summary>
            /// Enum OnlinebankingIN for value: onlinebanking_IN
            /// </summary>
            [EnumMember(Value = "onlinebanking_IN")]
            OnlinebankingIN = 3,

            /// <summary>
            /// Enum WalletIN for value: wallet_IN
            /// </summary>
            [EnumMember(Value = "wallet_IN")]
            WalletIN = 4

        }


        /// <summary>
        /// **billdesk**
        /// </summary>
        /// <value>**billdesk**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillDeskDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillDeskDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillDeskDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="issuer">The issuer id of the shopper&#39;s selected bank. (required).</param>
        /// <param name="type">**billdesk** (required).</param>
        public BillDeskDetails(string checkoutAttemptId = default(string), string issuer = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Issuer = issuer;
            this.Type = type;
            this.CheckoutAttemptId = checkoutAttemptId;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The issuer id of the shopper&#39;s selected bank.
        /// </summary>
        /// <value>The issuer id of the shopper&#39;s selected bank.</value>
        [DataMember(Name = "issuer", IsRequired = false, EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillDeskDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
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
            return this.Equals(input as BillDeskDetails);
        }

        /// <summary>
        /// Returns true if BillDeskDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BillDeskDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillDeskDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
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
            yield break;
        }
    }

}
