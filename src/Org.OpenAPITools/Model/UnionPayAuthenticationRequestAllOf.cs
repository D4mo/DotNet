/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.12.0.20200605.001
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
    /// UnionPayAuthenticationRequestAllOf
    /// </summary>
    [DataContract]
    public partial class UnionPayAuthenticationRequestAllOf :  IEquatable<UnionPayAuthenticationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnionPayAuthenticationRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationRequestAllOf" /> class.
        /// </summary>
        /// <param name="smsPhoneNumber">Mobile number for SMS verification. (required).</param>
        public UnionPayAuthenticationRequestAllOf(string smsPhoneNumber = default(string))
        {
            // to ensure "smsPhoneNumber" is required (not null)
            if (smsPhoneNumber == null)
            {
                throw new InvalidDataException("smsPhoneNumber is a required property for UnionPayAuthenticationRequestAllOf and cannot be null");
            }
            else
            {
                this.SmsPhoneNumber = smsPhoneNumber;
            }
            
        }
        
        /// <summary>
        /// Mobile number for SMS verification.
        /// </summary>
        /// <value>Mobile number for SMS verification.</value>
        [DataMember(Name="smsPhoneNumber", EmitDefaultValue=true)]
        public string SmsPhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnionPayAuthenticationRequestAllOf {\n");
            sb.Append("  SmsPhoneNumber: ").Append(SmsPhoneNumber).Append("\n");
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
            return this.Equals(input as UnionPayAuthenticationRequestAllOf);
        }

        /// <summary>
        /// Returns true if UnionPayAuthenticationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UnionPayAuthenticationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnionPayAuthenticationRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmsPhoneNumber == input.SmsPhoneNumber ||
                    (this.SmsPhoneNumber != null &&
                    this.SmsPhoneNumber.Equals(input.SmsPhoneNumber))
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
                if (this.SmsPhoneNumber != null)
                    hashCode = hashCode * 59 + this.SmsPhoneNumber.GetHashCode();
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

            // SmsPhoneNumber (string) minLength
            if(this.SmsPhoneNumber != null && this.SmsPhoneNumber.Length < 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SmsPhoneNumber, length must be greater than 7.", new [] { "SmsPhoneNumber" });
            }
            
            // SmsPhoneNumber (string) pattern
            Regex regexSmsPhoneNumber = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexSmsPhoneNumber.Match(this.SmsPhoneNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SmsPhoneNumber, must match a pattern of " + regexSmsPhoneNumber, new [] { "SmsPhoneNumber" });
            }

            yield break;
        }
    }

}
