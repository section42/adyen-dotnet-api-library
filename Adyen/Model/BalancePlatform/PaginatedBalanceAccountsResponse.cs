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
    /// PaginatedBalanceAccountsResponse
    /// </summary>
    [DataContract(Name = "PaginatedBalanceAccountsResponse")]
    public partial class PaginatedBalanceAccountsResponse : IEquatable<PaginatedBalanceAccountsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedBalanceAccountsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginatedBalanceAccountsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedBalanceAccountsResponse" /> class.
        /// </summary>
        /// <param name="balanceAccounts">List of balance accounts. (required).</param>
        /// <param name="hasNext">Indicates whether there are more items on the next page. (required).</param>
        /// <param name="hasPrevious">Indicates whether there are more items on the previous page. (required).</param>
        public PaginatedBalanceAccountsResponse(List<BalanceAccount> balanceAccounts = default(List<BalanceAccount>), bool hasNext = default(bool), bool hasPrevious = default(bool))
        {
            this.BalanceAccounts = balanceAccounts;
            this.HasNext = hasNext;
            this.HasPrevious = hasPrevious;
        }

        /// <summary>
        /// List of balance accounts.
        /// </summary>
        /// <value>List of balance accounts.</value>
        [DataMember(Name = "balanceAccounts", IsRequired = false, EmitDefaultValue = false)]
        public List<BalanceAccount> BalanceAccounts { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginatedBalanceAccountsResponse {\n");
            sb.Append("  BalanceAccounts: ").Append(BalanceAccounts).Append("\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
            sb.Append("  HasPrevious: ").Append(HasPrevious).Append("\n");
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
            return this.Equals(input as PaginatedBalanceAccountsResponse);
        }

        /// <summary>
        /// Returns true if PaginatedBalanceAccountsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedBalanceAccountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedBalanceAccountsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalanceAccounts == input.BalanceAccounts ||
                    this.BalanceAccounts != null &&
                    input.BalanceAccounts != null &&
                    this.BalanceAccounts.SequenceEqual(input.BalanceAccounts)
                ) && 
                (
                    this.HasNext == input.HasNext ||
                    this.HasNext.Equals(input.HasNext)
                ) && 
                (
                    this.HasPrevious == input.HasPrevious ||
                    this.HasPrevious.Equals(input.HasPrevious)
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
                if (this.BalanceAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccounts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasNext.GetHashCode();
                hashCode = (hashCode * 59) + this.HasPrevious.GetHashCode();
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