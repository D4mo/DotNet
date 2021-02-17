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
    /// Rate and corresponding amount being applied to purchase cards, for instance in the form of taxes or discounts.
    /// </summary>
    [DataContract]
    public partial class AdditionalAmountRate : IEquatable<AdditionalAmountRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalAmountRate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalAmountRate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalAmountRate" /> class.
        /// </summary>
        /// <param name="amount">Amount in 3 decimal 12 bytes total digit. (required).</param>
        /// <param name="rate">Rate in 3 decimal 12 bytes total digit. (required).</param>
        public AdditionalAmountRate(decimal amount = default(decimal), decimal rate = default(decimal))
        {
            // to ensure "amount" is required (not null)
            this.Amount = amount;
            // to ensure "rate" is required (not null)
            this.Rate = rate;
        }

        /// <summary>
        /// Amount in 3 decimal 12 bytes total digit.
        /// </summary>
        /// <value>Amount in 3 decimal 12 bytes total digit.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Rate in 3 decimal 12 bytes total digit.
        /// </summary>
        /// <value>Rate in 3 decimal 12 bytes total digit.</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalAmountRate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as AdditionalAmountRate);
        }

        /// <summary>
        /// Returns true if AdditionalAmountRate instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalAmountRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalAmountRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
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
