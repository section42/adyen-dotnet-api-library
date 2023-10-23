/*
* Management API
*
*
* The version of the OpenAPI document: 3
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
    /// Surcharge
    /// </summary>
    [DataContract(Name = "Surcharge")]
    public partial class Surcharge : IEquatable<Surcharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Surcharge" /> class.
        /// </summary>
        /// <param name="askConfirmation">Show the surcharge details on the terminal, so the shopper can confirm..</param>
        /// <param name="configurations">Surcharge fees or percentages for specific payment methods, funding sources (credit or debit), and currencies..</param>
        public Surcharge(bool? askConfirmation = default(bool?), List<ModelConfiguration> configurations = default(List<ModelConfiguration>))
        {
            this.AskConfirmation = askConfirmation;
            this.Configurations = configurations;
        }

        /// <summary>
        /// Show the surcharge details on the terminal, so the shopper can confirm.
        /// </summary>
        /// <value>Show the surcharge details on the terminal, so the shopper can confirm.</value>
        [DataMember(Name = "askConfirmation", EmitDefaultValue = false)]
        public bool? AskConfirmation { get; set; }

        /// <summary>
        /// Surcharge fees or percentages for specific payment methods, funding sources (credit or debit), and currencies.
        /// </summary>
        /// <value>Surcharge fees or percentages for specific payment methods, funding sources (credit or debit), and currencies.</value>
        [DataMember(Name = "configurations", EmitDefaultValue = false)]
        public List<ModelConfiguration> Configurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Surcharge {\n");
            sb.Append("  AskConfirmation: ").Append(AskConfirmation).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
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
            return this.Equals(input as Surcharge);
        }

        /// <summary>
        /// Returns true if Surcharge instances are equal
        /// </summary>
        /// <param name="input">Instance of Surcharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Surcharge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AskConfirmation == input.AskConfirmation ||
                    this.AskConfirmation.Equals(input.AskConfirmation)
                ) && 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
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
                hashCode = (hashCode * 59) + this.AskConfirmation.GetHashCode();
                if (this.Configurations != null)
                {
                    hashCode = (hashCode * 59) + this.Configurations.GetHashCode();
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
