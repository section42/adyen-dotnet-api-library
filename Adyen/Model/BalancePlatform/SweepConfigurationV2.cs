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
    /// SweepConfigurationV2
    /// </summary>
    [DataContract(Name = "SweepConfigurationV2")]
    public partial class SweepConfigurationV2 : IEquatable<SweepConfigurationV2>, IValidatableObject
    {
        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }


        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Pull for value: pull
            /// </summary>
            [EnumMember(Value = "pull")]
            Pull = 1,

            /// <summary>
            /// Enum Push for value: push
            /// </summary>
            [EnumMember(Value = "push")]
            Push = 2

        }


        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SweepConfigurationV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances). (required).</param>
        /// <param name="description">The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters..</param>
        /// <param name="schedule">schedule (required).</param>
        /// <param name="status">The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   .</param>
        /// <param name="sweepAmount">sweepAmount.</param>
        /// <param name="targetAmount">targetAmount.</param>
        /// <param name="triggerAmount">triggerAmount.</param>
        /// <param name="type">The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account. (default to TypeEnum.Push).</param>
        public SweepConfigurationV2(SweepCounterparty counterparty = default(SweepCounterparty), string currency = default(string), string description = default(string), SweepConfigurationV2Schedule schedule = default(SweepConfigurationV2Schedule), StatusEnum? status = default(StatusEnum?), Amount sweepAmount = default(Amount), Amount targetAmount = default(Amount), Amount triggerAmount = default(Amount), TypeEnum? type = TypeEnum.Push)
        {
            this.Counterparty = counterparty;
            this.Currency = currency;
            this.Schedule = schedule;
            this.Description = description;
            this.Status = status;
            this.SweepAmount = sweepAmount;
            this.TargetAmount = targetAmount;
            this.TriggerAmount = triggerAmount;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = false, EmitDefaultValue = true)]
        public SweepCounterparty Counterparty { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.
        /// </summary>
        /// <value>The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the sweep.
        /// </summary>
        /// <value>The unique identifier of the sweep.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", IsRequired = false, EmitDefaultValue = true)]
        public SweepConfigurationV2Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets SweepAmount
        /// </summary>
        [DataMember(Name = "sweepAmount", EmitDefaultValue = false)]
        public Amount SweepAmount { get; set; }

        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        [DataMember(Name = "targetAmount", EmitDefaultValue = false)]
        public Amount TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets TriggerAmount
        /// </summary>
        [DataMember(Name = "triggerAmount", EmitDefaultValue = false)]
        public Amount TriggerAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SweepConfigurationV2 {\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SweepAmount: ").Append(SweepAmount).Append("\n");
            sb.Append("  TargetAmount: ").Append(TargetAmount).Append("\n");
            sb.Append("  TriggerAmount: ").Append(TriggerAmount).Append("\n");
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
            return this.Equals(input as SweepConfigurationV2);
        }

        /// <summary>
        /// Returns true if SweepConfigurationV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepConfigurationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepConfigurationV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SweepAmount == input.SweepAmount ||
                    (this.SweepAmount != null &&
                    this.SweepAmount.Equals(input.SweepAmount))
                ) && 
                (
                    this.TargetAmount == input.TargetAmount ||
                    (this.TargetAmount != null &&
                    this.TargetAmount.Equals(input.TargetAmount))
                ) && 
                (
                    this.TriggerAmount == input.TriggerAmount ||
                    (this.TriggerAmount != null &&
                    this.TriggerAmount.Equals(input.TriggerAmount))
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
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SweepAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SweepAmount.GetHashCode();
                }
                if (this.TargetAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAmount.GetHashCode();
                }
                if (this.TriggerAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerAmount.GetHashCode();
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