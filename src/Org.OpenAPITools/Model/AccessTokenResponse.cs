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
    /// Access token generation response.
    /// </summary>
    [DataContract]
    public partial class AccessTokenResponse : IEquatable<AccessTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="tokenId">Access token for authentication..</param>
        /// <param name="status">The token status..</param>
        /// <param name="issuedOn">Access token issued time in milliseconds..</param>
        /// <param name="expiresInSeconds">Access token expiration time..</param>
        /// <param name="publicKeyBase64">Public key to encrypt data..</param>
        /// <param name="algorithm">Encyption algorithym. One way ECDH 256 bit key..</param>
        /// <param name="clientRequestId">Echoes back the value from the request header for tracking..</param>
        public AccessTokenResponse(string tokenId = default(string), string status = default(string), string issuedOn = default(string), string expiresInSeconds = default(string), string publicKeyBase64 = default(string), string algorithm = default(string), string clientRequestId = default(string))
        {
            this.TokenId = tokenId;
            this.Status = status;
            this.IssuedOn = issuedOn;
            this.ExpiresInSeconds = expiresInSeconds;
            this.PublicKeyBase64 = publicKeyBase64;
            this.Algorithm = algorithm;
            this.ClientRequestId = clientRequestId;
        }

        /// <summary>
        /// Access token for authentication.
        /// </summary>
        /// <value>Access token for authentication.</value>
        [DataMember(Name = "tokenId", EmitDefaultValue = false)]
        public string TokenId { get; set; }

        /// <summary>
        /// The token status.
        /// </summary>
        /// <value>The token status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Access token issued time in milliseconds.
        /// </summary>
        /// <value>Access token issued time in milliseconds.</value>
        [DataMember(Name = "issuedOn", EmitDefaultValue = false)]
        public string IssuedOn { get; set; }

        /// <summary>
        /// Access token expiration time.
        /// </summary>
        /// <value>Access token expiration time.</value>
        [DataMember(Name = "expiresInSeconds", EmitDefaultValue = false)]
        public string ExpiresInSeconds { get; set; }

        /// <summary>
        /// Public key to encrypt data.
        /// </summary>
        /// <value>Public key to encrypt data.</value>
        [DataMember(Name = "publicKeyBase64", EmitDefaultValue = false)]
        public string PublicKeyBase64 { get; set; }

        /// <summary>
        /// Encyption algorithym. One way ECDH 256 bit key.
        /// </summary>
        /// <value>Encyption algorithym. One way ECDH 256 bit key.</value>
        [DataMember(Name = "algorithm", EmitDefaultValue = false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Echoes back the value from the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value from the request header for tracking.</value>
        [DataMember(Name = "clientRequestId", EmitDefaultValue = false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IssuedOn: ").Append(IssuedOn).Append("\n");
            sb.Append("  ExpiresInSeconds: ").Append(ExpiresInSeconds).Append("\n");
            sb.Append("  PublicKeyBase64: ").Append(PublicKeyBase64).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
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
            return this.Equals(input as AccessTokenResponse);
        }

        /// <summary>
        /// Returns true if AccessTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IssuedOn == input.IssuedOn ||
                    (this.IssuedOn != null &&
                    this.IssuedOn.Equals(input.IssuedOn))
                ) && 
                (
                    this.ExpiresInSeconds == input.ExpiresInSeconds ||
                    (this.ExpiresInSeconds != null &&
                    this.ExpiresInSeconds.Equals(input.ExpiresInSeconds))
                ) && 
                (
                    this.PublicKeyBase64 == input.PublicKeyBase64 ||
                    (this.PublicKeyBase64 != null &&
                    this.PublicKeyBase64.Equals(input.PublicKeyBase64))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IssuedOn != null)
                    hashCode = hashCode * 59 + this.IssuedOn.GetHashCode();
                if (this.ExpiresInSeconds != null)
                    hashCode = hashCode * 59 + this.ExpiresInSeconds.GetHashCode();
                if (this.PublicKeyBase64 != null)
                    hashCode = hashCode * 59 + this.PublicKeyBase64.GetHashCode();
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
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
