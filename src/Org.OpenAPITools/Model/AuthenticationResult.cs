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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Submit the result of 3DS authentication managed outside of the gateway. An AuthenticationResult should not be submitted within the same request as an AuthenticationRequest. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "AuthenticationType")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D10AuthenticationResult), "Secure3D10AuthenticationResult")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D21AuthenticationResult), "Secure3D21AuthenticationResult")]
    [JsonSubtypes.KnownSubType(typeof(Secure3DAuthenticationResult), "Secure3DAuthenticationResult")]
    public partial class AuthenticationResult : IEquatable<AuthenticationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResult" /> class.
        /// </summary>
        /// <param name="authenticationType">Specifies the version of 3DS to be used where authentication was managed outside of the gateway. (required).</param>
        public AuthenticationResult(string authenticationType = default(string))
        {
            // to ensure "authenticationType" is required (not null)
            this.AuthenticationType = authenticationType ?? throw new ArgumentNullException("authenticationType is a required property for AuthenticationResult and cannot be null");
        }

        /// <summary>
        /// Specifies the version of 3DS to be used where authentication was managed outside of the gateway.
        /// </summary>
        /// <value>Specifies the version of 3DS to be used where authentication was managed outside of the gateway.</value>
        [DataMember(Name = "authenticationType", EmitDefaultValue = false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationResult {\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
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
            return this.Equals(input as AuthenticationResult);
        }

        /// <summary>
        /// Returns true if AuthenticationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
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
                if (this.AuthenticationType != null)
                    hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
