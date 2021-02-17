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
    /// The issuers response to the payment request. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).
    /// </summary>
    [DataContract]
    public partial class IssuerResponse : IEquatable<IssuerResponse>, IValidatableObject
    {
        /// <summary>
        /// The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout).
        /// </summary>
        /// <value>The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 1,

            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 2,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 3,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 4

        }

        /// <summary>
        /// The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout).
        /// </summary>
        /// <value>The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout).</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerResponse" /> class.
        /// </summary>
        /// <param name="code">The verification response code, as sent by the verification system. (required).</param>
        /// <param name="status">The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout)..</param>
        /// <param name="scheme">An identifier of the system/specification from which the code was received, and how the status was derived. (required).</param>
        public IssuerResponse(string code = default(string), StatusEnum? status = null, string scheme = default(string))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for IssuerResponse and cannot be null");
            // to ensure "scheme" is required (not null)
            this.Scheme = scheme ?? throw new ArgumentNullException("scheme is a required property for IssuerResponse and cannot be null");
            this.Status = status;
        }

        /// <summary>
        /// The verification response code, as sent by the verification system.
        /// </summary>
        /// <value>The verification response code, as sent by the verification system.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// An identifier of the system/specification from which the code was received, and how the status was derived.
        /// </summary>
        /// <value>An identifier of the system/specification from which the code was received, and how the status was derived.</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuerResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(input as IssuerResponse);
        }

        /// <summary>
        /// Returns true if IssuerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
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
            // Code (string) pattern
            Regex regexCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            // Scheme (string) pattern
            Regex regexScheme = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexScheme.Match(this.Scheme).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scheme, must match a pattern of " + regexScheme, new [] { "Scheme" });
            }

            yield break;
        }
    }
}
