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
    /// Encrypted Apple Pay payload.
    /// </summary>
    [DataContract]
    public partial class EncryptedApplePay :  IEquatable<EncryptedApplePay>, IValidatableObject
    {
        /// <summary>
        /// Version information about the payment token.
        /// </summary>
        /// <value>Version information about the payment token.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            /// <summary>
            /// Enum ECv1 for value: EC_v1
            /// </summary>
            [EnumMember(Value = "EC_v1")]
            ECv1 = 1

        }

        /// <summary>
        /// Version information about the payment token.
        /// </summary>
        /// <value>Version information about the payment token.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public VersionEnum? Version { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedApplePay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePay" /> class.
        /// </summary>
        /// <param name="data">The encrypted wallet payload. (required).</param>
        /// <param name="header">header (required).</param>
        /// <param name="signature">Signature of the payment and header data. (required).</param>
        /// <param name="version">Version information about the payment token..</param>
        /// <param name="applicationData">Base64-encoded value of PKPaymentRequest. Required only if applicationDataHash is present..</param>
        /// <param name="merchantId">The merchant ID assigned by the wallet provider. (required).</param>
        public EncryptedApplePay(string data = default(string), EncryptedApplePayHeader header = default(EncryptedApplePayHeader), string signature = default(string), VersionEnum? version = default(VersionEnum?), string applicationData = default(string), string merchantId = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for EncryptedApplePay and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            
            // to ensure "header" is required (not null)
            if (header == null)
            {
                throw new InvalidDataException("header is a required property for EncryptedApplePay and cannot be null");
            }
            else
            {
                this.Header = header;
            }
            
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for EncryptedApplePay and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }
            
            // to ensure "merchantId" is required (not null)
            if (merchantId == null)
            {
                throw new InvalidDataException("merchantId is a required property for EncryptedApplePay and cannot be null");
            }
            else
            {
                this.MerchantId = merchantId;
            }
            
            this.Version = version;
            this.ApplicationData = applicationData;
        }
        
        /// <summary>
        /// The encrypted wallet payload.
        /// </summary>
        /// <value>The encrypted wallet payload.</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=true)]
        public EncryptedApplePayHeader Header { get; set; }

        /// <summary>
        /// Signature of the payment and header data.
        /// </summary>
        /// <value>Signature of the payment and header data.</value>
        [DataMember(Name="signature", EmitDefaultValue=true)]
        public string Signature { get; set; }


        /// <summary>
        /// Base64-encoded value of PKPaymentRequest. Required only if applicationDataHash is present.
        /// </summary>
        /// <value>Base64-encoded value of PKPaymentRequest. Required only if applicationDataHash is present.</value>
        [DataMember(Name="applicationData", EmitDefaultValue=false)]
        public string ApplicationData { get; set; }

        /// <summary>
        /// The merchant ID assigned by the wallet provider.
        /// </summary>
        /// <value>The merchant ID assigned by the wallet provider.</value>
        [DataMember(Name="merchantId", EmitDefaultValue=true)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedApplePay {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ApplicationData: ").Append(ApplicationData).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(input as EncryptedApplePay);
        }

        /// <summary>
        /// Returns true if EncryptedApplePay instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedApplePay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedApplePay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ApplicationData == input.ApplicationData ||
                    (this.ApplicationData != null &&
                    this.ApplicationData.Equals(input.ApplicationData))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ApplicationData != null)
                    hashCode = hashCode * 59 + this.ApplicationData.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
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

            
            // Data (string) pattern
            Regex regexData = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexData.Match(this.Data).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, must match a pattern of " + regexData, new [] { "Data" });
            }


            
            // Signature (string) pattern
            Regex regexSignature = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexSignature.Match(this.Signature).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Signature, must match a pattern of " + regexSignature, new [] { "Signature" });
            }


            
            // MerchantId (string) pattern
            Regex regexMerchantId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexMerchantId.Match(this.MerchantId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, must match a pattern of " + regexMerchantId, new [] { "MerchantId" });
            }

            yield break;
        }
    }

}
