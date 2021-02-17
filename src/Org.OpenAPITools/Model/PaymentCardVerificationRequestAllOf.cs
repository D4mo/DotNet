/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.1.0.20210122.001
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
    /// PaymentCardVerificationRequestAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentCardVerificationRequestAllOf : IEquatable<PaymentCardVerificationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardVerificationRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardVerificationRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardVerificationRequestAllOf" /> class.
        /// </summary>
        /// <param name="paymentCard">paymentCard (required).</param>
        public PaymentCardVerificationRequestAllOf(PaymentCard paymentCard = default(PaymentCard))
        {
            // to ensure "paymentCard" is required (not null)
            this.PaymentCard = paymentCard ?? throw new ArgumentNullException("paymentCard is a required property for PaymentCardVerificationRequestAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name = "paymentCard", EmitDefaultValue = false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardVerificationRequestAllOf {\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
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
            return this.Equals(input as PaymentCardVerificationRequestAllOf);
        }

        /// <summary>
        /// Returns true if PaymentCardVerificationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardVerificationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardVerificationRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentCard == input.PaymentCard ||
                    (this.PaymentCard != null &&
                    this.PaymentCard.Equals(input.PaymentCard))
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
                if (this.PaymentCard != null)
                    hashCode = hashCode * 59 + this.PaymentCard.GetHashCode();
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
