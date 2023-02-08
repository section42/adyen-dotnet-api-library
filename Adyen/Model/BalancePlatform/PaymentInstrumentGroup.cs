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
    /// PaymentInstrumentGroup
    /// </summary>
    [DataContract(Name = "PaymentInstrumentGroup")]
    public partial class PaymentInstrumentGroup : IEquatable<PaymentInstrumentGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInstrumentGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentGroup" /> class.
        /// </summary>
        /// <param name="balancePlatform">The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the payment instrument group belongs. (required).</param>
        /// <param name="description">Your description for the payment instrument group, maximum 300 characters..</param>
        /// <param name="id">The unique identifier of the payment instrument group..</param>
        /// <param name="properties">Properties of the payment instrument group..</param>
        /// <param name="reference">Your reference for the payment instrument group, maximum 150 characters..</param>
        /// <param name="txVariant">The tx variant of the payment instrument group. (required).</param>
        public PaymentInstrumentGroup(string balancePlatform = default(string), string description = default(string), string id = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), string reference = default(string), string txVariant = default(string))
        {
            this.BalancePlatform = balancePlatform;
            this.TxVariant = txVariant;
            this.Description = description;
            this.Id = id;
            this.Properties = properties;
            this.Reference = reference;
        }

        /// <summary>
        /// The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the payment instrument group belongs.
        /// </summary>
        /// <value>The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the payment instrument group belongs.</value>
        [DataMember(Name = "balancePlatform", IsRequired = false, EmitDefaultValue = true)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Your description for the payment instrument group, maximum 300 characters.
        /// </summary>
        /// <value>Your description for the payment instrument group, maximum 300 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the payment instrument group.
        /// </summary>
        /// <value>The unique identifier of the payment instrument group.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Properties of the payment instrument group.
        /// </summary>
        /// <value>Properties of the payment instrument group.</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Your reference for the payment instrument group, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the payment instrument group, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The tx variant of the payment instrument group.
        /// </summary>
        /// <value>The tx variant of the payment instrument group.</value>
        [DataMember(Name = "txVariant", IsRequired = false, EmitDefaultValue = true)]
        public string TxVariant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInstrumentGroup {\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TxVariant: ").Append(TxVariant).Append("\n");
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
            return this.Equals(input as PaymentInstrumentGroup);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrumentGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
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
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.TxVariant == input.TxVariant ||
                    (this.TxVariant != null &&
                    this.TxVariant.Equals(input.TxVariant))
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
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.TxVariant != null)
                {
                    hashCode = (hashCode * 59) + this.TxVariant.GetHashCode();
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