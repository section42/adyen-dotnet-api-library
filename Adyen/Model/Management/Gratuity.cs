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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Management
{
    /// <summary>
    /// Gratuity
    /// </summary>
    [DataContract]
    public partial class Gratuity :  IEquatable<Gratuity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gratuity" /> class.
        /// </summary>
        /// <param name="allowCustomAmount">Indicates whether one of the predefined tipping options is to let the shopper enter a custom tip. If **true**, only three of the other options defined in &#x60;predefinedTipEntries&#x60; are shown..</param>
        /// <param name="currency">The currency that the tipping settings apply to..</param>
        /// <param name="predefinedTipEntries">Tipping options the shopper can choose from if &#x60;usePredefinedTipEntries&#x60; is **true**. The maximum number of predefined options is four, or three plus the option to enter a custom tip. The options can be a mix of:  - A percentage of the transaction amount. Example: **5%** - A tip amount in [minor units](https://docs.adyen.com/development-resources/currency-codes). Example: **500** for a EUR 5 tip..</param>
        /// <param name="usePredefinedTipEntries">Indicates whether the terminal shows a prompt to enter a tip (**false**), or predefined tipping options to choose from (**true**)..</param>
        public Gratuity(bool allowCustomAmount = default(bool), string currency = default(string), List<string> predefinedTipEntries = default(List<string>), bool usePredefinedTipEntries = default(bool))
        {
            this.AllowCustomAmount = allowCustomAmount;
            this.Currency = currency;
            this.PredefinedTipEntries = predefinedTipEntries;
            this.UsePredefinedTipEntries = usePredefinedTipEntries;
        }

        /// <summary>
        /// Indicates whether one of the predefined tipping options is to let the shopper enter a custom tip. If **true**, only three of the other options defined in &#x60;predefinedTipEntries&#x60; are shown.
        /// </summary>
        /// <value>Indicates whether one of the predefined tipping options is to let the shopper enter a custom tip. If **true**, only three of the other options defined in &#x60;predefinedTipEntries&#x60; are shown.</value>
        [DataMember(Name="allowCustomAmount", EmitDefaultValue=false)]
        public bool AllowCustomAmount { get; set; }

        /// <summary>
        /// The currency that the tipping settings apply to.
        /// </summary>
        /// <value>The currency that the tipping settings apply to.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Tipping options the shopper can choose from if &#x60;usePredefinedTipEntries&#x60; is **true**. The maximum number of predefined options is four, or three plus the option to enter a custom tip. The options can be a mix of:  - A percentage of the transaction amount. Example: **5%** - A tip amount in [minor units](https://docs.adyen.com/development-resources/currency-codes). Example: **500** for a EUR 5 tip.
        /// </summary>
        /// <value>Tipping options the shopper can choose from if &#x60;usePredefinedTipEntries&#x60; is **true**. The maximum number of predefined options is four, or three plus the option to enter a custom tip. The options can be a mix of:  - A percentage of the transaction amount. Example: **5%** - A tip amount in [minor units](https://docs.adyen.com/development-resources/currency-codes). Example: **500** for a EUR 5 tip.</value>
        [DataMember(Name="predefinedTipEntries", EmitDefaultValue=false)]
        public List<string> PredefinedTipEntries { get; set; }

        /// <summary>
        /// Indicates whether the terminal shows a prompt to enter a tip (**false**), or predefined tipping options to choose from (**true**).
        /// </summary>
        /// <value>Indicates whether the terminal shows a prompt to enter a tip (**false**), or predefined tipping options to choose from (**true**).</value>
        [DataMember(Name="usePredefinedTipEntries", EmitDefaultValue=false)]
        public bool UsePredefinedTipEntries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Gratuity {\n");
            sb.Append("  AllowCustomAmount: ").Append(AllowCustomAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PredefinedTipEntries: ").Append(PredefinedTipEntries).Append("\n");
            sb.Append("  UsePredefinedTipEntries: ").Append(UsePredefinedTipEntries).Append("\n");
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
            return this.Equals(input as Gratuity);
        }

        /// <summary>
        /// Returns true if Gratuity instances are equal
        /// </summary>
        /// <param name="input">Instance of Gratuity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Gratuity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowCustomAmount == input.AllowCustomAmount ||
                    (this.AllowCustomAmount != null &&
                    this.AllowCustomAmount.Equals(input.AllowCustomAmount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PredefinedTipEntries == input.PredefinedTipEntries ||
                    this.PredefinedTipEntries != null &&
                    input.PredefinedTipEntries != null &&
                    this.PredefinedTipEntries.SequenceEqual(input.PredefinedTipEntries)
                ) && 
                (
                    this.UsePredefinedTipEntries == input.UsePredefinedTipEntries ||
                    (this.UsePredefinedTipEntries != null &&
                    this.UsePredefinedTipEntries.Equals(input.UsePredefinedTipEntries))
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
                if (this.AllowCustomAmount != null)
                    hashCode = hashCode * 59 + this.AllowCustomAmount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.PredefinedTipEntries != null)
                    hashCode = hashCode * 59 + this.PredefinedTipEntries.GetHashCode();
                if (this.UsePredefinedTipEntries != null)
                    hashCode = hashCode * 59 + this.UsePredefinedTipEntries.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
