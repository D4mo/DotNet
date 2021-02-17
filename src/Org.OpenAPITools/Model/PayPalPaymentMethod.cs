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
    /// Payment method containing PayPal information.
    /// </summary>
    [DataContract]
    public partial class PayPalPaymentMethod : IEquatable<PayPalPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayPalPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalPaymentMethod" /> class.
        /// </summary>
        /// <param name="payPal">payPal (required).</param>
        public PayPalPaymentMethod(PayPal payPal = default(PayPal))
        {
            // to ensure "payPal" is required (not null)
            this.PayPal = payPal ?? throw new ArgumentNullException("payPal is a required property for PayPalPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PayPal
        /// </summary>
        [DataMember(Name = "payPal", EmitDefaultValue = false)]
        public PayPal PayPal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPalPaymentMethod {\n");
            sb.Append("  PayPal: ").Append(PayPal).Append("\n");
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
            return this.Equals(input as PayPalPaymentMethod);
        }

        /// <summary>
        /// Returns true if PayPalPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayPalPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPalPaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayPal == input.PayPal ||
                    (this.PayPal != null &&
                    this.PayPal.Equals(input.PayPal))
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
                if (this.PayPal != null)
                    hashCode = hashCode * 59 + this.PayPal.GetHashCode();
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
