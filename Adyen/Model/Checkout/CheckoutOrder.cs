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
    /// CheckoutOrder
    /// </summary>
    [DataContract(Name = "CheckoutOrder")]
    public partial class CheckoutOrder : IEquatable<CheckoutOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrder" /> class.
        /// </summary>
        /// <param name="orderData">The encrypted order data. (required).</param>
        /// <param name="pspReference">The &#x60;pspReference&#x60; that belongs to the order. (required).</param>
        public CheckoutOrder(string orderData = default(string), string pspReference = default(string))
        {
            this.OrderData = orderData;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// The encrypted order data.
        /// </summary>
        /// <value>The encrypted order data.</value>
        [DataMember(Name = "orderData", IsRequired = false, EmitDefaultValue = false)]
        public string OrderData { get; set; }

        /// <summary>
        /// The &#x60;pspReference&#x60; that belongs to the order.
        /// </summary>
        /// <value>The &#x60;pspReference&#x60; that belongs to the order.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutOrder {\n");
            sb.Append("  OrderData: ").Append(OrderData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as CheckoutOrder);
        }

        /// <summary>
        /// Returns true if CheckoutOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderData == input.OrderData ||
                    (this.OrderData != null &&
                    this.OrderData.Equals(input.OrderData))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
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
                if (this.OrderData != null)
                {
                    hashCode = (hashCode * 59) + this.OrderData.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
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
