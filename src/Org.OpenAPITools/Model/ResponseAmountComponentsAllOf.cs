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
    /// ResponseAmountComponentsAllOf
    /// </summary>
    [DataContract]
    public partial class ResponseAmountComponentsAllOf : IEquatable<ResponseAmountComponentsAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAmountComponentsAllOf" /> class.
        /// </summary>
        /// <param name="convenienceFee">Amount added for proccessing or handling fees..</param>
        public ResponseAmountComponentsAllOf(decimal convenienceFee = default(decimal))
        {
            this.ConvenienceFee = convenienceFee;
        }

        /// <summary>
        /// Amount added for proccessing or handling fees.
        /// </summary>
        /// <value>Amount added for proccessing or handling fees.</value>
        [DataMember(Name = "convenienceFee", EmitDefaultValue = false)]
        public decimal ConvenienceFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAmountComponentsAllOf {\n");
            sb.Append("  ConvenienceFee: ").Append(ConvenienceFee).Append("\n");
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
            return this.Equals(input as ResponseAmountComponentsAllOf);
        }

        /// <summary>
        /// Returns true if ResponseAmountComponentsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAmountComponentsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAmountComponentsAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConvenienceFee == input.ConvenienceFee ||
                    (this.ConvenienceFee != null &&
                    this.ConvenienceFee.Equals(input.ConvenienceFee))
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
                if (this.ConvenienceFee != null)
                    hashCode = hashCode * 59 + this.ConvenienceFee.GetHashCode();
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
