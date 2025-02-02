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
    /// PaymentTokenInfoLookupRequestAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentTokenInfoLookupRequestAllOf : IEquatable<PaymentTokenInfoLookupRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenInfoLookupRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTokenInfoLookupRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenInfoLookupRequestAllOf" /> class.
        /// </summary>
        /// <param name="paymentToken">paymentToken (required).</param>
        public PaymentTokenInfoLookupRequestAllOf(UsePaymentToken paymentToken = default(UsePaymentToken))
        {
            // to ensure "paymentToken" is required (not null)
            this.PaymentToken = paymentToken ?? throw new ArgumentNullException("paymentToken is a required property for PaymentTokenInfoLookupRequestAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name = "paymentToken", EmitDefaultValue = false)]
        public UsePaymentToken PaymentToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenInfoLookupRequestAllOf {\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
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
            return this.Equals(input as PaymentTokenInfoLookupRequestAllOf);
        }

        /// <summary>
        /// Returns true if PaymentTokenInfoLookupRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenInfoLookupRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenInfoLookupRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
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
                if (this.PaymentToken != null)
                    hashCode = hashCode * 59 + this.PaymentToken.GetHashCode();
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
