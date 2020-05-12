/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.10.1.20200226.002
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
    /// Request to perform a DCC exchange rate inquiry.
    /// </summary>
    [DataContract]
    public partial class DCCExchangeRateRequest : ExchangeRateRequest,  IEquatable<DCCExchangeRateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DCCExchangeRateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DCCExchangeRateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DCCExchangeRateRequest" /> class.
        /// </summary>
        /// <param name="bin">A bank identification number (BIN) of the card to be used for DCC. (required).</param>
        /// <param name="requestType">Object name of the exchange rate request. (required).</param>
        /// <param name="baseAmount">The original amount of the merchant currency for calculation. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        public DCCExchangeRateRequest(string bin = default(string), string requestType = default(string), decimal baseAmount = default(decimal), string storeId = default(string)) : base(requestType, baseAmount, storeId)
        {
            // to ensure "bin" is required (not null)
            if (bin == null)
            {
                throw new InvalidDataException("bin is a required property for DCCExchangeRateRequest and cannot be null");
            }
            else
            {
                this.Bin = bin;
            }

        }
        
        /// <summary>
        /// A bank identification number (BIN) of the card to be used for DCC.
        /// </summary>
        /// <value>A bank identification number (BIN) of the card to be used for DCC.</value>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public string Bin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DCCExchangeRateRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DCCExchangeRateRequest);
        }

        /// <summary>
        /// Returns true if DCCExchangeRateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DCCExchangeRateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DCCExchangeRateRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Bin == input.Bin ||
                    (this.Bin != null &&
                    this.Bin.Equals(input.Bin))
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
                int hashCode = base.GetHashCode();
                if (this.Bin != null)
                    hashCode = hashCode * 59 + this.Bin.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            // Bin (string) maxLength
            if(this.Bin != null && this.Bin.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bin, length must be less than 6.", new [] { "Bin" });
            }

            // Bin (string) pattern
            Regex regexBin = new Regex(@"[0-9]{6}", RegexOptions.CultureInvariant);
            if (false == regexBin.Match(this.Bin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bin, must match a pattern of " + regexBin, new [] { "Bin" });
            }

            yield break;
        }
    }

}
