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
    /// Object that holds result from update fraud settings request.
    /// </summary>
    [DataContract]
    public partial class StoreFraudSettingsResult : IEquatable<StoreFraudSettingsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFraudSettingsResult" /> class.
        /// </summary>
        /// <param name="id">An outlet identificator..</param>
        /// <param name="blockedCardIdentifier">blockedCardIdentifier.</param>
        /// <param name="status">Status from fraud settings..</param>
        public StoreFraudSettingsResult(string id = default(string), TokenIdentifier blockedCardIdentifier = default(TokenIdentifier), string status = default(string))
        {
            this.Id = id;
            this.BlockedCardIdentifier = blockedCardIdentifier;
            this.Status = status;
        }

        /// <summary>
        /// An outlet identificator.
        /// </summary>
        /// <value>An outlet identificator.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BlockedCardIdentifier
        /// </summary>
        [DataMember(Name = "blockedCardIdentifier", EmitDefaultValue = false)]
        public TokenIdentifier BlockedCardIdentifier { get; set; }

        /// <summary>
        /// Status from fraud settings.
        /// </summary>
        /// <value>Status from fraud settings.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreFraudSettingsResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BlockedCardIdentifier: ").Append(BlockedCardIdentifier).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as StoreFraudSettingsResult);
        }

        /// <summary>
        /// Returns true if StoreFraudSettingsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreFraudSettingsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreFraudSettingsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BlockedCardIdentifier == input.BlockedCardIdentifier ||
                    (this.BlockedCardIdentifier != null &&
                    this.BlockedCardIdentifier.Equals(input.BlockedCardIdentifier))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BlockedCardIdentifier != null)
                    hashCode = hashCode * 59 + this.BlockedCardIdentifier.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
