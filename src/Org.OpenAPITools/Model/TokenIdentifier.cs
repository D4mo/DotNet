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
    /// Token identifier object.
    /// </summary>
    [DataContract]
    public partial class TokenIdentifier : IEquatable<TokenIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenIdentifier" /> class.
        /// </summary>
        /// <param name="tokenIdentifier">Token identifier..</param>
        public TokenIdentifier(string tokenIdentifier = default(string))
        {
            this._TokenIdentifier = tokenIdentifier;
        }

        /// <summary>
        /// Token identifier.
        /// </summary>
        /// <value>Token identifier.</value>
        [DataMember(Name = "tokenIdentifier", EmitDefaultValue = false)]
        public string _TokenIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenIdentifier {\n");
            sb.Append("  _TokenIdentifier: ").Append(_TokenIdentifier).Append("\n");
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
            return this.Equals(input as TokenIdentifier);
        }

        /// <summary>
        /// Returns true if TokenIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._TokenIdentifier == input._TokenIdentifier ||
                    (this._TokenIdentifier != null &&
                    this._TokenIdentifier.Equals(input._TokenIdentifier))
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
                if (this._TokenIdentifier != null)
                    hashCode = hashCode * 59 + this._TokenIdentifier.GetHashCode();
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
