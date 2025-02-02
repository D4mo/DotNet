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
    /// DynamicPricingAllOf
    /// </summary>
    [DataContract]
    public partial class DynamicPricingAllOf : IEquatable<DynamicPricingAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPricingAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicPricingAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPricingAllOf" /> class.
        /// </summary>
        /// <param name="foreignCurrency">The currency code to convert for dynamic pricing in ISO 4217 currency code format. (required).</param>
        /// <param name="foreignAmount">Foreign amount. (required).</param>
        public DynamicPricingAllOf(string foreignCurrency = default(string), string foreignAmount = default(string))
        {
            // to ensure "foreignCurrency" is required (not null)
            this.ForeignCurrency = foreignCurrency ?? throw new ArgumentNullException("foreignCurrency is a required property for DynamicPricingAllOf and cannot be null");
            // to ensure "foreignAmount" is required (not null)
            this.ForeignAmount = foreignAmount ?? throw new ArgumentNullException("foreignAmount is a required property for DynamicPricingAllOf and cannot be null");
        }

        /// <summary>
        /// The currency code to convert for dynamic pricing in ISO 4217 currency code format.
        /// </summary>
        /// <value>The currency code to convert for dynamic pricing in ISO 4217 currency code format.</value>
        [DataMember(Name = "foreignCurrency", EmitDefaultValue = false)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Foreign amount.
        /// </summary>
        /// <value>Foreign amount.</value>
        [DataMember(Name = "foreignAmount", EmitDefaultValue = false)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicPricingAllOf {\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
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
            return this.Equals(input as DynamicPricingAllOf);
        }

        /// <summary>
        /// Returns true if DynamicPricingAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicPricingAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicPricingAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForeignCurrency == input.ForeignCurrency ||
                    (this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(input.ForeignCurrency))
                ) && 
                (
                    this.ForeignAmount == input.ForeignAmount ||
                    (this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(input.ForeignAmount))
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
                if (this.ForeignCurrency != null)
                    hashCode = hashCode * 59 + this.ForeignCurrency.GetHashCode();
                if (this.ForeignAmount != null)
                    hashCode = hashCode * 59 + this.ForeignAmount.GetHashCode();
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
            // ForeignCurrency (string) pattern
            Regex regexForeignCurrency = new Regex(@"([A-Z]{3})|([0-9]{3})", RegexOptions.CultureInvariant);
            if (false == regexForeignCurrency.Match(this.ForeignCurrency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignCurrency, must match a pattern of " + regexForeignCurrency, new [] { "ForeignCurrency" });
            }

            // ForeignAmount (string) pattern
            Regex regexForeignAmount = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexForeignAmount.Match(this.ForeignAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignAmount, must match a pattern of " + regexForeignAmount, new [] { "ForeignAmount" });
            }

            yield break;
        }
    }
}
