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
    /// EncryptedGooglePayWalletPaymentMethodAllOf
    /// </summary>
    [DataContract]
    public partial class EncryptedGooglePayWalletPaymentMethodAllOf : IEquatable<EncryptedGooglePayWalletPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedGooglePayWalletPaymentMethodAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedGooglePayWalletPaymentMethodAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedGooglePayWalletPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="encryptedGooglePay">encryptedGooglePay (required).</param>
        public EncryptedGooglePayWalletPaymentMethodAllOf(EncryptedGooglePay encryptedGooglePay = default(EncryptedGooglePay))
        {
            // to ensure "encryptedGooglePay" is required (not null)
            this.EncryptedGooglePay = encryptedGooglePay ?? throw new ArgumentNullException("encryptedGooglePay is a required property for EncryptedGooglePayWalletPaymentMethodAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets EncryptedGooglePay
        /// </summary>
        [DataMember(Name = "encryptedGooglePay", EmitDefaultValue = false)]
        public EncryptedGooglePay EncryptedGooglePay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedGooglePayWalletPaymentMethodAllOf {\n");
            sb.Append("  EncryptedGooglePay: ").Append(EncryptedGooglePay).Append("\n");
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
            return this.Equals(input as EncryptedGooglePayWalletPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if EncryptedGooglePayWalletPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedGooglePayWalletPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedGooglePayWalletPaymentMethodAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptedGooglePay == input.EncryptedGooglePay ||
                    (this.EncryptedGooglePay != null &&
                    this.EncryptedGooglePay.Equals(input.EncryptedGooglePay))
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
                if (this.EncryptedGooglePay != null)
                    hashCode = hashCode * 59 + this.EncryptedGooglePay.GetHashCode();
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
