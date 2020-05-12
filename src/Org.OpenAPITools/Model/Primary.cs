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
    /// Primary
    /// </summary>
    [DataContract]
    public partial class Primary :  IEquatable<Primary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Primary" /> class.
        /// </summary>
        /// <param name="color">Hexadecimal color value..</param>
        public Primary(string color = default(string))
        {
            this.Color = color;
        }
        
        /// <summary>
        /// Hexadecimal color value.
        /// </summary>
        /// <value>Hexadecimal color value.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Primary {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(input as Primary);
        }

        /// <summary>
        /// Returns true if Primary instances are equal
        /// </summary>
        /// <param name="input">Instance of Primary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Primary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
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
            // Color (string) pattern
            Regex regexColor = new Regex(@"(^(0[xX]){1}[A-Fa-f0-9]+$)|(^#[A-Fa-f0-9]{6}$)", RegexOptions.CultureInvariant);
            if (false == regexColor.Match(this.Color).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, must match a pattern of " + regexColor, new [] { "Color" });
            }

            yield break;
        }
    }

}
