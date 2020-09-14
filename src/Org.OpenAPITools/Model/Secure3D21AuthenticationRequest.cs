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
    /// Request authentication of the payment card using the 3DS 2.x URL redirect scheme.
    /// </summary>
    [DataContract]
    public partial class Secure3D21AuthenticationRequest : AuthenticationRequest, IEquatable<Secure3D21AuthenticationRequest>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) 
        /// </summary>
        /// <value>Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeIndicatorEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4

        }

        /// <summary>
        /// Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) 
        /// </summary>
        /// <value>Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) </value>
        [DataMember(Name = "challengeIndicator", EmitDefaultValue = false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }
        /// <summary>
        /// Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen 
        /// </summary>
        /// <value>Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeWindowSizeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5

        }

        /// <summary>
        /// Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen 
        /// </summary>
        /// <value>Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen </value>
        [DataMember(Name = "challengeWindowSize", EmitDefaultValue = false)]
        public ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3D21AuthenticationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationRequest" /> class.
        /// </summary>
        /// <param name="termURL">The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        /// <param name="methodNotificationURL">The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        /// <param name="challengeIndicator">Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed)  (default to ChallengeIndicatorEnum._01).</param>
        /// <param name="challengeWindowSize">Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen .</param>
        /// <param name="authenticationType">Indicates what kind of authentication scheme the merchant wants to use on the card. (required).</param>
        public Secure3D21AuthenticationRequest(string termURL = default(string), string methodNotificationURL = default(string), ChallengeIndicatorEnum? challengeIndicator = ChallengeIndicatorEnum._01, ChallengeWindowSizeEnum? challengeWindowSize = null, string authenticationType = default(string)) : base(authenticationType)
        {
            this.TermURL = termURL;
            this.MethodNotificationURL = methodNotificationURL;
            this.ChallengeIndicator = challengeIndicator;
            this.ChallengeWindowSize = challengeWindowSize;
        }

        /// <summary>
        /// The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "termURL", EmitDefaultValue = false)]
        public string TermURL { get; set; }

        /// <summary>
        /// The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "methodNotificationURL", EmitDefaultValue = false)]
        public string MethodNotificationURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D21AuthenticationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TermURL: ").Append(TermURL).Append("\n");
            sb.Append("  MethodNotificationURL: ").Append(MethodNotificationURL).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  ChallengeWindowSize: ").Append(ChallengeWindowSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Secure3D21AuthenticationRequest);
        }

        /// <summary>
        /// Returns true if Secure3D21AuthenticationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D21AuthenticationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D21AuthenticationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TermURL == input.TermURL ||
                    (this.TermURL != null &&
                    this.TermURL.Equals(input.TermURL))
                ) && base.Equals(input) && 
                (
                    this.MethodNotificationURL == input.MethodNotificationURL ||
                    (this.MethodNotificationURL != null &&
                    this.MethodNotificationURL.Equals(input.MethodNotificationURL))
                ) && base.Equals(input) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator)
                ) && base.Equals(input) && 
                (
                    this.ChallengeWindowSize == input.ChallengeWindowSize ||
                    this.ChallengeWindowSize.Equals(input.ChallengeWindowSize)
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
                int hashCode = base.GetHashCode();
                if (this.TermURL != null)
                    hashCode = hashCode * 59 + this.TermURL.GetHashCode();
                if (this.MethodNotificationURL != null)
                    hashCode = hashCode * 59 + this.MethodNotificationURL.GetHashCode();
                hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.ChallengeWindowSize.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
