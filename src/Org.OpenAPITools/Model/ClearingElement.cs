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
    /// Holds brand specific clearing information.
    /// </summary>
    [DataContract]
    public partial class ClearingElement : IEquatable<ClearingElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearingElement" /> class.
        /// </summary>
        /// <param name="brand">Contains the brand of the card..</param>
        /// <param name="value">Holds the total clearing value computed for a specific brand..</param>
        /// <param name="count">Specifies the amount of clearing elements for a given brand..</param>
        public ClearingElement(string brand = default(string), long value = default(long), int count = default(int))
        {
            this.Brand = brand;
            this.Value = value;
            this.Count = count;
        }

        /// <summary>
        /// Contains the brand of the card.
        /// </summary>
        /// <value>Contains the brand of the card.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Holds the total clearing value computed for a specific brand.
        /// </summary>
        /// <value>Holds the total clearing value computed for a specific brand.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public long Value { get; set; }

        /// <summary>
        /// Specifies the amount of clearing elements for a given brand.
        /// </summary>
        /// <value>Specifies the amount of clearing elements for a given brand.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearingElement {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as ClearingElement);
        }

        /// <summary>
        /// Returns true if ClearingElement instances are equal
        /// </summary>
        /// <param name="input">Instance of ClearingElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClearingElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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
