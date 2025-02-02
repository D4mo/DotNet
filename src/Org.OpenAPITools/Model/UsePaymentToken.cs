/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Payment token usage details.
    /// </summary>
    [DataContract]
    public partial class UsePaymentToken : IEquatable<UsePaymentToken>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name = "function", EmitDefaultValue = false)]
        public CardFunction? Function { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsePaymentToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsePaymentToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsePaymentToken" /> class.
        /// </summary>
        /// <param name="value">Client-supplied payment token value. (required).</param>
        /// <param name="tokenOriginStoreId">The ID of a same store (or) sibling store in a hierarchy for which the token was originally created..</param>
        /// <param name="function">function.</param>
        /// <param name="securityCode">Card verification value/number..</param>
        /// <param name="expiryDate">expiryDate.</param>
        public UsePaymentToken(string value = default(string), string tokenOriginStoreId = default(string), CardFunction function = default(CardFunction), string securityCode = default(string), Expiration expiryDate = default(Expiration))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for UsePaymentToken and cannot be null");
            this.TokenOriginStoreId = tokenOriginStoreId;
            this.Function = function;
            this.SecurityCode = securityCode;
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Client-supplied payment token value.
        /// </summary>
        /// <value>Client-supplied payment token value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The ID of a same store (or) sibling store in a hierarchy for which the token was originally created.
        /// </summary>
        /// <value>The ID of a same store (or) sibling store in a hierarchy for which the token was originally created.</value>
        [DataMember(Name = "tokenOriginStoreId", EmitDefaultValue = false)]
        public string TokenOriginStoreId { get; set; }

        /// <summary>
        /// Card verification value/number.
        /// </summary>
        /// <value>Card verification value/number.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public Expiration ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsePaymentToken {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TokenOriginStoreId: ").Append(TokenOriginStoreId).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsePaymentToken);
        }

        /// <summary>
        /// Returns true if UsePaymentToken instances are equal
        /// </summary>
        /// <param name="input">Instance of UsePaymentToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsePaymentToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.TokenOriginStoreId == input.TokenOriginStoreId ||
                    (this.TokenOriginStoreId != null &&
                    this.TokenOriginStoreId.Equals(input.TokenOriginStoreId))
                ) && 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.SecurityCode == input.SecurityCode ||
                    (this.SecurityCode != null &&
                    this.SecurityCode.Equals(input.SecurityCode))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.TokenOriginStoreId != null)
                    hashCode = hashCode * 59 + this.TokenOriginStoreId.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.SecurityCode != null)
                    hashCode = hashCode * 59 + this.SecurityCode.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
            // Value (string) pattern
            Regex regexValue = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexValue.Match(this.Value).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must match a pattern of " + regexValue, new [] { "Value" });
            }

            // TokenOriginStoreId (string) maxLength
            if(this.TokenOriginStoreId != null && this.TokenOriginStoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenOriginStoreId, length must be less than 20.", new [] { "TokenOriginStoreId" });
            }

            // SecurityCode (string) maxLength
            if(this.SecurityCode != null && this.SecurityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be less than 4.", new [] { "SecurityCode" });
            }

            // SecurityCode (string) minLength
            if(this.SecurityCode != null && this.SecurityCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be greater than 3.", new [] { "SecurityCode" });
            }

            yield break;
        }
    }
}
