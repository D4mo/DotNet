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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Secure3D21AuthenticationResultAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3D21AuthenticationResultAllOf :  IEquatable<Secure3D21AuthenticationResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// The result of authentication attempt returned by the 3D Secure authentication process (PaRes).
        /// </summary>
        /// <value>The result of authentication attempt returned by the 3D Secure authentication process (PaRes).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationResponseEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

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
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 4,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 6

        }

        /// <summary>
        /// The result of authentication attempt returned by the 3D Secure authentication process (PaRes).
        /// </summary>
        /// <value>The result of authentication attempt returned by the 3D Secure authentication process (PaRes).</value>
        [DataMember(Name="authenticationResponse", EmitDefaultValue=false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }
        /// <summary>
        /// The transaction status as returned by the 3D Secure authentication process.
        /// </summary>
        /// <value>The transaction status as returned by the 3D Secure authentication process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

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
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 4,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 6

        }

        /// <summary>
        /// The transaction status as returned by the 3D Secure authentication process.
        /// </summary>
        /// <value>The transaction status as returned by the 3D Secure authentication process.</value>
        [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationResultAllOf" /> class.
        /// </summary>
        /// <param name="cavv">The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase..</param>
        /// <param name="xid">The transaction identifier (XID) is a unique tracking number set by the merchant..</param>
        /// <param name="transactionId">The response transaction UUID. Only applicable to MasterCard..</param>
        /// <param name="authenticationResponse">The result of authentication attempt returned by the 3D Secure authentication process (PaRes). (default to AuthenticationResponseEnum.Y).</param>
        /// <param name="transactionStatus">The transaction status as returned by the 3D Secure authentication process..</param>
        public Secure3D21AuthenticationResultAllOf(string cavv = default(string), string xid = default(string), string transactionId = default(string), AuthenticationResponseEnum? authenticationResponse = AuthenticationResponseEnum.Y, TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?))
        {
            this.Cavv = cavv;
            this.Xid = xid;
            this.TransactionId = transactionId;
            // use default value if no "authenticationResponse" provided
            if (authenticationResponse == null)
            {
                this.AuthenticationResponse = AuthenticationResponseEnum.Y;
            }
            else
            {
                this.AuthenticationResponse = authenticationResponse;
            }
            this.TransactionStatus = transactionStatus;
        }
        
        /// <summary>
        /// The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.
        /// </summary>
        /// <value>The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.</value>
        [DataMember(Name="cavv", EmitDefaultValue=false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The transaction identifier (XID) is a unique tracking number set by the merchant.
        /// </summary>
        /// <value>The transaction identifier (XID) is a unique tracking number set by the merchant.</value>
        [DataMember(Name="xid", EmitDefaultValue=false)]
        public string Xid { get; set; }

        /// <summary>
        /// The response transaction UUID. Only applicable to MasterCard.
        /// </summary>
        /// <value>The response transaction UUID. Only applicable to MasterCard.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D21AuthenticationResultAllOf {\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
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
            return this.Equals(input as Secure3D21AuthenticationResultAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D21AuthenticationResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D21AuthenticationResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D21AuthenticationResultAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    (this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
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
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.AuthenticationResponse != null)
                    hashCode = hashCode * 59 + this.AuthenticationResponse.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
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
