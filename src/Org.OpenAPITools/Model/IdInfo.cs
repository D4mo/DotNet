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
    /// Identification information.
    /// </summary>
    [DataContract]
    public partial class IdInfo : IEquatable<IdInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdInfo" /> class.
        /// </summary>
        /// <param name="idType">Identification type..</param>
        /// <param name="idData">Identification data..</param>
        public IdInfo(string idType = default(string), string idData = default(string))
        {
            this.IdType = idType;
            this.IdData = idData;
        }

        /// <summary>
        /// Identification type.
        /// </summary>
        /// <value>Identification type.</value>
        [DataMember(Name = "idType", EmitDefaultValue = false)]
        public string IdType { get; set; }

        /// <summary>
        /// Identification data.
        /// </summary>
        /// <value>Identification data.</value>
        [DataMember(Name = "idData", EmitDefaultValue = false)]
        public string IdData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdInfo {\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IdData: ").Append(IdData).Append("\n");
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
            return this.Equals(input as IdInfo);
        }

        /// <summary>
        /// Returns true if IdInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IdInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.IdData == input.IdData ||
                    (this.IdData != null &&
                    this.IdData.Equals(input.IdData))
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
                if (this.IdType != null)
                    hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.IdData != null)
                    hashCode = hashCode * 59 + this.IdData.GetHashCode();
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
            // IdType (string) maxLength
            if(this.IdType != null && this.IdType.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdType, length must be less than 2.", new [] { "IdType" });
            }

            // IdData (string) maxLength
            if(this.IdData != null && this.IdData.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdData, length must be less than 35.", new [] { "IdData" });
            }

            // IdData (string) minLength
            if(this.IdData != null && this.IdData.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdData, length must be greater than 1.", new [] { "IdData" });
            }

            yield break;
        }
    }
}
