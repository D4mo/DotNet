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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request authentication of the payment card to verify the cardholder and be eligible for liability shift. An AuthenticationRequest should not be submitted with in the same request as an AuthenticationResult. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "authenticationType")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D21AuthenticationRequest), "Secure3D21AuthenticationRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D10AuthenticationRequest), "Secure3D10AuthenticationRequest")]
    [JsonSubtypes.KnownSubType(typeof(UnionPayAuthenticationRequest), "UnionPayAuthenticationRequest")]
    public partial class AuthenticationRequest :  IEquatable<AuthenticationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationRequest" /> class.
        /// </summary>
        /// <param name="authenticationType">Indicates what kind of authentication scheme the merchant wants to use on the card. (required).</param>
        public AuthenticationRequest(string authenticationType = default(string))
        {
            // to ensure "authenticationType" is required (not null)
            if (authenticationType == null)
            {
                throw new InvalidDataException("authenticationType is a required property for AuthenticationRequest and cannot be null");
            }
            else
            {
                this.AuthenticationType = authenticationType;
            }
            
        }
        
        /// <summary>
        /// Indicates what kind of authentication scheme the merchant wants to use on the card.
        /// </summary>
        /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card.</value>
        [DataMember(Name="authenticationType", EmitDefaultValue=true)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationRequest {\n");
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
            return this.Equals(input as AuthenticationRequest);
        }

        /// <summary>
        /// Returns true if AuthenticationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationRequest input)
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
