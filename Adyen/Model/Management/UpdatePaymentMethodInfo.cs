/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// UpdatePaymentMethodInfo
    /// </summary>
    [DataContract(Name = "UpdatePaymentMethodInfo")]
    public partial class UpdatePaymentMethodInfo : IEquatable<UpdatePaymentMethodInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentMethodInfo" /> class.
        /// </summary>
        /// <param name="countries">The list of countries where a payment method is available. By default, all countries supported by the payment method..</param>
        /// <param name="currencies">The list of currencies that a payment method supports. By default, all currencies supported by the payment method..</param>
        /// <param name="customRoutingFlags">Custom routing flags for acquirer routing..</param>
        /// <param name="enabled">Indicates whether the payment method is enabled (**true**) or disabled (**false**)..</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="storeIds">The list of stores for this payment method.</param>
        public UpdatePaymentMethodInfo(List<string> countries = default(List<string>), List<string> currencies = default(List<string>), List<string> customRoutingFlags = default(List<string>), bool enabled = default(bool), ShopperStatement shopperStatement = default(ShopperStatement), List<string> storeIds = default(List<string>))
        {
            this.Countries = countries;
            this.Currencies = currencies;
            this.CustomRoutingFlags = customRoutingFlags;
            this.Enabled = enabled;
            this.ShopperStatement = shopperStatement;
            this.StoreIds = storeIds;
        }

        /// <summary>
        /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
        /// </summary>
        /// <value>The list of countries where a payment method is available. By default, all countries supported by the payment method.</value>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
        /// </summary>
        /// <value>The list of currencies that a payment method supports. By default, all currencies supported by the payment method.</value>
        [DataMember(Name = "currencies", EmitDefaultValue = false)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Custom routing flags for acquirer routing.
        /// </summary>
        /// <value>Custom routing flags for acquirer routing.</value>
        [DataMember(Name = "customRoutingFlags", EmitDefaultValue = false)]
        public List<string> CustomRoutingFlags { get; set; }

        /// <summary>
        /// Indicates whether the payment method is enabled (**true**) or disabled (**false**).
        /// </summary>
        /// <value>Indicates whether the payment method is enabled (**true**) or disabled (**false**).</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ShopperStatement
        /// </summary>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public ShopperStatement ShopperStatement { get; set; }

        /// <summary>
        /// The list of stores for this payment method
        /// </summary>
        /// <value>The list of stores for this payment method</value>
        [DataMember(Name = "storeIds", EmitDefaultValue = false)]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePaymentMethodInfo {\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  CustomRoutingFlags: ").Append(CustomRoutingFlags).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
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
            return this.Equals(input as UpdatePaymentMethodInfo);
        }

        /// <summary>
        /// Returns true if UpdatePaymentMethodInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePaymentMethodInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePaymentMethodInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    input.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.CustomRoutingFlags == input.CustomRoutingFlags ||
                    this.CustomRoutingFlags != null &&
                    input.CustomRoutingFlags != null &&
                    this.CustomRoutingFlags.SequenceEqual(input.CustomRoutingFlags)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    (this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    input.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
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
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.CustomRoutingFlags != null)
                {
                    hashCode = (hashCode * 59) + this.CustomRoutingFlags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.ShopperStatement != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperStatement.GetHashCode();
                }
                if (this.StoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.StoreIds.GetHashCode();
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
