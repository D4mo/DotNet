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
    /// PaymentTokenCreditTransactionAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentTokenCreditTransactionAllOf :  IEquatable<PaymentTokenCreditTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenCreditTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTokenCreditTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenCreditTransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        public PaymentTokenCreditTransactionAllOf(PaymentTokenPaymentMethod paymentMethod = default(PaymentTokenPaymentMethod), CurrencyConversion currencyConversion = default(CurrencyConversion))
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentTokenCreditTransactionAllOf and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            
            this.CurrencyConversion = currencyConversion;
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=true)]
        public PaymentTokenPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name="currencyConversion", EmitDefaultValue=false)]
        public CurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenCreditTransactionAllOf {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
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
            return this.Equals(input as PaymentTokenCreditTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PaymentTokenCreditTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenCreditTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenCreditTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    (this.CurrencyConversion != null &&
                    this.CurrencyConversion.Equals(input.CurrencyConversion))
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.CurrencyConversion != null)
                    hashCode = hashCode * 59 + this.CurrencyConversion.GetHashCode();
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
