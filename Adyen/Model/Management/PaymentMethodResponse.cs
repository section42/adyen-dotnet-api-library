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
    /// PaymentMethodResponse
    /// </summary>
    [DataContract(Name = "PaymentMethodResponse")]
    public partial class PaymentMethodResponse : IEquatable<PaymentMethodResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines TypesWithErrors
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesWithErrorsEnum
        {
            /// <summary>
            /// Enum Alipay for value: alipay
            /// </summary>
            [EnumMember(Value = "alipay")]
            Alipay = 1,

            /// <summary>
            /// Enum Amex for value: amex
            /// </summary>
            [EnumMember(Value = "amex")]
            Amex = 2,

            /// <summary>
            /// Enum Applepay for value: applepay
            /// </summary>
            [EnumMember(Value = "applepay")]
            Applepay = 3,

            /// <summary>
            /// Enum Bcmc for value: bcmc
            /// </summary>
            [EnumMember(Value = "bcmc")]
            Bcmc = 4,

            /// <summary>
            /// Enum Blik for value: blik
            /// </summary>
            [EnumMember(Value = "blik")]
            Blik = 5,

            /// <summary>
            /// Enum Cartebancaire for value: cartebancaire
            /// </summary>
            [EnumMember(Value = "cartebancaire")]
            Cartebancaire = 6,

            /// <summary>
            /// Enum Cup for value: cup
            /// </summary>
            [EnumMember(Value = "cup")]
            Cup = 7,

            /// <summary>
            /// Enum Diners for value: diners
            /// </summary>
            [EnumMember(Value = "diners")]
            Diners = 8,

            /// <summary>
            /// Enum DirectEbanking for value: directEbanking
            /// </summary>
            [EnumMember(Value = "directEbanking")]
            DirectEbanking = 9,

            /// <summary>
            /// Enum DirectdebitGB for value: directdebit_GB
            /// </summary>
            [EnumMember(Value = "directdebit_GB")]
            DirectdebitGB = 10,

            /// <summary>
            /// Enum Discover for value: discover
            /// </summary>
            [EnumMember(Value = "discover")]
            Discover = 11,

            /// <summary>
            /// Enum EbankingFI for value: ebanking_FI
            /// </summary>
            [EnumMember(Value = "ebanking_FI")]
            EbankingFI = 12,

            /// <summary>
            /// Enum EftposAustralia for value: eftpos_australia
            /// </summary>
            [EnumMember(Value = "eftpos_australia")]
            EftposAustralia = 13,

            /// <summary>
            /// Enum Elo for value: elo
            /// </summary>
            [EnumMember(Value = "elo")]
            Elo = 14,

            /// <summary>
            /// Enum Elocredit for value: elocredit
            /// </summary>
            [EnumMember(Value = "elocredit")]
            Elocredit = 15,

            /// <summary>
            /// Enum Elodebit for value: elodebit
            /// </summary>
            [EnumMember(Value = "elodebit")]
            Elodebit = 16,

            /// <summary>
            /// Enum Girocard for value: girocard
            /// </summary>
            [EnumMember(Value = "girocard")]
            Girocard = 17,

            /// <summary>
            /// Enum Giropay for value: giropay
            /// </summary>
            [EnumMember(Value = "giropay")]
            Giropay = 18,

            /// <summary>
            /// Enum Googlepay for value: googlepay
            /// </summary>
            [EnumMember(Value = "googlepay")]
            Googlepay = 19,

            /// <summary>
            /// Enum Hiper for value: hiper
            /// </summary>
            [EnumMember(Value = "hiper")]
            Hiper = 20,

            /// <summary>
            /// Enum Hipercard for value: hipercard
            /// </summary>
            [EnumMember(Value = "hipercard")]
            Hipercard = 21,

            /// <summary>
            /// Enum Ideal for value: ideal
            /// </summary>
            [EnumMember(Value = "ideal")]
            Ideal = 22,

            /// <summary>
            /// Enum InteracCard for value: interac_card
            /// </summary>
            [EnumMember(Value = "interac_card")]
            InteracCard = 23,

            /// <summary>
            /// Enum Jcb for value: jcb
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb = 24,

            /// <summary>
            /// Enum Klarna for value: klarna
            /// </summary>
            [EnumMember(Value = "klarna")]
            Klarna = 25,

            /// <summary>
            /// Enum KlarnaAccount for value: klarna_account
            /// </summary>
            [EnumMember(Value = "klarna_account")]
            KlarnaAccount = 26,

            /// <summary>
            /// Enum KlarnaPaynow for value: klarna_paynow
            /// </summary>
            [EnumMember(Value = "klarna_paynow")]
            KlarnaPaynow = 27,

            /// <summary>
            /// Enum Maestro for value: maestro
            /// </summary>
            [EnumMember(Value = "maestro")]
            Maestro = 28,

            /// <summary>
            /// Enum Mbway for value: mbway
            /// </summary>
            [EnumMember(Value = "mbway")]
            Mbway = 29,

            /// <summary>
            /// Enum Mc for value: mc
            /// </summary>
            [EnumMember(Value = "mc")]
            Mc = 30,

            /// <summary>
            /// Enum Mcdebit for value: mcdebit
            /// </summary>
            [EnumMember(Value = "mcdebit")]
            Mcdebit = 31,

            /// <summary>
            /// Enum MealVoucherFR for value: mealVoucher_FR
            /// </summary>
            [EnumMember(Value = "mealVoucher_FR")]
            MealVoucherFR = 32,

            /// <summary>
            /// Enum Mobilepay for value: mobilepay
            /// </summary>
            [EnumMember(Value = "mobilepay")]
            Mobilepay = 33,

            /// <summary>
            /// Enum Multibanco for value: multibanco
            /// </summary>
            [EnumMember(Value = "multibanco")]
            Multibanco = 34,

            /// <summary>
            /// Enum Paypal for value: paypal
            /// </summary>
            [EnumMember(Value = "paypal")]
            Paypal = 35,

            /// <summary>
            /// Enum Payshop for value: payshop
            /// </summary>
            [EnumMember(Value = "payshop")]
            Payshop = 36,

            /// <summary>
            /// Enum Swish for value: swish
            /// </summary>
            [EnumMember(Value = "swish")]
            Swish = 37,

            /// <summary>
            /// Enum Trustly for value: trustly
            /// </summary>
            [EnumMember(Value = "trustly")]
            Trustly = 38,

            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 39,

            /// <summary>
            /// Enum Visadebit for value: visadebit
            /// </summary>
            [EnumMember(Value = "visadebit")]
            Visadebit = 40,

            /// <summary>
            /// Enum Vpay for value: vpay
            /// </summary>
            [EnumMember(Value = "vpay")]
            Vpay = 41,

            /// <summary>
            /// Enum Wechatpay for value: wechatpay
            /// </summary>
            [EnumMember(Value = "wechatpay")]
            Wechatpay = 42,

            /// <summary>
            /// Enum WechatpayPos for value: wechatpay_pos
            /// </summary>
            [EnumMember(Value = "wechatpay_pos")]
            WechatpayPos = 43

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="data">Payment methods details..</param>
        /// <param name="itemsTotal">Total number of items. (required).</param>
        /// <param name="pagesTotal">Total number of pages. (required).</param>
        /// <param name="typesWithErrors">Payment method types with errors..</param>
        public PaymentMethodResponse(PaginationLinks links = default(PaginationLinks), List<PaymentMethodWrapper> data = default(List<PaymentMethodWrapper>), int? itemsTotal = default(int?), int? pagesTotal = default(int?), List<TypesWithErrorsEnum> typesWithErrors = default(List<TypesWithErrorsEnum>))
        {
            this.ItemsTotal = itemsTotal;
            this.PagesTotal = pagesTotal;
            this.Links = links;
            this.Data = data;
            this.TypesWithErrors = typesWithErrors;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public PaginationLinks Links { get; set; }

        /// <summary>
        /// Payment methods details.
        /// </summary>
        /// <value>Payment methods details.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<PaymentMethodWrapper> Data { get; set; }

        public class PaymentMethodWrapper{
            public PaymentMethod PaymentMethod { get; set; }
        }
        
        /// <summary>
        /// Total number of items.
        /// </summary>
        /// <value>Total number of items.</value>
        [DataMember(Name = "itemsTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? ItemsTotal { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        /// <value>Total number of pages.</value>
        [DataMember(Name = "pagesTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? PagesTotal { get; set; }

        /// <summary>
        /// Payment method types with errors.
        /// </summary>
        /// <value>Payment method types with errors.</value>
        [DataMember(Name = "typesWithErrors", EmitDefaultValue = false)]
        public List<PaymentMethodResponse.TypesWithErrorsEnum> TypesWithErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
            sb.Append("  PagesTotal: ").Append(PagesTotal).Append("\n");
            sb.Append("  TypesWithErrors: ").Append(TypesWithErrors).Append("\n");
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
            return this.Equals(input as PaymentMethodResponse);
        }

        /// <summary>
        /// Returns true if PaymentMethodResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.ItemsTotal == input.ItemsTotal ||
                    this.ItemsTotal.Equals(input.ItemsTotal)
                ) && 
                (
                    this.PagesTotal == input.PagesTotal ||
                    this.PagesTotal.Equals(input.PagesTotal)
                ) && 
                (
                    this.TypesWithErrors == input.TypesWithErrors ||
                    this.TypesWithErrors != null &&
                    input.TypesWithErrors != null &&
                    this.TypesWithErrors.SequenceEqual(input.TypesWithErrors)
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemsTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.PagesTotal.GetHashCode();
                if (this.TypesWithErrors != null)
                {
                    hashCode = (hashCode * 59) + this.TypesWithErrors.GetHashCode();
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
