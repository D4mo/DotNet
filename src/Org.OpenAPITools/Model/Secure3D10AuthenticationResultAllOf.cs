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
    /// Secure3D10AuthenticationResultAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3D10AuthenticationResultAllOf : IEquatable<Secure3D10AuthenticationResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Card enrollment result from the Verification Response (VeRes).
        /// </summary>
        /// <value>Card enrollment result from the Verification Response (VeRes).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerificationResponseEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3

        }

        /// <summary>
        /// Card enrollment result from the Verification Response (VeRes).
        /// </summary>
        /// <value>Card enrollment result from the Verification Response (VeRes).</value>
        [DataMember(Name = "verificationResponse", EmitDefaultValue = false)]
        public VerificationResponseEnum? VerificationResponse { get; set; }
        /// <summary>
        /// Result of authentication attempt from Payer Authentication Response (PaRes).
        /// </summary>
        /// <value>Result of authentication attempt from Payer Authentication Response (PaRes).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationAttemptResultEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,

            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 4

        }

        /// <summary>
        /// Result of authentication attempt from Payer Authentication Response (PaRes).
        /// </summary>
        /// <value>Result of authentication attempt from Payer Authentication Response (PaRes).</value>
        [DataMember(Name = "authenticationAttemptResult", EmitDefaultValue = false)]
        public AuthenticationAttemptResultEnum? AuthenticationAttemptResult { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationResultAllOf" /> class.
        /// </summary>
        /// <param name="verificationResponse">Card enrollment result from the Verification Response (VeRes)..</param>
        /// <param name="authenticationAttemptResult">Result of authentication attempt from Payer Authentication Response (PaRes)..</param>
        /// <param name="cavv">The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase..</param>
        /// <param name="xid">The transaction identifier (XID) is a unique tracking number set by the merchant..</param>
        public Secure3D10AuthenticationResultAllOf(VerificationResponseEnum? verificationResponse = null, AuthenticationAttemptResultEnum? authenticationAttemptResult = null, string cavv = default(string), string xid = default(string))
        {
            this.VerificationResponse = verificationResponse;
            this.AuthenticationAttemptResult = authenticationAttemptResult;
            this.Cavv = cavv;
            this.Xid = xid;
        }

        /// <summary>
        /// The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.
        /// </summary>
        /// <value>The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The transaction identifier (XID) is a unique tracking number set by the merchant.
        /// </summary>
        /// <value>The transaction identifier (XID) is a unique tracking number set by the merchant.</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public string Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D10AuthenticationResultAllOf {\n");
            sb.Append("  VerificationResponse: ").Append(VerificationResponse).Append("\n");
            sb.Append("  AuthenticationAttemptResult: ").Append(AuthenticationAttemptResult).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as Secure3D10AuthenticationResultAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D10AuthenticationResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D10AuthenticationResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D10AuthenticationResultAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerificationResponse == input.VerificationResponse ||
                    this.VerificationResponse.Equals(input.VerificationResponse)
                ) && 
                (
                    this.AuthenticationAttemptResult == input.AuthenticationAttemptResult ||
                    this.AuthenticationAttemptResult.Equals(input.AuthenticationAttemptResult)
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
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
                hashCode = hashCode * 59 + this.VerificationResponse.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationAttemptResult.GetHashCode();
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
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
            // Cavv (string) maxLength
            if(this.Cavv != null && this.Cavv.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cavv, length must be less than 32.", new [] { "Cavv" });
            }

            // Cavv (string) minLength
            if(this.Cavv != null && this.Cavv.Length < 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cavv, length must be greater than 20.", new [] { "Cavv" });
            }

            // Xid (string) maxLength
            if(this.Xid != null && this.Xid.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Xid, length must be less than 32.", new [] { "Xid" });
            }

            // Xid (string) minLength
            if(this.Xid != null && this.Xid.Length < 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Xid, length must be greater than 20.", new [] { "Xid" });
            }

            yield break;
        }
    }
}
