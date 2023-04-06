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
    /// PaymentInstrumentRevealInfo
    /// </summary>
    [DataContract(Name = "PaymentInstrumentRevealInfo")]
    public partial class PaymentInstrumentRevealInfo : IEquatable<PaymentInstrumentRevealInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentRevealInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInstrumentRevealInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentRevealInfo" /> class.
        /// </summary>
        /// <param name="cvc">The cvc of the card. (required).</param>
        /// <param name="expiration">expiration (required).</param>
        /// <param name="pan">The pan number of the card. (required).</param>
        public PaymentInstrumentRevealInfo(string cvc = default(string), Expiry expiration = default(Expiry), string pan = default(string))
        {
            this.Cvc = cvc;
            this.Expiration = expiration;
            this.Pan = pan;
        }

        /// <summary>
        /// The cvc of the card.
        /// </summary>
        /// <value>The cvc of the card.</value>
        [DataMember(Name = "cvc", IsRequired = false, EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "expiration", IsRequired = false, EmitDefaultValue = false)]
        public Expiry Expiration { get; set; }

        /// <summary>
        /// The pan number of the card.
        /// </summary>
        /// <value>The pan number of the card.</value>
        [DataMember(Name = "pan", IsRequired = false, EmitDefaultValue = false)]
        public string Pan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInstrumentRevealInfo {\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Pan: ").Append(Pan).Append("\n");
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
            return this.Equals(input as PaymentInstrumentRevealInfo);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentRevealInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrumentRevealInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentRevealInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.Pan == input.Pan ||
                    (this.Pan != null &&
                    this.Pan.Equals(input.Pan))
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
                if (this.Cvc != null)
                {
                    hashCode = (hashCode * 59) + this.Cvc.GetHashCode();
                }
                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                }
                if (this.Pan != null)
                {
                    hashCode = (hashCode * 59) + this.Pan.GetHashCode();
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