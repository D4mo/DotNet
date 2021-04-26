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
    /// Access token generation request.
    /// </summary>
    [DataContract]
    public partial class AccessTokenRequest : IEquatable<AccessTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenRequest" /> class.
        /// </summary>
        /// <param name="domain">Domain name. (required).</param>
        /// <param name="token">The token value. (required).</param>
        /// <param name="publicKeyRequired">Indicates whether public key is requested or not. (required).</param>
        public AccessTokenRequest(string domain = default(string), string token = default(string), bool publicKeyRequired = default(bool))
        {
            // to ensure "domain" is required (not null)
            this.Domain = domain ?? throw new ArgumentNullException("domain is a required property for AccessTokenRequest and cannot be null");
            // to ensure "token" is required (not null)
            this.Token = token ?? throw new ArgumentNullException("token is a required property for AccessTokenRequest and cannot be null");
            // to ensure "publicKeyRequired" is required (not null)
            this.PublicKeyRequired = publicKeyRequired;
        }

        /// <summary>
        /// Domain name.
        /// </summary>
        /// <value>Domain name.</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// The token value.
        /// </summary>
        /// <value>The token value.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Indicates whether public key is requested or not.
        /// </summary>
        /// <value>Indicates whether public key is requested or not.</value>
        [DataMember(Name = "publicKeyRequired", EmitDefaultValue = false)]
        public bool PublicKeyRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  PublicKeyRequired: ").Append(PublicKeyRequired).Append("\n");
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
            return this.Equals(input as AccessTokenRequest);
        }

        /// <summary>
        /// Returns true if AccessTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.PublicKeyRequired == input.PublicKeyRequired ||
                    (this.PublicKeyRequired != null &&
                    this.PublicKeyRequired.Equals(input.PublicKeyRequired))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.PublicKeyRequired != null)
                    hashCode = hashCode * 59 + this.PublicKeyRequired.GetHashCode();
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
