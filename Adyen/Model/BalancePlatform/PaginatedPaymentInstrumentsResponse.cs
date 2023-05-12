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
    /// PaginatedPaymentInstrumentsResponse
    /// </summary>
    [DataContract(Name = "PaginatedPaymentInstrumentsResponse")]
    public partial class PaginatedPaymentInstrumentsResponse : IEquatable<PaginatedPaymentInstrumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedPaymentInstrumentsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginatedPaymentInstrumentsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedPaymentInstrumentsResponse" /> class.
        /// </summary>
        /// <param name="hasNext">Indicates whether there are more items on the next page. (required).</param>
        /// <param name="hasPrevious">Indicates whether there are more items on the previous page. (required).</param>
        /// <param name="paymentInstruments">List of payment instruments associated with the balance account. (required).</param>
        public PaginatedPaymentInstrumentsResponse(bool hasNext = default(bool), bool hasPrevious = default(bool), List<PaymentInstrument> paymentInstruments = default(List<PaymentInstrument>))
        {
            this.HasNext = hasNext;
            this.HasPrevious = hasPrevious;
            this.PaymentInstruments = paymentInstruments;
        }

        /// <summary>
        /// Indicates whether there are more items on the next page.
        /// </summary>
        /// <value>Indicates whether there are more items on the next page.</value>
        [DataMember(Name = "hasNext", IsRequired = false, EmitDefaultValue = false)]
        public bool HasNext { get; set; }

        /// <summary>
        /// Indicates whether there are more items on the previous page.
        /// </summary>
        /// <value>Indicates whether there are more items on the previous page.</value>
        [DataMember(Name = "hasPrevious", IsRequired = false, EmitDefaultValue = false)]
        public bool HasPrevious { get; set; }

        /// <summary>
        /// List of payment instruments associated with the balance account.
        /// </summary>
        /// <value>List of payment instruments associated with the balance account.</value>
        [DataMember(Name = "paymentInstruments", IsRequired = false, EmitDefaultValue = false)]
        public List<PaymentInstrument> PaymentInstruments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginatedPaymentInstrumentsResponse {\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
            sb.Append("  HasPrevious: ").Append(HasPrevious).Append("\n");
            sb.Append("  PaymentInstruments: ").Append(PaymentInstruments).Append("\n");
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
            return this.Equals(input as PaginatedPaymentInstrumentsResponse);
        }

        /// <summary>
        /// Returns true if PaginatedPaymentInstrumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedPaymentInstrumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedPaymentInstrumentsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HasNext == input.HasNext ||
                    this.HasNext.Equals(input.HasNext)
                ) && 
                (
                    this.HasPrevious == input.HasPrevious ||
                    this.HasPrevious.Equals(input.HasPrevious)
                ) && 
                (
                    this.PaymentInstruments == input.PaymentInstruments ||
                    this.PaymentInstruments != null &&
                    input.PaymentInstruments != null &&
                    this.PaymentInstruments.SequenceEqual(input.PaymentInstruments)
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
                hashCode = (hashCode * 59) + this.HasNext.GetHashCode();
                hashCode = (hashCode * 59) + this.HasPrevious.GetHashCode();
                if (this.PaymentInstruments != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstruments.GetHashCode();
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
