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
    /// UnionPayAuthenticationUpdateRequestAllOf
    /// </summary>
    [DataContract]
    public partial class UnionPayAuthenticationUpdateRequestAllOf : IEquatable<UnionPayAuthenticationUpdateRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationUpdateRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnionPayAuthenticationUpdateRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationUpdateRequestAllOf" /> class.
        /// </summary>
        /// <param name="smsVerificationCode">Customer mobile number for SMS verification. (required).</param>
        /// <param name="securityCode">Card security code if required by merchant..</param>
        public UnionPayAuthenticationUpdateRequestAllOf(string smsVerificationCode = default(string), string securityCode = default(string))
        {
            // to ensure "smsVerificationCode" is required (not null)
            this.SmsVerificationCode = smsVerificationCode ?? throw new ArgumentNullException("smsVerificationCode is a required property for UnionPayAuthenticationUpdateRequestAllOf and cannot be null");
            this.SecurityCode = securityCode;
        }

        /// <summary>
        /// Customer mobile number for SMS verification.
        /// </summary>
        /// <value>Customer mobile number for SMS verification.</value>
        [DataMember(Name = "smsVerificationCode", EmitDefaultValue = false)]
        public string SmsVerificationCode { get; set; }

        /// <summary>
        /// Card security code if required by merchant.
        /// </summary>
        /// <value>Card security code if required by merchant.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnionPayAuthenticationUpdateRequestAllOf {\n");
            sb.Append("  SmsVerificationCode: ").Append(SmsVerificationCode).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
            return this.Equals(input as UnionPayAuthenticationUpdateRequestAllOf);
        }

        /// <summary>
        /// Returns true if UnionPayAuthenticationUpdateRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UnionPayAuthenticationUpdateRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnionPayAuthenticationUpdateRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmsVerificationCode == input.SmsVerificationCode ||
                    (this.SmsVerificationCode != null &&
                    this.SmsVerificationCode.Equals(input.SmsVerificationCode))
                ) && 
                (
                    this.SecurityCode == input.SecurityCode ||
                    (this.SecurityCode != null &&
                    this.SecurityCode.Equals(input.SecurityCode))
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
                if (this.SmsVerificationCode != null)
                    hashCode = hashCode * 59 + this.SmsVerificationCode.GetHashCode();
                if (this.SecurityCode != null)
                    hashCode = hashCode * 59 + this.SecurityCode.GetHashCode();
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
            // SmsVerificationCode (string) pattern
            Regex regexSmsVerificationCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexSmsVerificationCode.Match(this.SmsVerificationCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SmsVerificationCode, must match a pattern of " + regexSmsVerificationCode, new [] { "SmsVerificationCode" });
            }

            yield break;
        }
    }
}
