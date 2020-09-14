/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.13.0.20200810.001
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
    /// Currency Conversion Response.
    /// </summary>
    [DataContract]
    public partial class CurrencyConversionResponse : IEquatable<CurrencyConversionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConversionResponse" /> class.
        /// </summary>
        /// <param name="dccApplied">Dynamic Currency Conversion Applied..</param>
        /// <param name="exchangeRateDetails">exchangeRateDetails.</param>
        public CurrencyConversionResponse(bool dccApplied = default(bool), ExchangeRateDetails exchangeRateDetails = default(ExchangeRateDetails))
        {
            this.DccApplied = dccApplied;
            this.ExchangeRateDetails = exchangeRateDetails;
        }

        /// <summary>
        /// Dynamic Currency Conversion Applied.
        /// </summary>
        /// <value>Dynamic Currency Conversion Applied.</value>
        [DataMember(Name = "dccApplied", EmitDefaultValue = false)]
        public bool DccApplied { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRateDetails
        /// </summary>
        [DataMember(Name = "exchangeRateDetails", EmitDefaultValue = false)]
        public ExchangeRateDetails ExchangeRateDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyConversionResponse {\n");
            sb.Append("  DccApplied: ").Append(DccApplied).Append("\n");
            sb.Append("  ExchangeRateDetails: ").Append(ExchangeRateDetails).Append("\n");
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
            return this.Equals(input as CurrencyConversionResponse);
        }

        /// <summary>
        /// Returns true if CurrencyConversionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyConversionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyConversionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DccApplied == input.DccApplied ||
                    this.DccApplied.Equals(input.DccApplied)
                ) && 
                (
                    this.ExchangeRateDetails == input.ExchangeRateDetails ||
                    (this.ExchangeRateDetails != null &&
                    this.ExchangeRateDetails.Equals(input.ExchangeRateDetails))
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
                hashCode = hashCode * 59 + this.DccApplied.GetHashCode();
                if (this.ExchangeRateDetails != null)
                    hashCode = hashCode * 59 + this.ExchangeRateDetails.GetHashCode();
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
