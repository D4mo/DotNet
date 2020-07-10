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
    /// Required for normal transactions except for payment with &#39;RECURRING&#39; flags.
    /// </summary>
    [DataContract]
    public partial class Expiration :  IEquatable<Expiration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expiration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Expiration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Expiration" /> class.
        /// </summary>
        /// <param name="month">Month of the card expiration date in MM format. (required).</param>
        /// <param name="year">Year of the card expiration date in YY format. (required).</param>
        public Expiration(string month = default(string), string year = default(string))
        {
            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new InvalidDataException("month is a required property for Expiration and cannot be null");
            }
            else
            {
                this.Month = month;
            }
            
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for Expiration and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            
        }
        
        /// <summary>
        /// Month of the card expiration date in MM format.
        /// </summary>
        /// <value>Month of the card expiration date in MM format.</value>
        [DataMember(Name="month", EmitDefaultValue=true)]
        public string Month { get; set; }

        /// <summary>
        /// Year of the card expiration date in YY format.
        /// </summary>
        /// <value>Year of the card expiration date in YY format.</value>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public string Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Expiration {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as Expiration);
        }

        /// <summary>
        /// Returns true if Expiration instances are equal
        /// </summary>
        /// <param name="input">Instance of Expiration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expiration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
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

            
            // Month (string) pattern
            Regex regexMonth = new Regex(@"^(0[1-9]|1[012])$", RegexOptions.CultureInvariant);
            if (false == regexMonth.Match(this.Month).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Month, must match a pattern of " + regexMonth, new [] { "Month" });
            }


            
            // Year (string) pattern
            Regex regexYear = new Regex(@"^([0-9]{2})$", RegexOptions.CultureInvariant);
            if (false == regexYear.Match(this.Year).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Year, must match a pattern of " + regexYear, new [] { "Year" });
            }

            yield break;
        }
    }

}
