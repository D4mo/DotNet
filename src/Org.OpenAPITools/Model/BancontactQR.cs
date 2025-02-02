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
    /// Bancontact QR information.
    /// </summary>
    [DataContract]
    public partial class BancontactQR : IEquatable<BancontactQR>, IValidatableObject
    {
        /// <summary>
        /// Transaction Routing Means.
        /// </summary>
        /// <value>Transaction Routing Means.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionRoutingMeansEnum
        {
            /// <summary>
            /// Enum QRCode for value: QR Code
            /// </summary>
            [EnumMember(Value = "QR Code")]
            QRCode = 1,

            /// <summary>
            /// Enum URLIntent for value: URL Intent
            /// </summary>
            [EnumMember(Value = "URL Intent")]
            URLIntent = 2

        }

        /// <summary>
        /// Transaction Routing Means.
        /// </summary>
        /// <value>Transaction Routing Means.</value>
        [DataMember(Name = "transactionRoutingMeans", EmitDefaultValue = false)]
        public TransactionRoutingMeansEnum TransactionRoutingMeans { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BancontactQR" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BancontactQR() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BancontactQR" /> class.
        /// </summary>
        /// <param name="transactionRoutingMeans">Transaction Routing Means. (required).</param>
        /// <param name="issuerCustomerReference">Issuer Customer Reference..</param>
        public BancontactQR(TransactionRoutingMeansEnum transactionRoutingMeans = default(TransactionRoutingMeansEnum), string issuerCustomerReference = default(string))
        {
            // to ensure "transactionRoutingMeans" is required (not null)
            this.TransactionRoutingMeans = transactionRoutingMeans;
            this.IssuerCustomerReference = issuerCustomerReference;
        }

        /// <summary>
        /// Issuer Customer Reference.
        /// </summary>
        /// <value>Issuer Customer Reference.</value>
        [DataMember(Name = "issuerCustomerReference", EmitDefaultValue = false)]
        public string IssuerCustomerReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BancontactQR {\n");
            sb.Append("  TransactionRoutingMeans: ").Append(TransactionRoutingMeans).Append("\n");
            sb.Append("  IssuerCustomerReference: ").Append(IssuerCustomerReference).Append("\n");
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
            return this.Equals(input as BancontactQR);
        }

        /// <summary>
        /// Returns true if BancontactQR instances are equal
        /// </summary>
        /// <param name="input">Instance of BancontactQR to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BancontactQR input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionRoutingMeans == input.TransactionRoutingMeans ||
                    (this.TransactionRoutingMeans != null &&
                    this.TransactionRoutingMeans.Equals(input.TransactionRoutingMeans))
                ) && 
                (
                    this.IssuerCustomerReference == input.IssuerCustomerReference ||
                    (this.IssuerCustomerReference != null &&
                    this.IssuerCustomerReference.Equals(input.IssuerCustomerReference))
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
                if (this.TransactionRoutingMeans != null)
                    hashCode = hashCode * 59 + this.TransactionRoutingMeans.GetHashCode();
                if (this.IssuerCustomerReference != null)
                    hashCode = hashCode * 59 + this.IssuerCustomerReference.GetHashCode();
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
            // IssuerCustomerReference (string) maxLength
            if(this.IssuerCustomerReference != null && this.IssuerCustomerReference.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerCustomerReference, length must be less than 254.", new [] { "IssuerCustomerReference" });
            }

            yield break;
        }
    }
}
