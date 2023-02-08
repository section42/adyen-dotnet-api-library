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
    /// BalanceAccountUpdateRequest
    /// </summary>
    [DataContract(Name = "BalanceAccountUpdateRequest")]
    public partial class BalanceAccountUpdateRequest : IEquatable<BalanceAccountUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is **active**.  Possible values: **active**, **inactive**, **closed**, **suspended**.
        /// </summary>
        /// <value>The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is **active**.  Possible values: **active**, **inactive**, **closed**, **suspended**.</value>
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
        /// The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is **active**.  Possible values: **active**, **inactive**, **closed**, **suspended**.
        /// </summary>
        /// <value>The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is **active**.  Possible values: **active**, **inactive**, **closed**, **suspended**.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceAccountUpdateRequest" /> class.
        /// </summary>
        /// <param name="accountHolderId">The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account..</param>
        /// <param name="defaultCurrencyCode">The default currency code of this balance account, in three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) format.  The default value is **EUR**..</param>
        /// <param name="description">A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder..</param>
        /// <param name="reference">Your reference to the balance account, maximum 150 characters..</param>
        /// <param name="status">The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is **active**.  Possible values: **active**, **inactive**, **closed**, **suspended**..</param>
        /// <param name="timeZone">The [time zone](https://www.iana.org/time-zones) of the balance account. For example, **Europe/Amsterdam**. If not set, the time zone of the account holder will be used. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)..</param>
        public BalanceAccountUpdateRequest(string accountHolderId = default(string), string defaultCurrencyCode = default(string), string description = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), string timeZone = default(string))
        {
            this.AccountHolderId = accountHolderId;
            this.DefaultCurrencyCode = defaultCurrencyCode;
            this.Description = description;
            this.Reference = reference;
            this.Status = status;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account.
        /// </summary>
        /// <value>The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account.</value>
        [DataMember(Name = "accountHolderId", EmitDefaultValue = false)]
        public string AccountHolderId { get; set; }

        /// <summary>
        /// The default currency code of this balance account, in three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) format.  The default value is **EUR**.
        /// </summary>
        /// <value>The default currency code of this balance account, in three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) format.  The default value is **EUR**.</value>
        [DataMember(Name = "defaultCurrencyCode", EmitDefaultValue = false)]
        public string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder.
        /// </summary>
        /// <value>A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Your reference to the balance account, maximum 150 characters.
        /// </summary>
        /// <value>Your reference to the balance account, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The [time zone](https://www.iana.org/time-zones) of the balance account. For example, **Europe/Amsterdam**. If not set, the time zone of the account holder will be used. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).
        /// </summary>
        /// <value>The [time zone](https://www.iana.org/time-zones) of the balance account. For example, **Europe/Amsterdam**. If not set, the time zone of the account holder will be used. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceAccountUpdateRequest {\n");
            sb.Append("  AccountHolderId: ").Append(AccountHolderId).Append("\n");
            sb.Append("  DefaultCurrencyCode: ").Append(DefaultCurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as BalanceAccountUpdateRequest);
        }

        /// <summary>
        /// Returns true if BalanceAccountUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceAccountUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceAccountUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderId == input.AccountHolderId ||
                    (this.AccountHolderId != null &&
                    this.AccountHolderId.Equals(input.AccountHolderId))
                ) && 
                (
                    this.DefaultCurrencyCode == input.DefaultCurrencyCode ||
                    (this.DefaultCurrencyCode != null &&
                    this.DefaultCurrencyCode.Equals(input.DefaultCurrencyCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.AccountHolderId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderId.GetHashCode();
                }
                if (this.DefaultCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCurrencyCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
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